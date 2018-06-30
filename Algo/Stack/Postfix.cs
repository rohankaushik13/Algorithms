using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Postfix
    {
        public Postfix(string expression)
        {
            double result = Evaluate(expression);
            Console.WriteLine("Result: {0}", result);
        }

        public double Evaluate(string expression)
        {
            StackUsingArray<string> stack = new StackUsingArray<string>(expression.Length);
            foreach(char c in expression)
            {
                if (isOperand(c))
                {
                    stack.Push(c.ToString());
                }
                else
                {
                    int a = 0, b = 0;
                    if (!stack.IsArrayEmpty())
                    {
                        a = Convert.ToInt32(stack.Pop());
                    }
                    if (!stack.IsArrayEmpty())
                    {
                        b = Convert.ToInt32(stack.Pop());
                    }
                    int result = Calculate(a, b, c);
                    stack.Push(result.ToString());
                }
            }
            return Convert.ToDouble(stack.Pop());
        }

        public int Calculate(int a, int b, char c)
        {
            int result = default(int);
            switch (c)
            {
                case '+':
                    {
                        result = a + b;
                        break;
                    }
                case '-':
                    {
                        result = b - a;
                        break;
                    }
                case '/':
                    {
                        result = b / a;
                        break;
                    }
                case '*':
                    {
                        result = a * b;
                        break;
                    }
            }

            return result;
        }

        public bool isOperand(char c)
        {
            if (c >= '0' && c <= '9')
                return true;
            else
                return false;
        }
    }
}
