using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Quick_Sort
    {
        public Quick_Sort()
        {
            int[] array = { 12, 34, 44, 10, 40, 75, 54, 23, 65, 45, 67 };
            int low = 0;
            int high = array.Length - 1;
            Sort(array, low, high);
            Console.WriteLine(String.Join(",", array));
            array = new int[] { 12, 34, 44, 10, 40, 75, 54, 23, 65, 45, 67 };
            quickSort(array, low, high);
            Console.WriteLine(String.Join(",", array));
        }

        public void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                Sort(array, low, pi - 1);
                Sort(array, pi + 1, high);
            }
        }

        public int Partition(int[] array, int low, int high)
        {
            int pi = array[high];
            int i = low;
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pi)
                {
                    swap(ref array[i], ref array[j]);
                    i++;
                }
            }
            swap(ref array[i], ref array[high]);
            return i;
        }

        public void swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }

        public void quickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partition = quickSortPartition(array, low, high);
                quickSort(array, partition + 1, high);
                quickSort(array, low, partition - 1);
            }
        }

        public int quickSortPartition(int[] array, int low, int high)
        {
            int partition = array[high];
            int sorted = low;
            while (low < high)
            {
                if (array[low] <= partition)
                {
                    swap(ref array[sorted], ref array[low]);
                    sorted++;
                }
                low++;
            }
            swap(ref array[sorted], ref array[high]);
            return sorted;
        }

    }


}
