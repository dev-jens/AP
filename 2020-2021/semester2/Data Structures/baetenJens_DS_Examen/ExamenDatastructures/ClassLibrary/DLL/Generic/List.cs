using System;

namespace ClassLibrary.DLL.Generic
{
    /// <summary>
    /// Deze klasse NIET aanpassen !!!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class List<T> 
    {
        #region private fields
        private Node<T> firstNode, lastNode;
        #endregion

        #region public members
        public Node<T> First { get => firstNode; private set => firstNode = value; }
        public Node<T> Last { get => lastNode; private set => lastNode = value; }

        public bool IsEmpty
        {
            get
            {
                return First == null;
            }
        }

        public Node<T> AddFirst(T value)
        {
            var n = new Node<T>(value);
            if (!IsEmpty)           //list not empty ?
                n.Next = First;     //Connect the new node with the first node
            else
                Last = n;

            First = n;

            return n;
        }

        public Node<T> AddLast(T value)
        {
            var newNode = new Node<T>(value);
            if (IsEmpty)
                First = newNode;
            else
                Last.Next = newNode;

            Last = newNode;
            return newNode;
        }


        public Node<T> AddAfter(Node<T> afterNode, T value)
        {
            if (afterNode == null)
                throw new ArgumentException("The afterNode cannot be NULL");

            var newNode = new Node<T>(value);
            newNode.Next = afterNode.Next;
            afterNode.Next = newNode;
            return newNode;
        }

        public Node<T> AddBefore(Node<T> beforeNode, T value)
        {
            if (beforeNode == null)
                throw new ArgumentException("The beforeNode cannot be NULL");

            var newNode = new Node<T>(value);
            Node<T> temp = First;

            if (ReferenceEquals(First, beforeNode))  //want to add before the first ?
                return AddFirst(value);

            newNode.Prev = beforeNode.Prev;
            newNode.Next = beforeNode;

            return newNode;
        }


        public T RemoveNode(Node<T> node)
        {
            if (node == null)
                throw new ArgumentException("The node cannot be NULL");

            if (ReferenceEquals(node, First))  //first node ?
                First = node.Next;
            else
                node.Prev.Next = node.Next;   // otherwise update the reference of the previous node

            if (ReferenceEquals(node, Last))   //last node ?
                Last = node.Prev;

            return node.Value;
        }

        public Node<T> FindNode(T value)
        {
            var temp = First;
            while (temp != null)
            {
                if (temp.Value.Equals(value))
                    return temp;
                temp = temp.Next;
            }
            return temp;
        }

        public void Clear()
        {
            Last = null;
            First = null;
        }
        #endregion

        #region private members
        #endregion
    }
}
