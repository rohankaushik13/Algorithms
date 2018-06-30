using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Selection_Sort
    {
        public Selection_Sort()
        {
            Sort();
        }

        public void Sort()
        {
            int[] array = { 12, 34, 44, 10, 40, 75, 54, 23, 65, 45, 67 };
            int len = array.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int minval = i;
                for (int j = i; j < len; j++)
                {
                    if (array[j] < array[minval])
                    {
                        minval = j;
                    }
                }
                if (minval != i)
                {
                    int temp = array[minval];
                    array[minval] = array[i];
                    array[i] = temp;
                }
            }

            Console.WriteLine(String.Join(",", array));
        }
    }
}