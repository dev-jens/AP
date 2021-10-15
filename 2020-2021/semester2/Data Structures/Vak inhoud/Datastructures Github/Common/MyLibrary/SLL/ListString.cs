using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.SLL
{
    public class ListString
    {
        #region public members
        public NodeString First { get; private set; }
        public NodeString Last { get; private set; }


        public NodeString AddFirst(string value)
        {
            var n = new NodeString(value);
            if (!IsEmpty)      //list not empty ?
                n.Next = First;
            else
                Last = n;

            First = n;
            return n;
        }

        public NodeString AddLast(string value)
        {
            var newNode = new NodeString(value);
            if (IsEmpty)
            {      //list empty ?
                First = newNode;
            }
            else
                Last.Next = newNode;

            Last = newNode;
            return newNode;
        }


        public NodeString AddAfter(NodeString afterNode, string value)
        {
            if (afterNode == null)
                throw new ArgumentException("The afterNode cannot be NULL");

            var n = new NodeString(value);
            n.Next = afterNode.Next;
            afterNode.Next = n;
            return n;
        }

        public NodeString AddBefore(NodeString beforeNode, string value)
        {
            if (beforeNode == null)
                throw new ArgumentException("The beforeNode cannot be NULL");

            var newNode = new NodeString(value);

            if (ReferenceEquals(First, beforeNode))  //want to add before the first ?
                return AddFirst(value);

            NodeString temp = FindPrevious(beforeNode);

            if (temp != null)       //Found the node before ?
            {
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
            else
                throw new Exception("The specified node is not part of this list");

            return newNode;
        }

        public string RemoveNode(NodeString node)
        {
            if (node == null)
                throw new ArgumentException("The node cannot be NULL");

            if (IsEmpty)
                throw new Exception("list is empty");

            if (ReferenceEquals(First, node))   //want to remove the first ?
            {
                First = node.Next;
                if (First == null)              //If there was only one node left
                    Last = null;
                return node.Value;
            }

            var prev = FindPrevious(node);
            if (prev != null)
            {
                prev.Next = node.Next;
                if (prev.Next == null)
                    Last = prev;
                return node.Value;
            }
            throw new Exception("The specified node is not part of this list");
        }

        public NodeString FindNode(string value)
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

        public bool IsEmpty
        {
            get
            {
                return First == null;
            }
        }

        public void Clear()
        {
            //To clear the list, we can remove the reference to the first & last node
            //The G.C. will cleanup for us...
            First = null;
            Last = null;
        }

        public int Length
        {
            get
            {
                //we cannot determine the length only via the first and last pointer
                //there are 2 possibilities, 
                //Or we navigate throught the whole list here => Time complexity : O(n)
                //Or we add a 'length' field which we increment and decrement when nodes are added/removed from the list : O(1)
                throw new NotImplementedException();
            }

            private set
            {
            }
        }

        public override string ToString()
        {
            if (IsEmpty)
                return "Empty list";
            else
                return First.ToString();
        }
        #endregion

        #region private members
        /// <summary>
        /// With a SLL sometimes we have to travel through the list to find the previous node 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private NodeString FindPrevious(NodeString node)
        {
            NodeString temp = First;

            if (ReferenceEquals(First, node))
                return null;  // there is no previous node

            while (temp != null && !ReferenceEquals(temp.Next, node))
                temp = temp.Next;

            return temp;
        }
        #endregion
    }
}
