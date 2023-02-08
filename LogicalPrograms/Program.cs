using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the logical programs");
            Console.WriteLine("Choose option from below");
            Console.WriteLine("1.FibbonacciSeries\n2.Perfect Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibbonacciSeries.FibNumber();
                    break;

                case 2:
                    perfectNumber.Number();
                    break;
            }
         }
    }
}
