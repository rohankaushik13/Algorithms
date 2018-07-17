using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class LongestPalindromeInAString
    {
        public LongestPalindromeInAString()
        {
            string input = "rohanahormadam1ohanaho1";
            string output = FindPalindrome(input);
            Console.WriteLine("Longest Palindrome : {0}", output);
        }

        public string FindPalindrome(string input)
        {
            string largestPalindrome = "";
            int largestPalindromeLength = 0;
            int iterator = 0;
            int length = input.Length;
            while(iterator != length)
            {
                int sublength = length-iterator;
                while (sublength !=0)
                {
                    string substring = input.Substring(iterator, sublength);
                    if (CheckPalindorme(substring))
                    {
                        if (sublength >= largestPalindromeLength) // >, for first largest palindrome
                        {
                            largestPalindrome = substring;
                            largestPalindromeLength = sublength;
                        }
                    }
                    sublength--;
                }
                iterator++;
            }
            return largestPalindrome;
        }

        public bool CheckPalindorme(string input)
        {
            int iterator = 0;
            int length = input.Length -1;
            while (iterator < length)
            {
                if(input[iterator] != input[length])
                {
                    return false;
                }
                iterator++;
                length--;
            }

            return true;
        }
    }
}
