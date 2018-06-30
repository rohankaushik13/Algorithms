using System;
using System.IO;

namespace Algo{
    public class MatrixRotation{
        public MatrixRotation(){
            int[,] n = new int[6,6] {{1,2,3,4,5,6},{7,8,9,10,11,12},{13,14,15,16,17,18},{19,20,21,22,23,24},{25,26,27,28,29,30},{31,32,33,34,35,36}};
            int len = Convert.ToInt32(Math.Sqrt(n.Length));
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(string.Format("{0} ", n[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Rotate(n, len);
        }

        public void Rotate(int[,] n, int len)
        {
            int y = len-1;
            for(int i=0;i<len/2 ;i++)
            {
                for(int j=i;j<y-i;j++)
                {
                    int temp = n[i,j];
                    n[i,j] = n[y-j,i];
                    n[y-j,i] = n[y-i,y-j];
                    n[y-i,y-j] = n[j,y-i];
                    n[j,y-i] = temp;
                }
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(string.Format("{0} ", n[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}