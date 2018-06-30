using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class QUsingLL
    {
        SLL<int> queue;
        public QUsingLL()
        {
            queue = new SLL<int>();
            Enqueue(9);
            Enqueue(8);
            Enqueue(7);
            Enqueue(6);
            Enqueue(5);
            Enqueue(4);
            Enqueue(3);
            Enqueue(2);
            Enqueue(1);
            Traverse();

            Dequeue();
            Traverse();
            Dequeue();
            Traverse();
            Dequeue();
            Traverse();
        }

        public int Enqueue(int value)
        {
            return queue.AddLast(value);
        }

        public int Dequeue()
        {
            return queue.RemoveatPosition(1);
        }

        public void Traverse()
        {
            queue.Traverse();
        }
    }
}
