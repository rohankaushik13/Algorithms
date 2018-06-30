using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class CLL<T>
    {
        DLLNode<T> head;
        public void Run()
        {
            CLL<int> cll = new CLL<int>();
            cll.AddatPosition(1, 1);
            cll.AddatPosition(2, 2);
            cll.AddatPosition(3, 1);
            cll.AddatPosition(4, 2);
            cll.AddatPosition(5, 5);
            cll.AddatPosition(6, 6);
            cll.AddLast(7);
            cll.AddLast(8);
            cll.AddLast(9);
            cll.AddLast(10);
            cll.FrontTraverse();
            cll.RemoveatPosition(10);
            cll.FrontTraverse();
            cll.RemoveLast();
            cll.FrontTraverse();
            cll.RemoveatPosition(7);
            cll.FrontTraverse();
            cll.RemoveatPosition(1);
            cll.FrontTraverse();
            cll.BackTraverse();
        }

        public CLL()
        {
            head = new DLLNode<T>();
        }

        public T AddLast(T value)
        {
            DLLNode<T> node = new DLLNode<T>(value)
            {
                next = null,
                previous = null
            };

            DLLNode<T> current = new DLLNode<T>();
            if (head.previous != null)
            {
                current = head.previous;
                node.next = current.next;
                current.next.previous = node;
                current.next = node;
                node.previous = current;
            }
            else
            {
                current = head;
                node.next = current;
                current.next = node;
                node.previous = current;
                current.previous = node;
            }


            return node.value;
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
                if (iterator == head || iterator == null)
                    throw new Exception("Out of Range");
            }
            if (iterator.next == null)
            {
                node.next = iterator;
                iterator.next = node;
                iterator.previous = node;
                node.previous = iterator;
            }
            else
            {
                iterator.next.previous = node;
                node.next = iterator.next;
                node.previous = iterator;
                iterator.next = node;
            }
            return node.value;
        }

        public T RemoveLast()
        {
            DLLNode<T> iterator = head;
            T value = default(T);
            if (iterator.next != null && iterator.next.next != head)
            {
                value = iterator.previous.value;
                iterator.previous.previous.next = iterator;
                iterator.previous = iterator.previous.previous;
            }
            else if(iterator.next != null && iterator.next.next == head)
            {
                value = iterator.previous.value;
                iterator.next = null;
                iterator.previous = null;
            }
            else
            {
                Console.WriteLine("LL is Empty");
            }
            return value;
        }

        public T RemoveatPosition(int pos)
        {
            DLLNode<T> iterator = head;
            T value = default(T);
            int i = 1;
            for (i = 1; i < pos; i++)
            {
                iterator = iterator.next;
                if (iterator == head || iterator == null)
                {
                    throw new Exception("Out of Range");
                }
            }
            if (iterator.next != null && i>=1)
            {
                value = iterator.next.value;               
                iterator.next.next.previous = iterator;
                iterator.next = iterator.next.next;              
            }
            else if (iterator.next != null && iterator.next.next == head)
            {
                value = iterator.next.value;
                iterator.next = null;
                iterator.previous = null;
            }
            else
            {
                Console.WriteLine("LL is Empty");
            }
            return value;
        }

        public void FrontTraverse()
        {
            DLLNode<T> iterator = head.next;
            while (iterator != head && iterator != null)
            {
                Console.Write("{0}=>", iterator.value);
                iterator = iterator.next;
            }
            Console.WriteLine();
        }

        public void BackTraverse()
        {
            DLLNode<T> iterator = head.previous;
            while (iterator != head && iterator != null)
            {
                Console.Write("{0}<=", iterator.value);
                iterator = iterator.previous;
            }
            Console.WriteLine();
        }

    }
}
