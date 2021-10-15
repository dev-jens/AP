using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Datastructuren.BST
{
    class Tree
    {
        public node Root { get; private set; }

        #region public
        public node Insert(int value)
        {
            var newNode = new node(value);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var node = FindNode(Root, value);
                if (node.Value == value) 
                    return node;
                else if (node.Value > value)
                {
                    node.Left = newNode;
                }
                else
                {
                    node.Right = newNode;
                }      
            }
            return newNode;
        }

        public node FindNode(int value)
        {
            var node = FindNode(Root, value);       // This will return the parent if the node is not present
            if (node.Value != value)
                return null;

            return node;
        }

        public int Remove(int value)
        {
            Root = Remove(Root, value);
            return value;
        }
        public int Height(node root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftHeight = Height(root.Left);
            int rightheigt = Height(root.Right);

            return Math.Max(leftHeight, rightheigt) + 1;
        }

        public void Clear()
        {
            Root = null;
        }

        #endregion

        #region private
        private node Remove(node root, int value)
        {
            if (root == null)
                return null;

            //First descend the tree to find the node with the specified value
            if (root.Value.CompareTo(value) > 0)
            {
                root.Left = Remove(root.Left, value);
                return root;
            }
            else if (root.Value.CompareTo(value) < 0)
            {
                root.Right = Remove(root.Right, value);
                return root;
            }

            //found the node with the requested value, let"s remove it
            if (root.Left == null) // max. 1 child
                return root.Right;
            if (root.Right == null) // max. 1 child
                return root.Left;

            var min = FindMinValue(root.Right);
            var newn = Remove(root, min);                //remove the original node
            root.Value = min;                       //take over the value
            return newn;
        }
        private node FindNode(node parent, int value)
        {
            node temp;

            if (parent == null)
                return parent;

            if (parent.Value == value)
                temp = parent;
            else if (parent.Value > value)
                temp = FindNode(parent.Left, value);
            else
                temp = FindNode(parent.Right, value);
            // conditon ? true : false
            return (temp == null ? parent : temp);
        }

        private int FindMinValue(node root)
        {
            if (root == null)
                return -1;
            if (root.Left != null)
                return FindMinValue(root.Left);
            return root.Value;
            /*
            while (root != null)
            {
                root = root.Left;
            }
            return root.Value;
            */
        }

    
        
        #endregion 
    }
}
