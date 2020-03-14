using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Currency in Rupee : ");
            double inrCurrency = int.Parse(Console.ReadLine());
            Console.WriteLine("Rupee To Dollar : " + inrCurrency / 70.1);
            Console.WriteLine("Rupee To Frank : " + inrCurrency / 73.28);
            Console.WriteLine("Rupee To Euro : " + inrCurrency / 77.73);
            Console.ReadKey();
        }
    }
}
