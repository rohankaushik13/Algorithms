using System;
using System.Text;

namespace Algo
{
    public class Compress{
        public Compress(){
            string str = "aabccccddeeefffffgg";
            compressString(str);
        }

        public void compressString(string str){
            StringBuilder strbldr = new StringBuilder();
            int counter = 1;
            for(int i=1;i<str.Length;i++){
                if(str[i] == str[i-1]){
                    counter++;
                }
                else{
                    strbldr.Append(str[i-1] + counter.ToString());
                    counter = 1;
                }
                if(i==str.Length-1){
                    strbldr.Append(str[i-1] + counter.ToString());
                }
            }
            Console.WriteLine(strbldr);
        }
    }
}