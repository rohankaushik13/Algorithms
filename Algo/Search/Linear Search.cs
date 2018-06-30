using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Linear_Search
    {
        public Linear_Search()
        {
            Search();
        }

        private void Search()
        {
            int term = 16;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]==term)
                {
                    Console.WriteLine("Term Found");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Term not found");
            }
        }
    }
}
