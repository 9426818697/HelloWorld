using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracaticle3
{
    public class Class1
    {
        static void Main(string[] args)
        {
            string name;
            string Country;
            Console.WriteLine("Please Enter Your name");
            name = Console.ReadLine();
            Console.WriteLine("Where are you from");
            Country = Console.ReadLine();
            Console.WriteLine("my name is " + name + ".I from" + Country);
            Console.Read();

        }
    }
}
