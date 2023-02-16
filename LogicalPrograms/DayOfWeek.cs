using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class DayOfWeek
    {
        public static void Week()
        {
            int m = 0, y = 0, d = 0, x = 0, Y0 = 0, M0 = 0, D0 = 0;
            Console.WriteLine("Enter the month");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            y = Convert.ToInt32(Console.ReadLine());

            Y0 = y - (14 - m) / 12;
            x = Y0 + Y0 / 4 - Y0 / 100 + Y0 / 400;
            M0 = m + 12 * ((14 - m) / 12) - 2;
            D0 = (d + x + 31 * M0 / 12) % 7;

            switch (D0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
