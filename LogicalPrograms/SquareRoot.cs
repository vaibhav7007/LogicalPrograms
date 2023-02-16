using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SquareRoot
    {
        public static void sqrt()
        {
            Console.WriteLine("Enter the value");
            double c = Convert.ToDouble(Console.ReadLine());
            double t = c, epsilon = 1e-15;

            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
                Console.WriteLine("square root of number is" + t);
            }
        }
    }
}
