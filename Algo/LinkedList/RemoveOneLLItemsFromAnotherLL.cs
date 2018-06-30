using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class RemoveOneLLItemsFromAnotherLL
    {
        public void CreateLL()
        {
            SLL<int> sll1 = new SLL<int>();
            sll1.AddatPosition(7, 1);
            sll1.AddatPosition(6, 2);
            sll1.AddatPosition(9, 3);
            sll1.AddatPosition(8, 4);
            sll1.AddatPosition(4, 5);
            sll1.AddatPosition(10, 6);
            sll1.AddLast(1);
            sll1.AddLast(2);
            sll1.AddLast(3);
            sll1.AddLast(5);
            sll1.Traverse();

            SLL<int> sll2 = new SLL<int>();
            sll2.AddatPosition(1, 1);
            sll2.AddatPosition(3, 2);
            sll2.AddatPosition(5, 3);
            sll2.AddatPosition(7, 4);
            sll2.AddatPosition(10, 5);
            sll2.Traverse();

            Act(sll1, sll2);
            sll1.Traverse();
        }

        public void Act(SLL<int> sll1, SLL<int> sll2)
        {
            Node<int> iterator2 = sll2.head.next;

            while(iterator2 != null)
            {
                Node<int> iterator1 = sll1.head;
                while (iterator1?.next !=null)
                {
                    if(iterator1.next.value == iterator2.value)
                    {
                        iterator1.next = iterator1.next.next;
                    }
                    iterator1 = iterator1.next;
                }
                iterator2 = iterator2.next;
            }
        }
    }
}
