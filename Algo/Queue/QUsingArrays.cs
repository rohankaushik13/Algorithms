using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class QUsingArrays<T>
    {
        T[] Que;
        int startpos;
        int endpos;
        int size;
        bool start;

        public QUsingArrays() { }
        public QUsingArrays(int size)
        {
            this.size = size;
            Que = new T[size];
            startpos = 0;
            endpos = 0;
            start = true;
        }

        public void Run()
        {
            QUsingArrays<int> q = new QUsingArrays<int>(5);
            q.Dequeue();
            q.Enqueue(1);
            q.Traverse();
            q.Enqueue(2);
            q.Traverse();
            q.Enqueue(3);
            q.Traverse();
            q.Dequeue();
            q.Traverse();
            q.Dequeue();
            q.Traverse();
            q.Enqueue(4);
            q.Traverse();
            q.Enqueue(5);
            q.Traverse();
            q.Enqueue(6);
            q.Traverse();
            q.Enqueue(7);
            q.Traverse();
            q.Enqueue(8);
            q.Traverse();
        }

        public T Enqueue(T value)
        {
            T v = default(T);
            bool available = ISArraySpaceAvailable();

            if (available)
            {
                v = value;
                if (startpos == endpos && start== true)
                {
                    Que[endpos] = v;
                    start = false;
                }
                else
                {
                    if (size - endpos == 1)
                    {
                        endpos = ResetPos();
                    }
                    else
                    {
                        endpos++;
                    }
                    Que[endpos] = v;
                }
            }
            else
            {
                Console.WriteLine("Queue Full. Please Dequeue");
            }
            return v;
        }

        public T Dequeue()
        {
            T v = default(T);
            bool empty = ISArrayEmpty();
            if (empty && start == false)
            {
                startpos = ResetPos();
                endpos = ResetPos();
                start = true;
            }
            else if (!empty)
            {
                v = Que[startpos];
                if (startpos == size - 1)
                {
                    startpos = ResetPos();
                }
                else
                {
                    startpos++;
                }
            }
            else
            { 
                Console.WriteLine("Queue Empty. Please Enqueue");
            }
            return v;
        }

        public int ResetPos()
        {
            return 0;
        }

        public bool ISArraySpaceAvailable()
        {
            if (startpos < endpos && endpos - startpos + 1 == size)
            {
                return false;
            }
            else if (endpos < startpos && startpos - endpos == 1)
            {
                return false;
            }

            return true;
        }

        public bool ISArrayEmpty()
        {
            if (startpos != endpos)
            {
                return false;
            }
            return true;
        }

        public void Traverse()
        {
            if (startpos > endpos)
            {
                for (int i = startpos; i < size; i++)
                {
                    Console.Write("{0}<=", Que[i]);
                }
                for (int i = 0; i <= endpos; i++)
                {
                    Console.Write("{0}<=", Que[i]);
                }
            }
            else
            {
                for (int i = startpos; i <= endpos; i++)
                {
                    Console.Write("{0}<=", Que[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
