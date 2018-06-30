using System;
using System.Text;

namespace Algo
{
    public class SubString{
        public SubString(){
            string s2 = "waterbottle";
            string s1 = "terbottlewa";
            Rotation(s1,s2);

        }

        public bool isSubString(string s1,string s2){
            if(s1.Contains(s2)){
                return true;
            }
            else{
                return false;
            }
        }
        public void Rotation(string s1, string s2)
        {
            StringBuilder sbr = new StringBuilder();
            sbr.Append(s1).Append(s1);
            if(isSubString(sbr.ToString(),s2)){
                Console.WriteLine("Yes");
            }
            else{
                Console.WriteLine("No");
            }

        }
    }
}