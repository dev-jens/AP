using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.DLL
{
    public class ListInt
    {
        #region private fields
        private NodeInt firstNode, lastNode;
        #endregion

        #region public members
        public NodeInt First { get => firstNode; private set => firstNode = value; }
        public NodeInt Last { get => lastNode; private set => lastNode = value; }

        public bool IsEmpty
        {
            get
            {
                return First == null;
            }
        }

        public NodeInt AddFirst(int value)
        {
            var n = new NodeInt(value);
            if (!IsEmpty)           //list not empty ?
                n.Next = First;     //Connect the new node with the first node
            else
                Last = n;
            
            First = n;

            return n;
        }

        public NodeInt AddLast(int value)
        {
            var newNode = new NodeInt(value);
            if (IsEmpty)
                First = newNode;
            else
                Last.Next = newNode;
            
            Last = newNode;
            return newNode;
        }


        public NodeInt AddAfter(NodeInt afterNode, int value)
        {
            if (afterNode == null)
                throw new ArgumentException("The afterNode cannot be NULL");

            var newNode = new NodeInt(value);
            newNode.Next = afterNode.Next;
            afterNode.Next = newNode;
            return newNode;
        }

        public NodeInt AddBefore(NodeInt beforeNode, int value)
        {
            if (beforeNode == null)
                throw new ArgumentException("The beforeNode cannot be NULL");

            var newNode = new NodeInt(value);
            NodeInt temp = First;

            if (ReferenceEquals(First, beforeNode))  //want to add before the first ?
                return AddFirst(value);

            newNode.Prev = beforeNode.Prev;
            newNode.Next = beforeNode;

            return newNode;
        }


        public int RemoveNode(NodeInt node)
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

        public NodeInt FindNode(int value)
        {
            var temp = First;
            while (temp != null)
            {
                if (temp.Value == value)
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
