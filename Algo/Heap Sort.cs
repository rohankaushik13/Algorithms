using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Heap_Sort
    {
        public Heap_Sort()
        {
            int[] array = { 12, 34, 44, 10, 40, 75, 54, 23, 65, 45, 67 };
            Sort(array);
            Console.WriteLine(String.Join(",", array));
        }

        private void Sort(int[] array)
        {
            int x = 0;
            int m = 0;
            int z = array.Length-1;
            while (z > 0)
            {
                x = z;
                while (x > 0)
                {
                    if (x % 2 == 0)
                    {
                        m = (x - 2) / 2;
                    }
                    else
                    {
                        m = (x - 1) / 2;
                    }
                    if (m >= 0)
                    {
                        if (array[x] > array[m])
                        {
                            int temp = array[x];
                            array[x] = array[m];
                            array[m] = temp;
                        }
                    }
                    x--;
                }

                int temp2 = array[z];
                array[z] = array[0];
                array[0] = temp2;
                z--;
            }

        }
    }
}
