using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class MonthlyPayment
    {
        public static void payments()
        {
            double P = 0, Y = 0, R = 0, Amount = 0, n = 12 * Y, r = R / (12 * 100);
            Console.WriteLine("Enter the principal loan amount");
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the years to pay off");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the percent interest compound monthly");
            R = Convert.ToInt32(Console.ReadLine());
            
            Amount = P * r / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Monthly payment is:" + Amount);
        }
    }
}
