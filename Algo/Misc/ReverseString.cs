using System;

namespace Algo
{
    public class ReverseString
    {
        public ReverseString()
        {
            char[] str = new char[] {'r','o','h','a','n','\0'};
            Reverse(str);
        }
        public void Reverse(char[] str)
        {
            int len = str.Length;
            int run = (len-2)/2;
            Console.WriteLine(run);
            for(int i=0;i<=run;i++)
            {
                char temp = str[i];
                str[i] = str[len-2-i];
                str[len-2-i] = temp;
            }
            Console.WriteLine("/" + new String(str)+ "/");
        }

    }
}