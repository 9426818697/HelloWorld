using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, c;

            //Celsius To Fahrenheit Conversion f=c*(9/5)+32
            Console.WriteLine("Celsius To Fahrenheit Conversion:");
            Console.Write("Enter the Celsius : ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit : " + (c * (9 / 5) + 32));

            //Fahrenheit To Celsius Conversion c=(f-32)*(5/9)
            Console.WriteLine("Fahrenheit To Celsius Conversion:");
            Console.Write("Enter the Fahrenheit : ");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Celsius : " + (f - 32) * 5 / 9);

            Console.ReadKey();

        }
    }
}