using System;

namespace hw8
{
    internal class Array : ICalc, IOutput2, ICalc2
    {
        public int[] Ints = { 3, 5, 6, 7, 8, 1 };

        /*1*/
        public int Less(int valueToCompare)
        {
            int result = 0;
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i] < valueToCompare) result++;
            }
            return result;
        }
        public int Greater(int valueToCompare)
        {
            int result = 0;
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i] > valueToCompare) result++;
            }
            return result;
        }

        /*2*/
        public void ShowEven()
        {
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i]%2==0) Console.Write($"{Ints[i]} ");
            }
            Console.Write($"\n");
        }
        public void ShowOdd()
        {
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i] % 2 != 0) Console.Write($"{Ints[i]} ");
            }
        }

        /*3*/
        public int CountDistinct()
        {
            int result = 0;
            bool[] visited = new bool[Ints.Length];

            for (int i = 0; i < Ints.Length; i++)
            {
                if (!visited[i])
                {
                    result++;
                    for (int j = i + 1; j < Ints.Length; j++)
                    {
                        if (Ints[i] == Ints[j])
                        {
                            visited[j] = true;
                        }
                    }
                }
            }
            return result;
        }
        public int EqualToValue(int valueToCompare)
        {
            int result = 0;
            for (int i = 0; i < Ints.Length; i++)
            {
                if (Ints[i] == valueToCompare) result++;
            }
            return result;
        }
    }
}
