using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class DLLNode<T>
    {
        public DLLNode<T> next;
        public DLLNode<T> previous;
        public T value;
        public DLLNode() { }
        public DLLNode(T value) => this.value = value;

    }

    class DLL<T>
    {
        DLLNode<T> head;
        DLLNode<T> current;
        public DLL()
        {
            head = new DLLNode<T>();
            current = head;
        }

        public void Run()
        {
            DLL<int> dll = new DLL<int>();
            dll.AddatPosition(1, 1);
            dll.AddatPosition(2, 2);
            dll.AddatPosition(3, 1);
            dll.AddatPosition(4, 2);
            dll.AddatPosition(5, 5);
            dll.AddatPosition(6, 6);
            dll.AddLast(7);
            dll.AddLast(8);
            dll.AddLast(9);
            dll.AddLast(10);
            dll.FrontTraverse();
            dll.RemoveatPosition(10);
            dll.FrontTraverse();
            dll.RemoveLast();
            dll.FrontTraverse();
            dll.RemoveatPosition(7);
            dll.FrontTraverse();
            dll.RemoveatPosition(1);
            dll.FrontTraverse();
            dll.BackTraverse();
        }

        public T AddLast(T value)
        {
            DLLNode<T> node = new DLLNode<T>(value)
            {
                next = null,
                previous = null
            };
            current.next = node;
            node.previous = current;
            current = node;

            return value;
        }

        public T AddatPosition(T value, int pos)
        {
            DLLNode<T> node = new DLLNode<T>(value)
            {
                next = null,
                previous = null
            };

            DLLNode<T> iterator = head;
            for (int i = 1; i < pos; i++)
            {
                iterator = iterator.next;
                if (iterator == null)
                    throw new Exception("Out of Range");
            }
            if (iterator.next == null)
            {
                current = node;
            }
            else
            {
                iterator.next.previous = node;
            }
            node.next = iterator.next;
            node.previous = iterator;
            iterator.next = node;

            return value;
        }

        public T RemoveatPosition(int pos)
        {
            DLLNode<T> iterator = head;
            T value = default(T);
            for (int i = 1; i < pos; i++)
            {
                iterator = iterator.next;
                if (iterator == null)
                {
                    throw new Exception("Out of Range");
                }
            }
            if(iterator.next != null)
            {
                value = iterator.next.value;
                if (iterator.next.next != null)
                {
                    iterator.next.next.previous = iterator;
                    iterator.next = iterator.next.next;
                }
                else
                {
                    iterator.next = null;
                }
            }
            if (iterator.next == null)
                current = iterator;
            return value;
        }

        public T RemoveLast()
        {
            DLLNode<T> iterator = current;
            iterator.previous.next = null;
            current = iterator.previous;
            return iterator.value;
        }

        public void FrontTraverse()
        {
            DLLNode<T> iterator = head;
            while (iterator != null)
            {
                Console.Write("{0}=>", iterator.value);
                iterator = iterator.next;
            }
            Console.WriteLine();
        }

        public void BackTraverse()
        {
            DLLNode<T> iterator = current;
            while (iterator.previous != null)
            {
                Console.Write("{0}<=", iterator.value);
                iterator = iterator.previous;
            }
            Console.WriteLine();
        }
    }
}
