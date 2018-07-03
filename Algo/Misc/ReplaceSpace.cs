using System;
using System.Text;

namespace Crack{
    public class ReplaceSpace{
        public ReplaceSpace(){
            int len = 24;
            string str = "rohan is a very good boy          ";
            char[] arr = new char[34];
            arr = str.ToCharArray();
            Replace(str, len);
            ReplaceChar(arr,len);
            UpdateSameArray(arr,len);
        }
        public void Replace(string str, int len){
            StringBuilder strnew = new StringBuilder(len);
            string[] strarray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            strnew.Append(String.Join("%20",strarray));
            Console.WriteLine(strnew);
        }

        public void ReplaceChar(char[] arr, int len){
            StringBuilder sbr = new StringBuilder();
            int k=0;
            for(int i=0;i<len;i++)
            {
                if(arr[i]== ' '){
                    sbr.Append(new String(arr,k,i-k));
                    sbr.Append("%20");
                    k=i+1;
                }
            }
             sbr.Append(new String(arr,k,len-k));
            Console.WriteLine(sbr);
        }

        public void UpdateSameArray(char[] arr, int len)
        {
            int spacecount = ((new string(arr)).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)).Length-1;
            int arraylen = len -1 + (spacecount *2);
            for(int i = len -1; i>=0; i--){
                if(arr[i] == ' '){
                    arr[arraylen] = '0';
                    arraylen--;
                    arr[arraylen] = '2';
                    arraylen--;
                    arr[arraylen] = '%';
                    arraylen--;
                }
                else{
                    arr[arraylen] = arr[i];
                    arraylen--;
                }
            }
            Console.WriteLine(arr);
        }
    }
}