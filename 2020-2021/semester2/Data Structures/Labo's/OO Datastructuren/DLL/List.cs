using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Datastructuren.DLL
{
    class List
    {
        #region private fields
        private Node firstNode, lastNode;
        #endregion

        #region public members
        public Node First { get => firstNode; private set => firstNode = value; }
        public Node Last { get => lastNode; private set => lastNode = value; }

        public int lenght { get; set; }

        public List()
        {
            lenght = 0;
        }
        public bool IsEmpty
        {
            get
            {
                return First == null;
            }
        }
        public Node AddFirst(int value)
        {
            //TODO: addFirst function maken
            var n = new Node(value);
            if (First != null)
                n.Next = First;
            else
                Last = n;

            First = n;
            lenght++;
            return n;
        }

        public Node AddLast(int value)
        {
            //TODO: addLast function maken
            Node n = new Node(value);

            if (First == null)
            {
                First = n;
            }
            else
            {
                Last.Next = n;

            }
            Last = n;

            lenght++;
            return n;
        }
        public Node AddAfter(Node afterNode, int value)
        {
            //TODO: 
            if (afterNode == null)
                throw new ArgumentException("The afterNode cannot be NULL");

            Node n = new Node(value);
            n.Next = afterNode.Next;
            afterNode.Next = n;
            lenght++;
            return n;
        }
        public Node AddBefore(Node beforeNode, int value)
        {
            if (beforeNode == null)
                throw new ArgumentException("The beforeNode cannot be NULL");

            Node n = new Node(value);
            if (ReferenceEquals(First, beforeNode))
            {
                return AddFirst(value);
            }

            n.Prev = beforeNode.Prev;
            n.Next = beforeNode;

            lenght++;
            return n;
        }


        // te werken
        public int RemoveNode(Node node)
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


        public Node FindNode(int value)
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


        //
        public void clear()
        {
            First = null;
            Last = null;
        }

        public void print()
        {
            while (First != null)
            {
                Console.Write(First.Value + "--");
                First = First.Next;
            }
        }

    } 
}
#endregion  