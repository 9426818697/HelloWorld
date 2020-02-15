using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracaticle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern 1");
            pattern1();
            Console.WriteLine("Pattern 2");
            pattern2();
            Console.WriteLine("Pattern 3");
            pattern3();
            Console.Read();
        }
        static void pattern1()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void pattern2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void pattern3()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write("+");
                Console.WriteLine(); 
            }
        }
    }
}
