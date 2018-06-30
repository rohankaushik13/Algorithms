using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Arrays
{
    class StringBuffer
    {
        string[] strArray;
        int currentPointer;
        int size;
        public StringBuffer()
        {
            size = 5; 
            strArray = new string[size];
            currentPointer = 0;
        }

        public void Append(string str)
        {
            if(currentPointer <= size)
            strArray[currentPointer++] = str;
        }

        public string toString()
        {
            string result = String.Empty;
            foreach(string s in strArray)
            {
                result += s;
            }
            return result;
        }
    }
}
