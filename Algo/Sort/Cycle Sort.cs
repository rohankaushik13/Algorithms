using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Cycle_Sort
    {
        public Cycle_Sort()
        {
            int[] array = { 12, 34, 44, 10, 40, 75, 54, 23, 65, 45, 67 };
            Sort(array);
            Console.WriteLine(String.Join(",", array));
        }

        public void Sort(int[] array)
        {
            int len = array.Length;

            int item = array[0];

            for (int j = 0; j < len; j++)
            {
                int pos = 0;
                int i;
                for (i = 1; i < len; i++)
                {
                    if (array[i] < item)
                    {
                        pos++;
                    }
                }

                if (pos == 0)
                {
                    array[pos] = item;
                    item = array[1];
                    i = 0;
                }
                else
                {
                    int temp = array[pos];
                    array[pos] = item;
                    item = temp;
                    i=1;
                }
                Console.WriteLine(String.Join(",", array));

            }

        }
    }
}
