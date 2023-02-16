using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the logical programs");
            Console.WriteLine("Choose option from below");
            Console.WriteLine("1.FibbonacciSeries\n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n7.Vending Machine\n8.Day Of Week");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibbonacciSeries.FibNumber();
                    break;

                case 2:
                    perfectNumber.Number();
                    break;

                case 3:
                    PrimeNumber.CheckNum();
                    break;

                case 4:
                    ReverseNumber.ReverseProgram();
                    break;

                case 7:
                    VendingMachine.countCurrency();
                    break;

                case 8:
                    DayOfWeek.Week();
                    break;
            }
         }
    }
}
