namespace Models
{
    public class Ship
    {
        public int Length { get; }
        public int Width { get; }
        public int Left { get; set; }
        public int Right { get; set; }
        public decimal Median { get; set; }
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
            MaxWeight = (width * length) * 150000;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j == 0)
                    {
                        //De stapel van containers laten weten dat dit de 1e rij is.
                        Stack[i, j] = new Stack(true, false);
                    }
                    else if (j == length - 1)
                    {
                        //De stapel van containers laten weten dat dit de laatste rij is.
                        Stack[i, j] = new Stack(false, true);
                    }
                    else
                    {
                        //De stapel van containers laten weten dat dit de middelste rij is.
                        Stack[i, j] = new Stack(false, false);
                    }
                }
            }
        }

        public void SetWeight(int i, Container container, int even, int uneven)
        {
            if (i < Median - even) Left += container.Weight;

            if (i > Median - uneven) Right += container.Weight;
        }

        public bool AddContainer(Container container)
        {
            for (int i = 0; i < Length; i++)
            {
                int mid = (int)Median + 1;
                if (Left > Right)
                {
                    for (int j = mid - 1; j < Width; j++)
                    {
                        if (Stack[j, i].AddContainer(container, this, j, i))
                        {
                            if (Median % 2 != 0)
                            {
                                SetWeight(j, container, 1, 0);
                            }
                            else
                            {
                                SetWeight(j, container, 0, 1);
                            }
                            return true;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < mid; j++)
                    {
                        if (Stack[j, i].AddContainer(container, this, j, i))
                        {
                            if (Median % 2 != 0)
                            {
                                SetWeight(j, container, 1, 0);
                            }
                            else
                            {
                                SetWeight(j, container, 0, 1);
                            }
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}