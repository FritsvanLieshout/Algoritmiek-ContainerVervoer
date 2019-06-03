using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Stack
    {
        public bool FrontRow { get; }
        public bool BackRow { get; }
        public bool CooledContainer { get; }
        public List<Container> Containers { get; }

        public Stack(bool frontRow, bool backRow)
        {
            FrontRow = frontRow;
            BackRow = backRow;
            CooledContainer = frontRow;
            Containers = new List<Container>();
        }

        public Stack()
        {
            FrontRow = false;
            BackRow = false;
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
            if (container.ValuableContainer && !FrontRow && !BackRow) return false;

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
    }
}
