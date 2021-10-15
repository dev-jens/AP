using MyLibrary.Tree.Binary.Generic;
using System;

namespace MyLibrary.Tree.BST.Generic
{
    /// <summary>
    /// This class represents a Binary Search Tree
    /// </summary>
    public class Tree<T> where T :  IComparable<T>
    {
        public Node<T> Root { get; private set; }

        #region public area
        public Node<T> Insert(T value)
        {
            var newNode = new Node<T>(value);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var node = FindNode(Root, value);
                if (node.Value.CompareTo(value) == 0)        // value already present
                    return node;
                else if (node.Value.CompareTo(value) > 0)
                {
                    node.Left = newNode;
                }
                else
                    node.Right = newNode;
            }
            return newNode;
        }

        public Node<T> FindNode(T value)
        {
            var node = FindNode(Root, value);       // This will return the parent if the node is not present
            if (node.Value.CompareTo(value) != 0)
                return null;

            return node;
        }

        public T Remove(T value)
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

        private Node<T> Remove(Node<T> root, T value)
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


        private T FindMinValue(Node<T> root)
        {
            if (root == null)
                return default(T);
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
        private Node<T> FindNode(Node<T> parent, T value)
        {
            Node<T> temp;

            if (parent == null)
                return parent;

            if (parent.Value.CompareTo(value) == 0)
                temp = parent;
            else if (parent.Value.CompareTo(value) > 0)
                temp = FindNode(parent.Left, value);
            else
                temp = FindNode(parent.Right, value);

            return (temp == null ? parent : temp);
        }
        #endregion
    }
}
