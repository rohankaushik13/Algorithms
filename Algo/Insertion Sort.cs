using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Insertion_Sort
    {
        public Insertion_Sort()
        {
            Sort();
            Sort2();
        }

        private void Sort()
        {
            int[] array = { 12, 34, 44, 10, 40, 75, 54, 23, 65, 45, 67 };
            int len = array.Length;

            for (int i = 1; i < len; i++)
            {
                int pos = 0;
                int value = array[i];
                bool match = false;
                for (int j = 0; j < i; j++)
                {
                    if (value < array[j])
                    {
                        pos = j;
                        match = true;
                        break;
                    }
                }
                if (match)
                {
                    for (int k = i; k > pos; k--)
                    {
                        array[k] = array[k - 1]; ;
                    }

                    array[pos] = value;
                }
            }

            Console.WriteLine(String.Join(",", array));
        }

        private void Sort2()
        {
            int[] array = { 12, 34, 44, 10, 40, 75, 54, 23, 65, 45, 67 };
            int len = array.Length;

            for (int i = 1; i < len; i++)
            {
                int value = array[i];
                int j = 0;
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] > value)
                    {
                        array[j + 1] = array[j];
                    }
                    else
                    {
                        break;
                    }
                }
                array[j+1] = value;
            }
            Console.WriteLine(String.Join(",", array));
        }
    }
}
