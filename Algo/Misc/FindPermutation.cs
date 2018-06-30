using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class FindPermutation
    {
        string word;
        public FindPermutation(string word)
        {
            this.word = word;
            Find(word);
        }

        public void Find(string word)
        {
            HashSet<string> group = new HashSet<string>();
            group.Add(word[0].ToString());
            foreach (char c in word)
            {
                if (!group.Contains(c.ToString()))
                {
                    group = Permutate(c, group);
                }
            }
            Console.WriteLine("{0}", string.Join(",", group));
            Console.WriteLine("Count: {0}", group.Count());
        }

        public HashSet<string> Permutate(char c, HashSet<string> group)
        {
            HashSet<string> returnGroup = new HashSet<string>();
            foreach (string s in group)
            {
                for (int i = 0; i <= s.Length; i++)
                {
                    returnGroup.Add(s.Insert(i, c.ToString()));
                }
            }
            return returnGroup;
        }
    }
}
