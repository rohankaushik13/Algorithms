using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class MergeTwoSortedLL
    {
        public MergeTwoSortedLL()
        {
            SLL<int> sll1 = new SLL<int>();
            sll1.AddLast(1);
            sll1.AddLast(3);
            sll1.AddLast(5);
            sll1.AddLast(7);
            sll1.AddLast(9);

            SLL<int> sll2 = new SLL<int>();
            sll2.AddLast(2);
            sll2.AddLast(4);
            sll2.AddLast(6);
            sll2.AddLast(8);
            sll2.AddLast(10);

            // Method One
            SLL<int> sll3 = MergeUsingTempLL(sll1, sll2);
            sll3.Traverse();

            // Method Two
            sll3 = new SLL<int>();
            sll3.head = MergeUsingNode(sll1, sll2);
            sll3.Traverse();
        }

      
        private SLL<int> MergeUsingTempLL(SLL<int> sll1, SLL<int> sll2)
        {
            SLL<int> sll3 = new SLL<int>();
            Node<int> sll1Iterator = sll1.head.next;
            Node<int> sll2Iterator = sll2.head.next;
            while (sll1Iterator != null || sll2Iterator != null)
            {
                if (sll1Iterator?.value < sll2Iterator?.value)
                {
                    sll3.AddLast(sll1Iterator.value);
                    sll1Iterator = sll1Iterator.next;
                }
                else
                {
                    sll3.AddLast(sll2Iterator.value);
                    sll2Iterator = sll2Iterator.next;
                }
            }
            return sll3;
        }

        private Node<int> MergeUsingNode(SLL<int> sll1, SLL<int> sll2)
        {
            Node<int> sll1Iterator = sll1.head.next;
            Node<int> sll2Iterator = sll2.head.next;
            Node<int> finalIterator = new Node<int>();
            Node<int> result = finalIterator;
            while (sll1Iterator != null || sll2Iterator != null)
            {
                if (sll1Iterator?.value < sll2Iterator?.value)
                {
                    finalIterator.next = sll1Iterator;
                    finalIterator = finalIterator.next;
                    sll1Iterator = sll1Iterator.next;
                }
                else
                {
                    finalIterator.next = sll2Iterator;
                    finalIterator = finalIterator.next;
                    sll2Iterator = sll2Iterator.next;
                }
            }
            
            return result;
        }
    }
}
