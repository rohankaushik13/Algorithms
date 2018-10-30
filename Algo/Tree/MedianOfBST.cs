using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class MedianOfBST
    {

        BST bst;
        public MedianOfBST()
        {
            bst = new BST();
            TreeNode root = CreateTree();
            int count = 0;
            count = CountNodes(root, count);

            double median = Median(root, count);
            Console.WriteLine(median);
        }

        public TreeNode CreateTree()
        {
            TreeNode root = null;
            root = bst.Add(root, 50);
            bst.Add(root, 30);
            bst.Add(root, 70);
            bst.Add(root, 20);
            bst.Add(root, 40);
            bst.Add(root, 60);
            bst.Add(root, 80);
            bst.Add(root, 90);

            return root;
        }

        public int CountNodes(TreeNode root, int count)
        {
            if (root != null)
            {
                count++;
                count = CountNodes(root.left, count);
                count = CountNodes(root.right, count);
            }
            return count;
        }

        public double Median(TreeNode root, int count)
        {
            double medianPos = 0;
            if (count % 2 != 0)
            {
                //odd - 7 // 4
                medianPos = Math.Ceiling((double) count / 2);
            }
            else
            {
                //even - 8 // 4.5
                medianPos = (double) (count + 1) / 2;
            }

            double median = 0;
            GetMedian(root, medianPos, 0 , ref median);

            return median;
        }

        public int GetMedian(TreeNode parent, double medianPos, int count, ref double median)
        {
            if (parent != null)
            {
                count = GetMedian(parent.left, medianPos, count, ref median);
                count++;
                if (count == medianPos)
                {
                    median = parent.value;
                }
                else if (Math.Floor(medianPos) <= count && count <= Math.Ceiling(medianPos))
                {
                    if (median != 0)
                    {
                        median = median + (parent.value / 2);
                    }
                    else
                    {
                        median = (median + parent.value) / 2;
                    }
                }
                count = GetMedian(parent.right, medianPos, count, ref median);
            }
            return count;
        }
    }
}
