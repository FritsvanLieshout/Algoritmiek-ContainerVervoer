namespace Models
{
    public class Ship
    {
        public int Length { get; }
        public int Width { get; }
        public int Left { get; set; }
        public int Right { get; set; }
        public decimal Median { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int MaxWeight { get; set; }

        public Stack[,] Stack { get; private set; }

        public Ship(int width, int length)
        {
            Length = length;
            Width = width;
            Stack = new Stack[width, length];
            Weight = 0;
            Median = decimal.Divide(width, 2);
            MaxWeight = CalculateMaxWeightOfShip();

            for (int w = 0; w < width; w++)
            {
                for (int l = 0; l < length; l++)
                {
                    if (l == 0)
                    {
                        //De stapel van containers laten weten dat dit de 1e rij is.
                        Stack[w, l] = new Stack(true, false);
                    }
                    else if (l == length - 1)
                    {
                        //De stapel van containers laten weten dat dit de laatste rij is.
                        Stack[w, l] = new Stack(false, true);
                    }
                    else
                    {
                        //De stapel van containers laten weten dat dit de middelste rij is.
                        Stack[w, l] = new Stack(false, false);
                    }
                }
            }
        }

        public int CalculateMaxWeightOfShip()
        {
            var maxWeight = (Width * Length) * 150000;
            return maxWeight;
        }

        public void WeightSetter(int width, Container container, int even, int uneven)
        {
            if (width < Median - even) Left += container.Weight;

            if (width > Median - uneven) Right += container.Weight;
        }

        public bool TryToAddContainer(int weight, int length, int height, Container container)
        {
            if (Stack[weight, length].Containers.Count == height)
            {
                if (Stack[weight, length].AddContainer(container, this, weight, length))
                {
                    if (Median % 2 == 0)
                    {
                        WeightSetter(weight, container, 0, 1);
                    }
                    else
                    {
                        WeightSetter(weight, container, 1, 0);
                    }
                    return true;
                }
            }
            return false;
        }

        public bool PlaceContainerToRight(int length, int mid, Container container, int height)
        {
            for (int width = mid - 1; width < Width; width++)
            {
                if (TryToAddContainer(width, length, height, container)) return true;
                else continue;
            }
            return false;
        }

        public bool PlaceContainerToLeft(int length, int mid, Container container, int height)
        {
            for (int width = 0; width < mid; width++)
            {
                if (TryToAddContainer(width, length, height, container)) return true;
                else continue;
            }
            return false;
        }

        public bool AddContainer(Container container)
        {
            for (int height = 0; height <= 30; height++)
            {
                for (int length = 0; length < Length; length++)
                {
                    var mid = (int)Median + 1;
                    if (Left > Right)
                    {
                        if (PlaceContainerToRight(length, mid, container, height))
                        {
                            Weight += container.Weight;
                            return true;
                        }
                        else continue;
                    }
                    else
                    {
                        if (PlaceContainerToLeft(length, mid, container, height))
                        {
                            Weight += container.Weight;
                            return true;
                        }
                        else continue;
                    }
                }
                continue;
            }
            return false;
        }
    }
}