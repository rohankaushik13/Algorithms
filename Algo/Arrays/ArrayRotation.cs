using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class ArrayRotation
    {
        public ArrayRotation()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int rotateby = 6;
            Console.WriteLine(String.Join(",", array));
            Rotate(array, rotateby);
            Console.WriteLine(String.Join(",", array));
            array = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            rotateby = 6;
            Console.WriteLine(String.Join(",", array));
            ReversalRotate(array, rotateby);
            Console.WriteLine(String.Join(",", array));
        }

        public ArrayRotation(int i=0)
        {

        }

        public void Rotate(int[] array, int rotateby)
        {
            int n = array.Length;
            int[] tempArray = new int[rotateby];
            int k = 0;
            for(int i=0;i<n+rotateby;i++)
            {
                if(i<rotateby)
                {
                    tempArray[i] = array[i];
                }
                else if(i>=rotateby && i<n)
                {
                    array[i - rotateby] = array[i];
                }
                else
                {
                    array[i - rotateby] = tempArray[k];
                    k++;
                }
            }
        }

        public void ReversalRotate(int[]array, int rotateBy)
        {
            int len = array.Length;
            reverse(array, 0, rotateBy-1);
            reverse(array, rotateBy, len - 1);
            reverse(array, 0, len - 1);
        }


        public void reverse(int[] array, int start, int end)
        {
            while(start<end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
