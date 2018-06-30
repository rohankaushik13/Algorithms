using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class ReverseLL
    {
        SLL<int> sll;
        public ReverseLL()
        {

            SLL<int> sll = CreateLL();
            sll = Reverse(sll);
            sll.Traverse();
        }
        public SLL<int> CreateLL()
        {
            sll = new SLL<int>();
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
            return sll;
        }

        public SLL<int> Reverse(SLL<int> sll)
        {
            Node<int> iterator = sll.head.next;
            SLL<int> rll = new SLL<int>();
            Node<int> previousNode = null ;
            Node<int> currentNode = iterator;

            while(currentNode != null)
            {
                Node<int> temp = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = temp;
            }
            rll.head = previousNode;
            return rll;
        }
    }
}
