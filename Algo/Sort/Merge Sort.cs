using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Merge_Sort
    {
        public Merge_Sort()
        {
            int[] array = { 12, 34, 44, 10, 40, 75, 54, 23, 65, 45, 67 };
            Console.WriteLine(String.Join(",", array));
            int low = 0;
            int high = array.Length - 1;
            Sort(array, low, high);
            Console.WriteLine(String.Join(",", array));
        }

        private void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;

                Console.WriteLine("{0},{1},{2}", low, mid, high);

                Sort(array, low, mid);
                Sort(array, mid + 1, high);

                Merge(array, low, mid, high);
            }
        }

        private void Merge(int[] array, int low, int mid, int high)
        {
            int len1 = mid - low + 1;
            int len2 = high - mid;
            int i = 0, j = 0, k = low;
            int[] a = new int[len1];
            int[] b = new int[len2];
            for (int x = 0; x < len1; x++)
            {
                a[x] = array[low + x];
            }

            for (int z = 0; z < len2; z++)
            {
                b[z] = array[mid + 1 + z];
            }

            while (i < len1 && j < len2)
            {
                if (a[i] <= b[j])
                {
                    array[k] = a[i];
                    i++;
                }
                else
                {
                    array[k] = b[j];
                    j++;
                }
                k++;
            }

            while (i < len1)
            {
                array[k] = a[i];
                k++;
                i++;
            }

            while (j < len2)
            {
                array[k] = b[j];
                k++;
                j++;
            }
            Console.WriteLine(String.Join(",", array));
        }
    }
}
