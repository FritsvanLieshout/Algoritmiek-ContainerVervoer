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

        /*public int GetColumnsWeight(int col1, int col2)
        {
            var weight = 0;

            for (int i = col1; i < col2; i++)
            {
                for (int j = 0; j < Ship.Length; j++)
                {
                    weight += Ship.Stack[i, j].GetWeight();
                }
            }
            return weight;
        }


        public bool IsUneven()
        {
            var width = Ship.Stack.GetLength(0);
            Ship.Median = width / 2;

            var isUneven = width % 2 != 0;
            if (isUneven)
            {
                Ship.Left = GetColumnsWeight(0, Ship.Median + 1);
                Ship.Right = GetColumnsWeight(Ship.Median + 1, width);
            }
            else { return false; }

            return true;
        }

        public int CalcPerc()
        {
            var weight = Ship.Left + Ship.Right;
            var percLeft = 0;
            var percRight = 0;
            int percDifference;

            if (weight != 0)
            {
                percLeft = Ship.Left / weight * 100;
                percRight = Ship.Right / weight * 100;
            }

            if (percLeft < percRight)
            {
                percDifference = percRight - percLeft;
            }
            else
            {
                percDifference = percLeft - percRight;
            }

            return percDifference;

        }

        public bool CheckBalance(Container container, int col)
        {
            var width = Ship.Stack.GetLength(0);
            Ship.Median = width / 2;

            if (col == Ship.Median) return true;

            if (IsUneven())
            {
                if (col < Ship.Median + 1)
                {
                    Ship.Left += container.Weight;
                }
                else if (col > Ship.Median + 1)
                {
                    Ship.Right += container.Weight;
                }
            }
            else
            {
                //even
                Ship.Left = GetColumnsWeight(0, Ship.Median);
                Ship.Right = GetColumnsWeight(Ship.Median, width);

                if (col < Ship.Median)
                {
                    Ship.Left += container.Weight;
                }
                else
                {
                    Ship.Right += container.Weight;
                }
            }
            if (CalcPerc() > 20 && CalcPerc() <= 100) return false;

            return true;
        }

        public bool AddContainer(Container container)
        {
            //Voor elk kolom op het schip
            for (var i = 0; i < Ship.Width; i++)
            {
                //Controleerd of het schip zijn balans houdt, als de container wordt toegevoegd aan de stapel 
                if (!CheckBalance(container, i)) continue;

                //Voor elke rij in de huidige kolom op het schip
                for (var j = 0; j < Ship.Length; j++)
                {
                    //Contoleerd of de container kan worden toegevoegd.
                    if (Ship.Stack[i, j].AddContainer(container)) return true;
                }
            }

            return false;
        }*/

        public IEnumerable<Ship> SortContainers(IEnumerable<Container> containers)
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
            yield return Ship;
            Ship = new Ship(5, 10);
        }
    }
}
