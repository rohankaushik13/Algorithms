using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class BTNode
    {
        public int value;
        public BTNode left;
        public BTNode right;

        public BTNode()
        {
        }

        public BTNode(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }
    class BinarySearchTree
    {
        BTNode root;
        public BinarySearchTree()
        {
            root = new BTNode();
        }

        public void CreateTree()
        {
            BTNode root = new BTNode(50);
            AddNode(root, 30);
            AddNode(root, 70);
            AddNode(root, 20);
            AddNode(root, 40);
            AddNode(root, 60);
            AddNode(root, 80);

            if (Search(root, 30) != null)
            {
                Console.WriteLine("Value Found");
            }
            else
            {
                Console.WriteLine("Value NOT Found");
            }

            if (Search(root, 15) != null)
            {
                Console.WriteLine("Value Found");
            }
            else
            {
                Console.WriteLine("Value NOT Found");
            }

            Traverse("InOrder", root);
            Traverse("PreOrder", root);
            Traverse("PostOrder", root);

            RemoveNodeNormally(root, 20);
            Traverse("InOrder", root);
            RemoveNodeNormally(root, 30);
            Traverse("InOrder", root);
            RemoveNodeNormally(root, 50);
            Traverse("InOrder", root);

            /*RemoveNodeRecursiverly(root, 20);
            Traverse("InOrder", root);
            RemoveNodeRecursiverly(root, 30);
            Traverse("InOrder", root);
            RemoveNodeRecursiverly(root, 50);
            Traverse("InOrder", root);*/
        }

        public BTNode AddNode(BTNode parent, int value)
        {
            if (parent == null)
            {
                return new BTNode(value);
            }
            else if (value > parent.value)
            {
                parent.right = AddNode(parent.right, value);
            }
            else if (value < parent.value)
            {
                parent.left = AddNode(parent.left, value);
            }

            return parent;
        }

        public BTNode RemoveNodeRecursiverly(BTNode parent, int value)
        {
            if (parent == null)
            {
                return parent;
            }
            else if (value > parent?.value)
            {
                parent.right = RemoveNodeRecursiverly(parent.right, value);
            }
            else if (value < parent?.value)
            {
                parent.left = RemoveNodeRecursiverly(parent.left, value);
            }
            else
            {
                if (parent.left == null)
                {
                    return parent.right;
                }
                else if (parent.right == null)
                {
                    return parent.left;
                }
                else
                {
                    BTNode temp = MinValueNode(parent.right);
                    parent.value = temp.value;
                    parent.right = RemoveNodeRecursiverly(parent.right, temp.value);
                }
            }
            return parent;
        }

        public BTNode MinValueNode(BTNode parent)
        {
            while (parent.left != null)
            {
                parent = parent.left;
            }

            return parent;
        }

        public void RemoveNodeNormally(BTNode parent, int value)
        {
            BTNode ParentNode = parent;
            while (parent != null && parent.value != value)
            {
                ParentNode = parent;
                if (parent.value > value)
                {
                    parent = parent.left;
                }
                else if (parent.value < value)
                {
                    parent = parent.right;
                }
            }

            if(parent?.value == value)
            {
                if(parent?.left == null)
                {
                    ParentNode.left = ParentNode.value > value? parent.right: ParentNode.left;
                    ParentNode.right = ParentNode.value < value ? parent.right : ParentNode.right;
                }
                else if (parent?.right == null)
                {
                    ParentNode.left = ParentNode.value > value ? parent.left : ParentNode.left;
                    ParentNode.right = ParentNode.value < value ? parent.left : ParentNode.right;
                }
                else
                {
                    int minNodeValue = MinValueNode(parent, true);
                    parent.value = minNodeValue;
                }
            }
        }

        public int MinValueNode(BTNode parent, bool deleteNode)
        {
            BTNode parentNode = parent;
            BTNode minNode = parent.right;
            if (parent.right.left != null)
            {
                while (minNode.left != null)
                {
                    parentNode = minNode;
                    minNode = minNode.left;
                }
                if (deleteNode)
                {
                    parentNode.left = null;
                }
            }
            else
            {
                parent = parent.right;
            }          
            return minNode.value;
        }

        public BTNode Search(BTNode parent, int value)
        {
            if (parent == null || value == parent?.value)
            {
                return parent;
            }
            else if (value > parent?.value)
            {
                parent = Search(parent.right, value);
            }
            else if (value < parent?.value)
            {
                parent = Search(parent.left, value);
            }
            return parent;
        }

        public void Traverse(string type, BTNode parent)
        {
            switch (type)
            {
                case "InOrder":
                    {
                        Console.WriteLine("Inorder");
                        InOrder(parent);
                        Console.WriteLine();
                        break;
                    }
                case "PreOrder":
                    {
                        Console.WriteLine("PreOrder");
                        PreOrder(parent);
                        Console.WriteLine();
                        break;
                    }
                case "PostOrder":
                    {
                        Console.WriteLine("Postorder");
                        PostOrder(parent);
                        Console.WriteLine();
                        break;
                    }
            }
        }

        public void InOrder(BTNode parent)
        {
            if (parent != null)
            {
                InOrder(parent.left);
                Console.Write("{0}=>", parent.value);
                InOrder(parent.right);
            }
        }

        public void PostOrder(BTNode parent)
        {
            if (parent != null)
            {
                InOrder(parent.left);
                InOrder(parent.right);
                Console.Write("{0}=>", parent.value);
            }
        }

        public void PreOrder(BTNode parent)
        {
            if (parent != null)
            {
                Console.Write("{0}=>", parent.value);
                InOrder(parent.left);
                InOrder(parent.right);
            }
        }

    }
}
