using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Interpolation_Search
    {
        public Interpolation_Search()
        {
            Search();
        }

        private void Search()
        {
            int[] array = { 10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47 };
            int term =18;
            int lo = 0;
            int hi = array.Length -1;
            int pos = 0;
            bool found = false;

            while (lo <= hi && term >= array[lo] && term <= array[hi])
            {
                pos = Convert.ToInt32(lo + ((term - array[lo]) * (double)(hi - lo) / (array[hi] - array[lo])));
                if (array[pos] == term)
                {
                    found = true;
                    break;
                }
                else if (array[pos] < term)
                {
                    lo = pos + 1;
                }
                else if (array[pos] > term)
                {
                    hi = pos - 1;
                }
            }
            if(found)
            {
                Console.WriteLine("Term Found");
            }
            else
            {
                Console.WriteLine("Term not Found");
            }


        }
    }
}
