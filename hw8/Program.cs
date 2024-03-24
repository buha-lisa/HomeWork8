using System.Collections.Generic;

namespace hw8
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        ICalc calc = new Array();
                        Console.WriteLine($"{calc.Less(5)}");
                        Console.WriteLine($"{calc.Greater(5)}");
                        break;
                    case 2:
                        IOutput2 output2 = new Array();
                        output2.ShowEven();
                        output2.ShowOdd();
                        break;
                    case 3:
                        ICalc2 calc2 = new Array();
                        Console.WriteLine($"{calc2.CountDistinct()}");
                        Console.WriteLine($"{calc2.EqualToValue(1)}");
                        break;
                }
                if (task == 0) break;
            }
        }
    }
}
