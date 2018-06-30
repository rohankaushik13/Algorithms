using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Pigeonhole_Sort
    {
        public Pigeonhole_Sort()
        {
            int[] array = { 62, 83, 18, 53, 7, 17, 95, 86, 47, 69, 25, 28 };
            Sort(array);
            Console.WriteLine(String.Join(",", array));
        }

        public void Sort(int[] array)
        {
            int len = array.Length;
            int[] minMax = new int[2];
            findMinAndMax(array, minMax);
            int range = minMax[0]-minMax[1]+1;
            if(range!=0)
            {
                List<int>[] pigeonhole = new List<int>[range];
                for (int i = 0; i < len; i++)
                {
                    int pos = array[i]-minMax[1];
                    if(pigeonhole[pos] == null)
                    {
                        pigeonhole[pos] = new List<int>();
                    }
                    pigeonhole[pos].Add(array[i]);
                }
                int x = 0;
                for(int j=0;j<range;j++)
                {
                    if (pigeonhole[j] != null)
                    {
                        foreach (int item in pigeonhole[j])
                        {
                            array[x] = item;
                            x++;
                        }
                    }
                }
            }
        }

        public void findMinAndMax(int[] array, int[] minMax)
        {
            minMax[0] = array[0];
            minMax[1] = array[0];
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]>minMax[0])
                {
                    minMax[0] = array[i];
                }
                if(array[i]<minMax[1])
                {
                    minMax[1] = array[i];
                }
            }
        }
    }
}
