using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class StackUsingLL
    {
        SLL<int> stack;
        public StackUsingLL()
        {
            stack = new SLL<int>();
            push(9);
            push(8);
            push(7);
            push(6);
            push(5);
            push(4);
            push(3);
            push(2);
            push(1);
            Traverse();

            pop();
            Traverse();
            pop();
            Traverse();
            pop();
            Traverse();
        }

        public StackUsingLL(int n)
        {
            stack = new SLL<int>();
        }

        public int push(int value)
        {
            return stack.AddLast(value);
        }

        public int pop()
        {
            return stack.RemoveLast();
        }

        public void Traverse()
        {
            stack.ReverseTraverse(stack.head);
        }

        public bool isEmpty()
        {
            if (stack.head.next == null)
                return true;
            else
                return false;
        }
    }
}
