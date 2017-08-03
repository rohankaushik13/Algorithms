
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Jump_Search
    {
        public Jump_Search()
        {
            Search();
        }

        public void Search()
        {
            
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 23, 24, 25, 26, 27, 28, 29, 30 };
            int term = 2;
            int jump = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(array.Length)));
            int counter = 0;
            bool found = false;
            while (counter < array.Length)
            {
                if (term == array[counter])
                {
                    found = true;
                    break;
                }
                else if (term < array[counter])
                {
                    for (int i = counter - jump + 1; i < counter; i++)
                    {
                        if (term == array[i])
                        {
                            found = true;
                            break;
                        }
                    }
                }
                counter += jump;
            }
            if(found)
            {
                Console.WriteLine("Term Found");
            }
            else
            {
                Console.WriteLine("Term Not Found");
            }
        }
    }
}
