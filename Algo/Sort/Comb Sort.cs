using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Comb_Sort
    {
        public Comb_Sort()
        {
            int[] array = { 8, 4, 1, 56, 3, -44, 23, -6, 28, 0 };
            Sort(array);
            Console.WriteLine(String.Join(",", array));
        }

        public void Sort(int[] array)
        {
            int len = array.Length;
            int gap = len;

            do{
                for(int i=0;i+gap<len;i++)
                {
                    if(array[i]>array[i+gap])
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                    }
                }
                gap = (int)(gap / 1.3);
            }while(gap>0);

        }
    }
}
