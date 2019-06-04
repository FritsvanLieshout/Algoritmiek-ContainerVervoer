using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Stack
    {
        public bool Front { get; }
        public bool Back { get; }
        //public bool CooledContainer { get; }
        public List<Container> Containers { get; }

        public Stack(bool front, bool back)
        {
            Front = front;
            Back = back;
            //CooledContainer = front;
            Containers = new List<Container>();
        }

        public Stack()
        {
            Front = false;
            Back = false;
            //CooledContainer = false;
            Containers = new List<Container>();
        }

        public int GetWeight()
        {
            var weight = 0;

            foreach (var container in Containers)
            {
                weight += container.Weight;
            }

            return weight;
        }

        public bool IsWeightAllowed(Container container)
        {
            if (Containers.Count < 1) return true;

            return Containers.First().TopWeight + container.Weight < 120000;
        }

        public bool IsTopContainerValuable()
        {
            return Containers.Count > 0 && Containers.Last().ValuableContainer;
        }

        public bool IsContainerAllowed(Container container, Ship ship, int width, int length)
        {
            if (container.ValuableContainer && Front) return false;

            if (container.ValuableContainer && Back) return false;

            if (container.CooledContainer && !Front) return false;

            if (container.ValuableContainer && CheckSpaceForValuable(ship, width, length)) return false;

            if (IsTopContainerValuable()) return false;

            if (!IsWeightAllowed(container)) return false;

            return true;
        }

        public bool CheckSpaceForValuable(Ship ship, int width, int length)
        {
            if (ship.Stack[width, length -= 1].HaveContainerSpace(ship.Stack[width, length].Containers.Count, Containers.Count)) return true;

            length += 2;
            if (length > ship.Stack.Length) return true;

            if (ship.Stack[width, length].HaveContainerSpace(ship.Stack[width, length].Containers.Count, Containers.Count)) return true;
            else return false;

        }

        public bool HaveContainerSpace(int height, int current)
        {
            if (current + 1 <= height) return true;

            else return false;
        }

        public bool AddContainer(Container container, Ship ship, int width, int length)
        {
            if (!IsContainerAllowed(container, ship, width, length)) return false;

            foreach (var containerList in Containers)
            {
                containerList.AddWeight(container.Weight);
            }

            Containers.Add(container);
            return true;
        }

        public override string ToString()
        {
            return Containers.Count.ToString() + ", " + Front.ToString() + ", " + Back.ToString();
        }
    }
}