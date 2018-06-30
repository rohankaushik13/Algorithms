using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Bucket_Sort
    {
        public Bucket_Sort()
        {
            double[] array = { 0.897, 0.565, 0.656, 0.1234, 0.665, 0.3434 };
            Sort(array);
            Console.WriteLine(String.Join(",", array));
        }

        private void Sort(double[] array)
        {
            int size = array.Length;
            List<double>[] bucket = new List<double>[size];
            int x = 0;
            for (int i = 0; i < size; i++)
            {
                int position = (int)(size * array[i]);
                if(bucket[position]==null)
                { 
                    bucket[position] = new List<double>();
                }
                bucket[position].Add(array[i]);
            }

            for(int j=0;j<size;j++)
            {
               bucket[j] =  sortBucket(bucket[j]);
            }

            for(int k=0;k<size;k++)
            {
                if (bucket[k] != null)
                {
                    foreach (double number in bucket[k])
                    {
                        array[x] = number;
                        x++;
                    }
                }
            }
        }

        private List<double> sortBucket(List<double> bucket)
        {
            if (bucket != null)
            {
                for (int i = 0; i < bucket.Count - 1; i++)
                {
                    for (int j = 0; j < bucket.Count - i - 1; j++)
                    {
                        if (bucket[j] > bucket[i])
                        {
                            double temp = bucket[j];
                            bucket[j] = bucket[i];
                            bucket[i] = temp;
                        }
                    }
                }
            }
           return bucket;
        }
    }
}
