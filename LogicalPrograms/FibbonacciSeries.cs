using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibbonacciSeries
    {
        public static void FibNumber()
        {
            int i = 0, j = 1, k = 2, num = 0;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibbonacci series:" + i);
            Console.WriteLine("Fibbonacci series:" + j);
            for (k = 2; k < num; k++)
            {
                k = i + j;
                Console.WriteLine("Fibbonacci series:" + k);
                i = j;
                j = k;
            }
            Console.ReadLine();
        }
    }
}
