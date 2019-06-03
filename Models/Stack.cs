using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Stack
    {
        public bool FirstRow { get; }
        public bool LastRow { get; }
        public bool CooledContainer { get; }
        public List<Container> Containers { get; }

        public Stack(bool first, bool last)
        {
            FirstRow = first;
            LastRow = last;
            CooledContainer = first;
            Containers = new List<Container>();
        }

        public Stack()
        {
            FirstRow = false;
            LastRow = false;
            CooledContainer = false;
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

        public bool IsContainerAllowed(Container container)
        {
            if (container.ValuableContainer && !FirstRow && !LastRow) return false;

            if (container.CooledContainer && !CooledContainer) return false;

            if (IsTopContainerValuable()) return false;

            if (!IsWeightAllowed(container)) return false;

            return true;
        }

        public bool AddContainer(Container container)
        {
            if (!IsContainerAllowed(container)) return false;

            foreach (var containerList in Containers)
            {
                containerList.AddWeight(container.Weight);
            }

            Containers.Add(container);
            return true;
        }

        public override string ToString()
        {
            return Containers.Count.ToString() + ", " + FirstRow.ToString() + ", " + LastRow.ToString();
        }
    }
}