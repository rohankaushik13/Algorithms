using System;
using System.Collections.Generic;

namespace Algo
{
    public class Permutation
    {
        public Permutation()
        {
            string s1 = "ross";
            string s2 = "roos";
            Permute(s1, s2);
        }

        public void Permute(string s1, string s2){
            Dictionary<char,int> dic = new Dictionary<char, int>();
            if(s1.Length != s2.Length)
            {
                Console.WriteLine("No");
                return;
            }
            foreach(char c in s1)
            {
                if(dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c,1);
                }
            }
            foreach(char c in s2)
            {
                if(dic.ContainsKey(c))
                {
                    dic[c]--;
                    if(dic[c]<0)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                else{
                    Console.WriteLine("No");
                    return;
                }
            }
            
            Console.WriteLine("Yes");
        }
    }
}