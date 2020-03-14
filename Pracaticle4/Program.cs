using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, c;
            Console.WriteLine("Number Conversions Program");
            while (true)
            {
                Console.WriteLine("1. Binary To Decimal Converter");
                Console.WriteLine("2. Decimal To Binary Converter");
                Console.WriteLine("3. Decimal To Octal Converter");
                Console.WriteLine("4. Decimal To Hexadecimal Converter");
                Console.WriteLine("5. Exit Program");
                Console.Write("Enter the your choice To Converte Number: ");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Binary To Decimal");
                        Console.Write("Enter the Number :");
                        number = int.Parse(Console.ReadLine());
                        BinaryToDecimal(number);
                        break;


                    case 2:
                        Console.WriteLine("Decimal To Binary");
                        Console.Write("Enter the Number :");
                        number = int.Parse(Console.ReadLine());
                        DecimalToBinary(number);
                        break;


                    case 3:
                        Console.WriteLine("Decimal To Octal");
                        Console.Write("Enter the Number :");
                        number = int.Parse(Console.ReadLine());
                        DecimalToOct(number);
                        break;

                    case 4:
                        Console.WriteLine("Decimal To Hexadecimal");
                        Console.Write("Enter the Number :");
                        number = int.Parse(Console.ReadLine());
                        DecimalToHex(number);
                        break;
                }
                if (c == 5)
                    break;
                Console.WriteLine();
            }
            Console.Read();
        }
        public static void BinaryToDecimal(int n)
        {
            int sum = 0, a, p = 1;
            while (n > 0)
            {
                a = n % 10;
                sum = sum + (a * p);
                p = p*2;
                n = n/10;
            }
            Console.WriteLine("Binary To Decimal : " + sum);
        }
        public static void DecimalToBinary(int n)
        {
            int[] sum = new int[10];
            int a, i = 0;
            while (n > 0)
            {
                a = n % 2;
                sum[i++] = a;
                n = n/2;
            }
            Console.Write("Decimal To Binary : ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(sum[j]);
        }
        public static void DecimalToOct(int n)
        {
            int a, i = 0;
            int[] sum = new int[10];
            while (n > 0)
            {
                a = n % 8;
                sum[i++] = a;
                n = n/8;
            }
            Console.Write("Decimal To Octal : ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(sum[j]);
        }
        public static void DecimalToHex(int n)
        {
            int a, i = 0;
            char[] sum = new char[50];


            while (n > 0)
            {
                int temp = 0;
                temp = n % 16;
                if (temp > 9)
                {
                    sum[i] = (char)(temp + 55);

                }
                else
                {
                    sum[i] = (char)(temp + 48);

                }
                i++;
                n = n / 16;
            }


            Console.Write("Decimal to Hexadecimal : ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(sum[j]);
        }
    }
}
