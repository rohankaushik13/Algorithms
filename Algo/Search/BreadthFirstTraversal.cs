using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Search
{
    class BreadthFirstTraversal<T>
    {
        int size;
        List<T>[] grph;
        public void CreateGraph(int size)
        {
            this.size = size;
            grph = new List<T>[size];
        }

        public void Traverse()
        {

        }
    }
}
