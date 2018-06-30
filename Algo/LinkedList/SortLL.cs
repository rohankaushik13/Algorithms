using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class SortLL<T>
    {
        public SLL<int> CreateLL()
        {
            SLL<int> sll = new SLL<int>();
            sll.AddatPosition(7, 1);
            sll.AddatPosition(6, 2);
            sll.AddatPosition(9, 3);
            sll.AddatPosition(8, 4);
            sll.AddatPosition(4, 5);
            sll.AddatPosition(10, 6);
            sll.AddLast(1);
            sll.AddLast(2);
            sll.AddLast(3);
            sll.AddLast(5);
            sll.Traverse();
            Sort(sll);
            sll.Traverse();
            return sll;
        }

        public void Sort(SLL<int> sll)
        {
            Node<int> iterator1 = sll.head;
            while (iterator1.next.next != null)
            {
                Node<int> iterator2 = sll.head;
                while (iterator2.next.next != null)
                {
                    if (iterator2.next.value > iterator2.next.next.value)
                    {
                        int temp = iterator2.next.value;
                        iterator2.next.value = iterator2.next.next.value;
                        iterator2.next.next.value = temp;
                    }
                    iterator2 = iterator2.next;
                    sll.Traverse();
                }
                sll.Traverse();
                iterator1 = iterator1.next;
            }
        }
    }
}
