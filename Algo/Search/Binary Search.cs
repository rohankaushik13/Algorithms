using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Binary_Search
    {
        public Binary_Search()
        {
            int term = 5;
            int[] array = { 1,2,3,4,5,6,7,8,9,10 };
            int length = array.Length;
            int midlen = length / 2;
            bool found = false;
            Search(midlen, array, term, length, found);
        }

        private void Search(int midlen, int[] array, int term, int length, bool found)
        {
            if (length - midlen != 1)
            {
                if (term == array[midlen])
                {
                    Console.WriteLine("Term Found");
                }
                else if (term < array[midlen])
                {
                    length = midlen;
                    midlen = midlen / 2;
                    Search(midlen, array, term, length, found);
                }
                else if (term > array[midlen])
                {
                    midlen = (length + midlen) / 2;
                    Search(midlen, array, term, length, found);
                }
            }
            else
            {
                Console.WriteLine("Term Not Found");
            }
                
        }
    }
}
