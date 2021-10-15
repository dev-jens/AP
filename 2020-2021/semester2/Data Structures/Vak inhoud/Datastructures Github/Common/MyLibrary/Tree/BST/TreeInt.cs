using MyLibrary.Tree.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Tree.BST
{

    /// <summary>
    /// This class represents a Binary Search Tree
    /// </summary>
    public class TreeInt
    {
        public NodeInt Root { get; private set; }

        #region public area
        public NodeInt Insert(int value)
        {
            var newNode = new NodeInt(value);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var node = FindNode(Root, value);
                if (node.Value == value)        // value already present
                    return node;
                else if (node.Value > value)
                {
                    node.Left = newNode;
                }
                else
                    node.Right = newNode;
            }
            return newNode;
        }

        public NodeInt FindNode(int value)
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

        public void Clear()
        {
            Root = null;
        }
        #endregion

        #region private parts

        private NodeInt Remove(NodeInt root, int value)
        {
            if (root == null)
                return null;

            //First descend the tree to find the node with the specified value
            if (root.Value > value)
            {
                root.Left = Remove(root.Left, value);
                return root;
            }
            else if (root.Value < value)
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


        private int FindMinValue(NodeInt root)
        {
            if (root == null)
                return -1;
            if (root.Left != null)
                return FindMinValue(root.Left);
            return root.Value;
        }

        /// <summary>
        /// Find the node with the specified value in the tree starting from the specified parent node
        /// This method will either return the node itself, or the parent of the node (if the node itself does not exist)
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private NodeInt FindNode(NodeInt parent, int value)
        {
            NodeInt temp;

            if (parent == null)
                return parent;

            if (parent.Value == value)
                temp = parent;
            else if (parent.Value > value)
                temp = FindNode(parent.Left, value);
            else
                temp = FindNode(parent.Right, value);

            return (temp == null ? parent : temp);
        }
        #endregion
    }
}
