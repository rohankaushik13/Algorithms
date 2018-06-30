using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class QUsingStack
    {
        StackUsingLL stack1;
        StackUsingLL stack2;

        public QUsingStack()
        {
            stack1 = new StackUsingLL(0);
            stack2 = new StackUsingLL(0);

            Enqueue(1);
            Enqueue(2);
            Enqueue(3);
            Enqueue(4);
            Enqueue(5);
            Enqueue(6);
            Enqueue(7);
            Enqueue(8);
            Traverse();
            Dequeue();
            Dequeue();
            Dequeue();
            Enqueue(9);
            Dequeue();
            Traverse();
        }

        public int Enqueue(int value)
        {
            while (!stack2.isEmpty())
            {
                int val = stack2.pop();
                stack1.push(val);
            }
            return stack1.push(value);
        }

        public int Dequeue()
        {
            while (!stack1.isEmpty())
            {
                int value = stack1.pop();
                stack2.push(value);
            }


            return stack2.pop();
        }

        public void Traverse()
        {
            while (!stack1.isEmpty())
            {
                int value = stack1.pop();
                stack2.push(value);
            }

            stack2.Traverse();
        }
    }
}
