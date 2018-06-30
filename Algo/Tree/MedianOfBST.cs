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

            //int median = Median(root, count, 0);
            //Console.WriteLine(median);
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

        public int Median(TreeNode root, int count)
        {
            //int medianPos = 0;
            //int counter = 0;
            //if(count %2 == 0)
            //{
            //    medianPos = count / 2;
            //}
            //else
            //{
            //    medianPos = (count / 2) + 1;
            //}
            //while(counter <= medianPos)
            //{
            //    root = root.left;
            //    counter++;
            //}
            return 0;
        }
    }
}
