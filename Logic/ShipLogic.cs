using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Ship SortContainers(IEnumerable<Container> containers)
        {
            //Sorteed de containers op gekoeld
            var sortedContainers = containers.OrderBy(e => e.CooledContainer).ToList();

            //Sorteed de containers op waardevol
            sortedContainers = sortedContainers.OrderBy(e => e.ValuableContainer).ToList();

            //Loopt door elke container heen die gesorteerd zijn.
            foreach (var container in sortedContainers)
            {
                UnSortedContainers.Add(container);

                if (Ship.AddContainer(container))
                {
                    //Als de cotainer toegevoegd is, verwijder deze dan van de niet gesorteerde lijst.
                    UnSortedContainers.Remove(container);
                }
            }

            return Ship;
        }
    }
}
