using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.Tree
{
    class Tree<T> where T: IComparable<T>
    {
        public Node<T> Root { get; private set; }

        #region public
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
                if (node.Value.Equals(value))
                    return node;
                else if (node.Value.CompareTo(value) > 0)
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

        public Node<T> FindNode(T value)
        {
            var node = FindNode(Root, value);       // This will return the parent if the node is not present
            if (!node.Value.Equals(value))
                return null;

            return node;
        }

        public T Remove(T value)
        {
            Root = Remove(Root, value);
            return value;
        }

        public int Height(Node<T> root)
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
        private Node<T> FindNode(Node<T> parent, T value)
        {
            Node<T> temp;

            if (parent == null)
                return parent;

            if (parent.Value.Equals(value))
                temp = parent;
            else if (parent.Value.CompareTo(value) > 0)
                temp = FindNode(parent.Left, value);
            else
                temp = FindNode(parent.Right, value);
            // conditon ? true : false
            return (temp == null ? parent : temp);
        }

        private T FindMinValue(Node<T> root)
        {
            if (root == null)
                return default(T);
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
