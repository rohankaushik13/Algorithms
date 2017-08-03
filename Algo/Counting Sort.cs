using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Counting_Sort
    {
        public Counting_Sort()
        {
            int[] array = { 170, 45, 75, 90, 802, 24, 2, 66 };
            array = Sort(array);
            Console.WriteLine(String.Join(",", array));
        }

        private int[] Sort(int[] array)
        {
            int high = findMaxElement(array);
            int[] countArray = new int[high + 1];
            Array.Clear(countArray, 0, countArray.Length);

            int len = array.Length - 1;
            int counter = 1;
            int[] tempArray = new int[array.Length];
            while (len >= 0)
            {
                countArray[array[len]]++;
                len--;
            }
            while (counter <= high)
            {
                countArray[counter] = countArray[counter] + countArray[counter - 1];
                counter++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[countArray[array[i]]-1] = array[i];
                countArray[array[i]]--;
            }

            return tempArray;

        }

        private int findMaxElement(int[] array)
        {
            int high = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > high)
                {
                    high = array[i];
                }
            }
            return high;
        }
    }
}
