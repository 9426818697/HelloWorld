using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Pracaticle4
{
    class Program
    {
        static void Main(string[] args)
        {


            string name;
            string Country;
            do
            {
                Console.WriteLine("Please Enter Your name");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name, "^[a-z A-Z]+$"));
            do
            {
                Console.WriteLine("Where are you from");
                Country = Console.ReadLine();
            } while (!Regex.IsMatch(Country, "^[a-z A-Z]+$"));
            Console.WriteLine("my name is " + name + ".I from " + Country);
            Console.Read();


        }
    }
}
