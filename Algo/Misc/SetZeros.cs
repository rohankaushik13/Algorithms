using System;
using System.Text;
namespace Algo
{
    public class SetZeros{
        public SetZeros(){
            int[,] mtr = new int[5,6]{{1,2,3,4,5,6},{7,8,9,10,11,12},{13,14,0,16,17,18},{19,20,21,22,23,24},{25,26,27,28,29,30}};;
            Print(mtr);
            SetZero(mtr);           
        }

        public void Print(int[,] mtr){
            int row = mtr.GetLength(0);
            int col = mtr.GetLength(1);
            for (int i = 0; i <row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", mtr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
        public void SetZero(int[,] mtr)
        {
            int row = mtr.GetLength(0);
            int col = mtr.GetLength(1);
            Boolean[] rowarray = new Boolean[row];
            Boolean[] colarray = new Boolean[col];
            StringBuilder ij = new StringBuilder();
            for(int i=0;i<row;i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if(mtr[i,j]==0)
                    {

                        rowarray[i] = true;
                        colarray[j] = true;
                    }
                }
            }

            for(int i=0;i<row;i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if(rowarray[i] || colarray[j])
                    {
                        mtr[i,j] = 0;
                    }
                }
            }

            Print(mtr);
        }
    }
}
