using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class NodewithRanodm<T>
    {
        public NodewithRanodm<T> next;
        public NodewithRanodm<T> random;
        public T data;

        public NodewithRanodm()
        {
            this.data = default(T);
            this.next = null;
            this.random = null;
        }
    }

    public class SLLwithRandom<T>
    {
        public NodewithRanodm<T> head;
        public NodewithRanodm<T> current;
        public SLLwithRandom()
        {
            head = new NodewithRanodm<T>();
            current = head;
        }

        public T AddNode(T value)
        {
            NodewithRanodm<T> node = new NodewithRanodm<T>();
            node.data = value;

            current.next = node;
            current = node;

            return value;
        }

        public T SetRandom(NodewithRanodm<T> source, T targetValue)
        {
            NodewithRanodm<T> node = head;
            while(!node.data.Equals(targetValue))
            {
                node = node.next;
            }
            source.random = node;
            return targetValue;
        }

        public SLLwithRandom<int> Create()
        {
            SLLwithRandom<int> sll = new SLLwithRandom<int>();
            sll.AddNode(1);
            sll.AddNode(2);
            sll.AddNode(3);
            sll.AddNode(4);
            sll.AddNode(5);
            sll.AddNode(6);
            sll.AddNode(7);
            sll.AddNode(8);
            sll.AddNode(9);

            NodewithRanodm<int> iterator = sll.head.next;
            RandomWrapper rw = new RandomWrapper();
            int max = 9;
            while (iterator != null)
            {
                int ran = rw.Random(1, max--);
                Console.WriteLine("<=========== Ignore above this ==========>");
                sll.SetRandom(iterator, ran);
                iterator = iterator.next;
                if(max ==0)
                {
                    max = 9;
                }
            }
            return sll;
        }

        public void Traverse(NodewithRanodm<T> head)
        {
            NodewithRanodm<T> node = head;
            while(node != null)
            {
                Console.Write("({0},{1})=>", node.data, (node.random != null? node.random.data: default(T)) );
                node = node.next;
            }
            Console.WriteLine();
        }
    }



    public class CopyLLWithRandomNode
    {
        public CopyLLWithRandomNode()
        {
            SLLwithRandom<int> sll1 = new SLLwithRandom<int>();
            sll1 = sll1.Create();
            sll1.Traverse(sll1.head);

            SLLwithRandom<int> sll2 = CopyLL(sll1);
            sll2.Traverse(sll2.head);

            NodewithRanodm<int> sll2Head= SetRandom(sll1, sll2);
            sll2.Traverse(sll2Head);
        }

        public NodewithRanodm<int> SetRandom(SLLwithRandom<int> sll1, SLLwithRandom<int> sll2)
        {
            NodewithRanodm<int> nodeSLL1 = sll1.head.next;
            NodewithRanodm<int> nodeSLL2 = sll2.head.next;
            while (nodeSLL1 != null)
            {
                if(nodeSLL1.random != null)
                {
                    NodewithRanodm<int> random = nodeSLL1.random;
                    NodewithRanodm<int> iteratorSLL1 = sll1.head.next;
                    int positionofRandom = 0;
                    while(iteratorSLL1 != random)
                    {
                        positionofRandom++;
                        iteratorSLL1 = iteratorSLL1.next;
                    }

                    int positionofRandominSLL2 = 0;
                    NodewithRanodm<int> iteratorSLL2 = sll2.head.next;
                    while(positionofRandominSLL2 != positionofRandom)
                    {
                        iteratorSLL2 = iteratorSLL2.next;
                        positionofRandominSLL2 ++;
                    }

                    nodeSLL2.random = iteratorSLL2;
                }
                nodeSLL1 = nodeSLL1.next;
                nodeSLL2 = nodeSLL2.next;
            }

            return sll2.head;
        }

        public SLLwithRandom<int> CopyLL(SLLwithRandom<int> sll1)
        {
            SLLwithRandom<int> sll2 = new SLLwithRandom<int>();
            NodewithRanodm<int> iterator = sll1.head.next;
            while(iterator !=null)
            {
                NodewithRanodm<int> node = new NodewithRanodm<int>();
                node.data = iterator.data;
                sll2.current.next = node;
                sll2.current = node;

                iterator = iterator.next;
            }

            return sll2;
        }
    }
}
