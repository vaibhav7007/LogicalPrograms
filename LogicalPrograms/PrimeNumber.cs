using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void CheckNum()
        {
            int i = 2, num = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            bool IsPrime = true;
            for (i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
        }
    }
}
