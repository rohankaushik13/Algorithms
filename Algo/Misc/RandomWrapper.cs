using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class RandomWrapper
    {
        public RandomWrapper()
        {
            Random(2, 54);
            Random(200, 540);
        }
        public int Random(int min, int max)
        {
            Random r = new Random();
            int num = r.Next();
            num = (num % (max - min + 1)) + min;
            Console.WriteLine("{0}>={1}>={2}", max, num, min);
            return num;
        }
    }
}
