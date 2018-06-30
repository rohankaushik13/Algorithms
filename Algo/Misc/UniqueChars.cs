using System;

namespace Algo
{
    public class UniqueChars
    {
        public UniqueChars()
        {
            string str = "rohan isbet";
            CheckChars(str);
        }
        public void CheckChars(string str)
        {
            int len = str.Length;
            for(int i=0;i<len;i++)
            {
                int pos = str.LastIndexOf(str[i]);
                if(pos != i)
                {
                    Console.WriteLine("Not Unique");
                    return;
                }
            }
            Console.WriteLine("Unique");
        }
    }

}