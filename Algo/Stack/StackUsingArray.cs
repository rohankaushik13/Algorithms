using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class StackUsingArray<T>
    {
        T[] Stack;
        int size;
        int position;

        public StackUsingArray()
        { }
        public StackUsingArray(int size)
        {
            this.size = size;
            Stack = new T[size];
            position = -1;
        }

        public void Run()
        {
            StackUsingArray<int> s = new StackUsingArray<int>(5);
            s.Pop();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);
            s.Pop();
            s.Push(6);
            s.Traverse();
        }

        public T Push(T value)
        {
            T v = default(T);
            if (!IsArrayFull())
            {
                position++;
                Stack[position] = value;
                v = value;
            }
            else
            {
                Console.WriteLine("Stack Full. Cannot Insert");
            }
            return v;
        }

        public T Pop()
        {
            T v = default(T);
            if (!IsArrayEmpty())
            {
                v = Stack[position];
                Stack[position] = default(T);
                position--;

            }
            else
            {
                Console.WriteLine("Stack Empty. Cannot Delete");
            }
            return v;
        }

        public bool IsArrayEmpty()
        {
            if (position == -1)
            {
                return true;
            }
            return false;
        }

        public bool IsArrayFull()
        {
            if (position == size - 1)
            {
                return true;
            }
            return false;
        }

        public void Traverse()
        {
            int i = size-1;
            while (i >= 0)
            {
                Console.Write("{0}<=", Stack[i]);
                i--;
            }
            Console.WriteLine();
        }
    }
}
