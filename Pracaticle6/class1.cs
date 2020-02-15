using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracaticle6
{
    class class1
    {
        public void InfixToPostfix(String infix, String postfix)
        {
            postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();
            for(int i=0; i < infix.Length; i++)
            {
                ch = infix[i];
                if(isOperator(ch))
                {
                    if(stack.Count == 0)
                    {
                        stack.Push(ch);

                    }
                    else
                    {
                        if(ch== '(')
                        {

                        }
                    }
                }
                else
                {
                    postfix += ch;
                }
            }
        }
        public Boolean isOperator(char ch)
        {
            if(ch=='(' || ch=='+' || ch=='-' || ch == '*' || ch == '/' || ch == '^' || ch == ')')
            {
                return true ;
            }
            return false;
        }
        public int priority(char ch)
        {
            switch(ch)
            {
                case '(':
                    return 0;
                    break;
                case '+':
                case '-':
                    return 1;
                    break;
                case '*':
                case '/':
                case '^':
                    return 2;
                    break;
                case ')':
                    return 3;
                    break;

            }
        }
    }
}
