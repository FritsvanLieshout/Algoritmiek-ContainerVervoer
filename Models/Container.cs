using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Container
    {
        public int Weight { get; }
        public int TopWeight { get; private set; }
        public bool CooledContainer { get; }
        public bool ValuableContainer { get; }

        public Container(int weight, bool valuable, bool cooled)
        {
            Weight = weight;
            TopWeight = 0;
            CooledContainer = cooled;
            ValuableContainer = valuable;
        }

        public void AddWeight(int weight)
        {
            TopWeight += weight;
        }

        public override string ToString()
        {
            return "Weight: " + Weight + ", Cooled: " + CooledContainer  + ", Valuable: " + ValuableContainer;
        }
    }
}
