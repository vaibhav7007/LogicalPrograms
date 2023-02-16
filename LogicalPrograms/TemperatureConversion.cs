using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TemperatureConversion
    {
        public static void tempCelsiusToFarheneit()
        {
            int Celsius = 0, Farheneit = 0;
            Console.WriteLine("Enter the temperature");
            Celsius = Convert.ToInt32(Console.ReadLine());
            Farheneit = ((Celsius * 9 / 5) + 32);
            Console.WriteLine("The value of celsius to farheneit is:{0}", Farheneit);
        }

        public static void tempFarheneitToCelsius()
        {
            int Celsius = 0, Farheneit = 0;
            Console.WriteLine("Enter the temperature");
            Farheneit = Convert.ToInt32(Console.ReadLine());
            Celsius = ((Farheneit - 32) * 5 / 9);
            Console.WriteLine("The value of Farheneit to celsius is:{0}", Celsius);
        }
    }
}
