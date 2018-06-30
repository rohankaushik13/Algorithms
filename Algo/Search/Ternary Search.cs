using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Ternary_Search
    {
        public Ternary_Search()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int term = 23;
            int start = 0;
            bool found = Search(array,term,start,array.Length-1);
            if (found)
            {
                Console.WriteLine("Term Found");
            }
            else
            {
                Console.WriteLine("Term Not Found");
            }
        }

        public bool Search(int[] array, int term, int start, int end)
        {
            if (array[start] <= term && array[end] >= term)
            {
                int mid1 = start + (end - start) / 3;
                int mid2 = mid1 + (end - start) / 3;
               // int mid1 = (start + end) / 3;
                //int mid2 = (start + end) * 2 / 3;
                if (array[mid1] == term)
                    return true;
                if (array[mid2] == term)
                    return true;
                if (array[mid1] < term)
                {
                    start = mid1 + 1;
                }
                if(array[mid2]<term)
                {
                    start = mid2 + 1;
                }
                if (array[mid2] > term)
                {
                    end = mid2 - 1;
                }
                if (array[mid1] > term)
                {
                    end = mid1 - 1;                   
                }
                return Search(array, term, start, end);

            }
            return false;
        }
    }

}
