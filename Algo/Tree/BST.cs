using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }
    class BST
    {

        public void Run()
        {
            TreeNode root = null;
            root = Add(root, 50);
            Add(root, 30);
            Add(root, 70);
            Add(root, 20);
            Add(root, 40);
            Add(root, 60);
            Add(root, 80);       

            InOrder(root);
            Console.WriteLine();

            Remove(root, 20);
            InOrder(root);
            Console.WriteLine();
            Remove(root, 30);
            InOrder(root);
            Console.WriteLine();
            Remove(root, 50);
            InOrder(root);
            Console.WriteLine();

        }

        public TreeNode Add(TreeNode root, int value)
        {
            if (root == null)
            {
                return new TreeNode(value);
            }
            else if (value > root.value)
            {
                root.right = Add(root.right, value);
            }
            else if (value < root.value)
            {
                root.left = Add(root.left, value);
            }
            return root;
        }

        public TreeNode Remove(TreeNode root, int value)
        {
            if (root == null)
            {
                return root;
            }
            else if (value > root.value)
            {
                root.right = Remove(root.right, value);
            }
            else if (value < root.value)
            {
                root.left = Remove(root.left, value);
            }
            else
            {
                if (root.left == null)
                    return root.right;
                if (root.right == null)
                    return root.left;

                TreeNode minLeftNode = GetMinLeftNode(root.right);
                root.value = minLeftNode.value;
                root.right = Remove(root.right, minLeftNode.value);
            }
            return root;
        }

        public TreeNode GetMinLeftNode(TreeNode right)
        {
            while(right.left !=null)
            {
                right = right.left;
            }
            return right;
        }

        public void InOrder(TreeNode parent)
        {
            if (parent != null)
            {
                InOrder(parent.left);
                Console.Write("{0}=>", parent.value);
                InOrder(parent.right);
            }
        }
    }
}
