using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            int T;
            Console.Write("How Many Test case that you need to perfome :");
            T = int.Parse(Console.ReadLine());
            while (T > 0)
            {
                Console.Write("Please Enter the Number below 10000 : ");
                String number = Console.ReadLine();
                Queue<Char> queue = new Queue<char>();
                for (int i = 0; i < number.Length; i++)
                    queue.Enqueue(number[i]);
                String temp = "", ans = "", s = "", temp1 = "", temp2 = "", temp3 = "";
                while (queue.Count() > 0)
                {
                    s = "";
                    if (queue.Count() > 2)
                    {
                        temp = queue.Dequeue() + "";
                        switch (temp)
                        {
                            case "0":
                                s = "";
                                break;
                            case "1":
                                s = "One";
                                break;
                            case "2":
                                s = "Two";
                                break;
                            case "3":
                                s = "Three";
                                break;
                            case "4":
                                s = "Four";
                                break;
                            case "5":
                                s = "Five";
                                break;
                            case "6":
                                s = "Six";
                                break;
                            case "7":
                                s = "Seven";
                                break;
                            case "8":
                                s = "Eight";
                                break;
                            case "9":
                                s = "Nine";
                                break;
                        }
                        if (queue.Count() == 2 && (!s.Equals("")))
                        {
                            s += " Hundred ";
                        }
                        else if (queue.Count() == 3 && (!s.Equals("")))
                        {
                            s += " Thousand ";
                        }
                    }
                    else if (queue.Count() == 2)
                    {
                        temp1 = queue.Dequeue() + "";
                        switch (temp1)
                        {
                            case "0":
                                s = "";
                                break;
                            case "2":
                                s = "Twenty";
                                break;
                            case "3":
                                s = "Thirty";
                                break;
                            case "4":
                                s = "Forty";
                                break;
                            case "5":
                                s = "Fifty";
                                break;
                            case "6":
                                s = "Sixty";
                                break;
                            case "7":
                                s = "Seventy";
                                break;
                            case "8":
                                s = "Eighty";
                                break;
                            case "9":
                                s = "Ninety";
                                break;
                        }

                        temp2 = queue.Dequeue() + "";

                        switch (temp2)
                        {
                            case "0":
                                s += "";
                                break;
                            case "1":
                                s += " One";
                                break;
                            case "2":
                                s += " Two";
                                break;
                            case "3":
                                s += " Three";
                                break;
                            case "4":
                                s += " Four";
                                break;
                            case "5":
                                s += " Five";
                                break;
                            case "6":
                                s += " Six";
                                break;
                            case "7":
                                s += " Seven";
                                break;
                            case "8":
                                s += " Eight";
                                break;
                            case "9":
                                s += " Nine";
                                break;
                        }
                        temp3 = temp1 + "" + temp2;
                        switch (temp3)
                        {
                            case "10":
                                s = "Ten";
                                break;
                            case "11":
                                s = "Eleven";
                                break;
                            case "12":
                                s = "Twelve";
                                break;
                            case "13":
                                s = "Thirteen";
                                break;
                            case "14":
                                s = "Fourteen";
                                break;
                            case "15":
                                s = "Fifteen";
                                break;
                            case "16":
                                s = "Sixteen";
                                break;
                            case "17":
                                s = "Seventeen";
                                break;
                            case "18":
                                s = "Eighteen";
                                break;
                            case "19":
                                s = "Nineteen";
                                break;
                        }
                    }
                    else
                    {
                        temp2 = queue.Dequeue() + "";

                        switch (temp2)
                        {
                            case "0":
                                s += "Zero";
                                break;
                            case "1":
                                s += "One";
                                break;
                            case "2":
                                s += "Two";
                                break;
                            case "3":
                                s += "Three";
                                break;
                            case "4":
                                s += "Four";
                                break;
                            case "5":
                                s += "Five";
                                break;
                            case "6":
                                s += "Six";
                                break;
                            case "7":
                                s += "Seven";
                                break;
                            case "8":
                                s += "Eight";
                                break;
                            case "9":
                                s += "Nine";
                                break;
                        }
                    }
                    ans += s;
                }
                Console.WriteLine("Number To World :: " + ans);
                T--;
            }
            Console.Read();
        }
    }
}
