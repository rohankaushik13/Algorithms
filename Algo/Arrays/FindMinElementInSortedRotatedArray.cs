using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class FindMinElementInSortedRotatedArray
    {
        int len = 0;
        public FindMinElementInSortedRotatedArray(int[] arr, int rotateby)
        {
            ArrayRotation ar = new ArrayRotation(10);
            ar.Rotate(arr, rotateby);
            Console.WriteLine("{0}", String.Join(",", arr));
            len = arr.Length - 1;
            int min = FindMin(arr, 0, len / 2, len);
            Console.WriteLine("Minimum Value: {0}", min);
        }

        public int FindMin(int[] arr, int left, int mid, int right)
        {
            int returnV = arr[right];
            if (right - left <= 1)
            {
                return returnV;
            }
            else if (arr[mid] > arr[right])
            {
                returnV = FindMin(arr, mid, (right + mid) / 2, right);
            }
            else if ((arr[mid] < arr[right]))
            {
                returnV = FindMin(arr, left, (left + mid) / 2, mid);
            }
            return returnV;
        }
    }
}
