using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class perfectNumber
    {
        public static void Number()
        {
            int num = 0, i = 1, sum = 0;
            Console.WriteLine("Enter number to calculate perfect number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 1 && i < num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Value is:" + i);
                    sum = sum + i;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("Perfect number is:" + i);
        }
    }
}
