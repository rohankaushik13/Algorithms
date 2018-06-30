using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Exponential_Search
    {
        public Exponential_Search()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 23, 24, 25, 26, 27, 28, 29, 30 };
            int term = 1;
            int jump = 3;
            int found = -1;
            found = Search(array, term, jump, 0);
            if (found != -1)
            {
                Console.WriteLine("Found at {0}",found);
            }
            else
            {
                Console.WriteLine("Term Not Found");
            }
        }

        public int Search(int[] array, int term, int hi, int lo)
        {
            if (hi < array.Length)
            {
                if (term <= array[hi - 1])
                {
                    return BinarySearch(array, hi - 1, lo, term);
                }
                else
                {
                    hi = hi * 2;
                    lo = hi;
                    return Search(array, term, hi, lo);
                }
            }
            
            return -1;

        }

        public int BinarySearch(int[] array, int hi, int lo, int term)
        {
            if (lo <= hi)
            {
                int mid = (hi + lo) / 2;
                if (term == array[mid])
                {
                    return mid;
                }
                else if (term > array[mid])
                {
                    lo = mid + 1;
                    return BinarySearch(array, hi, lo, term);
                }
                else if (term < array[mid])
                {
                    hi = mid - 1;
                    return BinarySearch(array, hi, lo, term);
                }
            }
            return -1;
        }

    }
}
