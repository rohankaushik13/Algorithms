using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Node<T>
    {
        public Node<T> next;
        public T value;
        public Node() { }
        public Node(T value) => this.value = value;
    }
    class SLL<T>
    {
        public Node<T> head;
        public Node<T> current;

        public SLL()
        {
            head = new Node<T>();
            current = head;
        }

        public void Run()
        {
            SLL<int> sll = new SLL<int>();
            sll.AddatPosition(1, 1);
            sll.AddatPosition(2, 2);
            sll.AddatPosition(3, 1);
            sll.AddatPosition(4, 2);
            sll.AddatPosition(5, 5);
            sll.AddatPosition(6, 6);
            sll.AddLast(7);
            sll.AddLast(8);
            sll.AddLast(9);
            sll.AddLast(10);
            sll.Traverse();
            sll.RemoveLast();
            sll.Traverse();
            sll.RemoveatPosition(7);
            sll.Traverse();
            sll.RemoveatPosition(1);
            sll.Traverse();
            sll.ReverseTraverse(sll.head);
        }

        public T AddLast(T value)
        {
            Node<T> node = new Node<T>(value)
            {
                next = null
            };
            current.next = node;
            current = node;

            return node.value;
        }

        public T AddatPosition(T value, int pos)
        {
            Node<T> iterator = head;
            Node<T> node = new Node<T>(value);
            if (pos == 1)
            {
                node.next = iterator.next;
            }
            else
            {
                for (int i = 1; i < pos; i++)
                {
                    iterator = iterator.next;

                    if (iterator == null)
                    {
                        throw new Exception("Out of Range");
                    }
                }

                node.next = iterator.next;

            }

            if (iterator.next == null)
            {
                current = node;
            }

            iterator.next = node;
            return node.value;

        }

        public T RemoveatPosition(int pos)
        {
            Node<T> iterator = head;
            T value = default(T);
            for (int i = 1; i < pos; i++)
            {
                iterator = iterator.next;
                if (iterator == null)
                    throw new Exception("Out of Range");
            }
            if (iterator.next != null)
            {
                value = iterator.next.value;
                iterator.next = iterator.next.next;
            }
            if (iterator.next == null)
                current = iterator;
            return value;
        }

        public T RemoveLast()
        {
            T value = default(T);
            if (head.next != null)
            {
                Node<T> iterator = head;
                while (iterator.next != current)
                {
                    iterator = iterator.next;
                }

                value = iterator.next.value;
                iterator.next = null;
                current = iterator;
            }
            else
            {
                Console.WriteLine("LL empty");
                
            }
            return value;
        }

        public void Traverse()
        {
            Node<T> iterator = head;
            while (iterator != null)
            {
                Console.Write("{0}=>", iterator.value);
                iterator = iterator.next;
            }
            Console.WriteLine();
        }

        public void ReverseTraverse(Node<T> iterator)
        {
            if (iterator.next != null)
            {
                ReverseTraverse(iterator.next);
            }
            Console.Write("{0}<=", iterator.value);
            if (iterator == head)
                Console.WriteLine();
        }
    }
}
