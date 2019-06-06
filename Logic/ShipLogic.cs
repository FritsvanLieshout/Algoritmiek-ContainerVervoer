using Models;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class ShipLogic
    {
        public Ship Ship { get; private set; }

        public List<Container> UnSortedContainers { get; private set; } = new List<Container>();

        public ShipLogic(int width, int length)
        {
            Ship = new Ship(width, length);
        }

        public Ship SortContainers(List<Container> containers)
        {
            var sortedContainers = containers.Where(e => e.CooledContainer).OrderByDescending(e => e.Weight).ToList();
            sortedContainers.AddRange(containers.Where(e => e.ValuableContainer == false && e.CooledContainer == false).OrderByDescending(e => e.Weight).ToList());
            sortedContainers.AddRange(containers.Where(e => e.ValuableContainer).OrderByDescending(e => e.Weight).ToList());

            foreach (var container in sortedContainers)
            {
                UnSortedContainers.Add(container);
                if (Ship.AddContainer(container))
                {
                    UnSortedContainers.Remove(container);
                }
            }
            return Ship;
        }
    }
}