using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class Program
    {
        //isOperator() is check the given character is operator or not .
        public static Boolean isOperator(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '%' || ch == '^')
                return true;
            else
                return false;
        }

        //pr() is used to get priority.
        public static int pr(char ch)
        {
            switch (ch)
            {
                case '(':
                    return 0;

                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                case '%':
                    return 2;
                case '^':
                    return 3;
            }
            return 0;
        }
        public static String reverse(String s)
        {
            String temp = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '(')
                    temp += ')';
                else if (s[i] == ')')
                    temp += '(';
                else
                    temp += s[i];
            }
            return temp;
        }

        static void Main(string[] args)
        {
            String infix, postfix, prefix;

            //Convert Infix to Postfix String ...
            Console.WriteLine("Convert Infix to Postfix String ...");
            Console.Write("Enter the Infix String : ");
            infix = Console.ReadLine();
            infixToPostfix(ref infix, out postfix);
            Console.WriteLine("Postfix String : " + postfix);

            //Convert Infix to Prefix String ...
            Console.WriteLine("\nConvert Infix to Prefix String ...");
            Console.Write("Enter the Infix String : ");
            infix = Console.ReadLine();
            infixToPrefix(ref infix, out prefix);
            Console.WriteLine("Prefix String : " + prefix);

            Console.Read();
        }

        //Convert infix string into postfix string
        //ref and out is use for pass by reference.
        //ref means you may reference this variable.
        //out means you must initialize this variable.
        public static void infixToPostfix(ref String infix, out String postfix)
        {
            postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (isOperator(ch))
                {
                    if (stack.Count == 0)
                        stack.Push(ch);
                    else
                    {
                        if (pr(stack.Peek()) >= pr(ch))
                        {
                            postfix += stack.Pop();
                            i--;
                        }
                        else
                            stack.Push(ch);
                    }
                }
                else if (ch == ')')
                {
                    while (stack.Peek() != '(')
                        postfix += stack.Pop();
                    stack.Pop();
                }
                else
                    postfix += ch;
            }
            while (stack.Count != 0)
                postfix += stack.Pop();
        }

        //Convert infix String into prefix String .
        public static void infixToPrefix(ref String infix, out String prefix)
        {
            prefix = "";
            infix = reverse(infix);
            String postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (isOperator(ch))
                {
                    if (stack.Count == 0)
                        stack.Push(ch);
                    else
                    {
                        if (pr(stack.Peek()) >= pr(ch))
                        {
                            postfix += stack.Pop();
                            i--;
                        }
                        else
                            stack.Push(ch);
                    }
                }
                else if (ch == ')')
                {
                    while (stack.Peek() != '(')
                        postfix += stack.Pop();
                    stack.Pop();
                }
                else
                    postfix += ch;
            }
            while (stack.Count != 0)
                postfix += stack.Pop();
            prefix = reverse(postfix);
        }
    }
}
