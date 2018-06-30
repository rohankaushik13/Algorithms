using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Shell_Sort
    {
        public Shell_Sort()
        {
            int[] array = { 62, 83, 18, 53, 7, 17, 95, 86, 47, 69, 25, 28 };
            Sort(array);
            //OptimizedSort(array);
            Console.WriteLine(String.Join(",", array));
        }


        private void Sort(int[] array)
        {
            int len = array.Length;
            int gap = len;
            do
            {
                gap = gap / 2;
                for (int j = 0; j < gap; j++)
                {
                    for (int i = j; i < len; i += gap)
                    {
                        int value = array[i];
                        int k = i - gap;
                        for (k = i - gap; k >= 0 && array[k] > value; k -= gap)
                        {
                            array[k + gap] = array[k];
                        }
                        array[k + gap] = value;
                    }
                }
            } while (gap > 1);
        }

        private void OptimizedSort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap = gap / 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }
    }
}
