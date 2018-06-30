using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Bubble_Sort
    {
        public Bubble_Sort()
        {
            Sort();
        }

        public void Sort()
        {
            int[] array = { 12, 34, 44, 10, 40, 75, 54, 23, 65, 45, 67 };
            int len = array.Length;
            for (int i = 0; i < len-1; i++)
            {
                bool swap = false;
                for(int j = 0;j<len-i-1;j++)
                {
                    if(array[j]>array[j+1])
                    {
                        array[j] = array[j] + array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] = array[j] - array[j + 1];
                        swap = true;
                    }
                }
                if(!swap)
                {
                    break;
                }
            }

            Console.WriteLine(String.Join(",", array));
        }
    }
}
