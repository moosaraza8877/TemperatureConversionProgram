using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp, newTemp;
            string scale;
            Console.WriteLine("Temperature conversion program");
            Console.Write("Enter the temperature scale: ");
            scale = Console.ReadLine();
            Console.Write("Enter the temperature: ");
            temp = Convert.ToDouble(Console.ReadLine());
            if (scale == "Fahrenheit" || scale == "fahrenheit" || scale == "f" || scale == "F")
            {
                newTemp = (temp - 32) * 5 / 9;
                Console.WriteLine("Temperature in Celsius is {0}°", newTemp);
            }
            if (scale == "Celsius" || scale == "celsius" || scale == "C" || scale == "c")
            {
                newTemp = (temp * 9 / 5) + 32;
                Console.WriteLine("Temperature in Fahrenheit is {0}°", newTemp);
            }
        }
    }
}
