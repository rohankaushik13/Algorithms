using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Radix_Sort
    {
        public Radix_Sort()
        {
            int[] array = { 170, 45, 75, 90, 802, 24, 2, 66 };
            array = Sort(array);
            Console.WriteLine(String.Join(",", array));
        }

        private int[] Sort(int[] array)
        {
            int high = findMaxElement(array);
            int digits = findTotalDigits(high);
            int[] tempArray = new int[11];
            int[] sortedArray = new int[array.Length];
            int len = 0;

            for (int i = 1; i <= digits; i++)
            {
                Array.Clear(tempArray, 0, tempArray.Length);
                len = array.Length - 1;
                while (len >= 0)
                {
                    int a = findDigit(array[len], i);
                    tempArray[a]++;
                    len--;
                }

                for (int j = 1; j < tempArray.Length; j++)
                {
                    tempArray[j] += tempArray[j - 1];
                }

                for (int x = array.Length-1; x >=0; x--)
                {
                    int b = findDigit(array[x], i);
                    sortedArray[tempArray[b]-1] = array[x];
                    tempArray[b]--;
                }

                Array.Copy(sortedArray, array, array.Length);
            }
            return sortedArray;
        }

        private int findDigit(int value, int position)
        {
            int power = (int)Math.Pow(10, position-1);
            value = value / power;
            value = value % 10;
            return value;

        }
        private int findTotalDigits(int high)
        {
            int digits = 0;
            while (high > 0)
            {
                high = Math.Abs(high) / 10;
                digits++;
            }

            return digits;
        }
        private int findMaxElement(int[] array)
        {
            int high = array[0];
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
