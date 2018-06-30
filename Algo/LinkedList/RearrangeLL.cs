using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class RearrangeLL
    {
        public RearrangeLL()
        {
            SLL<int> sll = new SLL<int>();
            sll.AddLast(1);
            sll.AddLast(3);
            sll.AddLast(5);
            sll.AddLast(7);
            sll.AddLast(9);
            sll.AddLast(2);
            sll.AddLast(4);
            sll.AddLast(6);
            sll.AddLast(8);
            sll.AddLast(10);
            sll.Traverse();

            Rearrange(sll);
            sll.Traverse();
        }

        public void Rearrange(SLL<int> sll)
        {
            if (sll.head != null)
            {
                Node<int> iterator = sll.head.next;
                Node<int> runner = sll.head.next;
                while (runner != null)
                {
                    iterator = iterator.next;
                    runner = runner.next.next;
                }

                runner = sll.head.next;
                while (iterator != null)
                {
                    Node<int> a = iterator.next;
                    Node<int> b = runner.next;
                    runner.next = iterator;
                    if(iterator.next != null)
                    iterator.next = b;

                    iterator = a;
                    runner = runner.next.next;
                }
            }
        }
    }
}
