namespace Models
{
    public class Ship
    {
        public int Length { get; }
        public int Width { get; }

        //public int Left { get; set; }
        //public int Right { get; set; }
        //public int Median { get; set; }
        public int Weight { get; set; }
        public int MaxWeight { get; set; }

        public Stack[,] Stack { get; private set; }

        public Ship(int width, int length, int maxWeight)
        {
            Length = length;
            Width = width;
            Stack = new Stack[width, length];
            Weight = 0;
            MaxWeight = maxWeight;

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

        private int GetColumnsWeight(int col1, int col2)
        {
            var weight = 0;

            for (int i = col1; i < col2; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    weight += Stack[i, j].GetWeight();
                }
            }
            return weight;
        }

        //public bool IsEven(Container container, int width, int col)
        //{
        //    Left = GetColumnsWeight(0, Median);
        //    Right = GetColumnsWeight(Median, width);

        //    if (col < Median) { Left += container.Weight; }
        //    else { Right += container.Weight; }
        //    return false;
        //}

        //public bool IsUneven(Container container, int width, int col)
        //{
        //    var isUneven = width % 2 != 0;
        //    if (isUneven)
        //    {
        //        Left = GetColumnsWeight(0, Median + 1); Right = GetColumnsWeight(Median + 1, width);
        //        if (col < Median + 1) { Left += container.Weight; }
        //        else if (col > Median + 1) { Right += container.Weight; }
        //        else { IsEven(container, width, col); }
        //    }
        //    return false;
        //}

        //public bool CalcPerc()
        //{
        //    var weight = Left + Right;
        //    int percLeft;
        //    int percRight;
        //    int percDifference;

        //    if (weight != 0) { percLeft = Left / weight * 100; percRight = Right / weight * 100; }
        //    else { percLeft = 0; percRight = 0; }

        //    if (percLeft < percRight) { percDifference = percRight - percLeft; }
        //    else { percDifference = percLeft - percRight; }

        //    if (percDifference > 20 && percDifference <= 100) return false;

        //    return true;
        //}

        //public bool CalcBalance(Container container, int col)
        //{
        //    var width = Stack.GetLength(0);
        //    Median = width / 2;

        //    if (col == Median) return true;
        //    if (IsUneven(container, width, col)) return true;
        //    else if (IsEven(container, width, col)) return true;
        //    else return false;
        //}

        //Controleerd bij het toevoegen van een container op de huidige kolom of het schip zijn balans houdt.
        public bool CheckBalance(Container container, int col)
        {
            int left;
            int right;

            var width = Stack.GetLength(0);
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

            var weight = left + right;

            int percLeft;
            int percRight;
            int percDifference;

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
                    if (Stack[i, j].AddContainer(container, this, i, j)) return true;
                }
            }

            return false;
        }

        public bool IsFrontAndBackClear(Container container, int width, int length)
        {
            //if (Stack[x - 1, y].HasContainer()) return false;
            //else if (Stack[x + 1, y].HasContainer()) return false;
            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
}