namespace Models
{
    public class Ship
    {
        public int Length { get; }
        public int Width { get; }

        public StackOfContainer[,] StackOfContainer { get; private set; }

        public Ship(int width, int length)
        {
            Length = length;
            Width = width;
            StackOfContainer = new StackOfContainer[width, length];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j == 0)
                    {
                        //De stapel van containers laten weten dat dit de 1e rij is.
                        StackOfContainer[i, j] = new StackOfContainer(true, false);
                    }
                    else if (j == length - 1)
                    {
                        //De stapel van containers laten weten dat dit de laatste rij is.
                        StackOfContainer[i, j] = new StackOfContainer(false, true);
                    }
                    else
                    {
                        //De stapel van containers laten weten dat dit de middelste rij is.
                        StackOfContainer[i, j] = new StackOfContainer(false, false);
                    }
                }
            }
        }

        private int GetColumnsWeight(int col1, int col2)
        {
            var weight = 0;

            for (int i = col1; i < col2; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    weight += StackOfContainer[i, j].GetWeight();
                }
            }
            return weight;
        }

        //Controleerd bij het toevoegen van een container op de huidige kolom of het schip zijn balans houdt.
        public bool CheckBalance(Container container, int col)
        {
            var left = 0;
            var right = 0;

            var width = StackOfContainer.GetLength(0);
            var mid = width / 2;

            var isUneven = width % 2 != 0;

            if (col == mid) return true;

            if (isUneven)
            {
                //oneven
                left = GetColumnsWeight(0, mid + 1);
                right = GetColumnsWeight(mid + 1, width);

                if (col < mid + 1)
                {
                    left += container.Weight;
                }
                else if (col > mid + 1)
                {
                    right += container.Weight;
                }
            }
            else
            {
                //even
                left = GetColumnsWeight(0, mid);
                right = GetColumnsWeight(mid, width);

                if (col < mid)
                {
                    left += container.Weight;
                }
                else
                {
                    right += container.Weight;
                }
            }

            //if (isUneven)
            //{
            //    if (column < mid + 1)
            //    {
            //        left += container.Weight;
            //    }
            //    else if (column > mid + 1)
            //    {
            //        right += container.Weight;
            //    }
            //}
            //else
            //{
            //    if (column < mid)
            //    {
            //        left += container.Weight;
            //    }
            //    else
            //    {
            //        right += container.Weight;
            //    }
            //}

            var weight = left + right;

            var percLeft = 0;
            var percRight = 0;
            var percDifference = 0;

            if (weight != 0)
            {
                percLeft = left / weight * 100;
                percRight = right / weight * 100;
            }
            else
            {
                percLeft = 0;
                percRight = 0;
            }

            if (percLeft < percRight)
            {
                percDifference = percRight - percLeft;
            }
            else
            {
                percDifference = percLeft - percRight;
            }

            if (percDifference > 20 && percDifference <= 100) return false;

            return true;
        }

        public bool AddContainer(Container container)
        {
            //Voor elk kolom op het schip
            for (var i = 0; i < Width; i++)
            {
                //Controleerd of het schip zijn balans houdt, als de container wordt toegevoegd aan de stapel 
                if (!CheckBalance(container, i)) continue;

                //Voor elke rij in de huidige kolom op het schip
                for (var j = 0; j < Length; j++)
                {
                    //Contoleerd of de container kan worden toegevoegd.
                    if (StackOfContainer[i, j].AddContainer(container)) return true;
                }
            }

            return false;
        }
    }
}
