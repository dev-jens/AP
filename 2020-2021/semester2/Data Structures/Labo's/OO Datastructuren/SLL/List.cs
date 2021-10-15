using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Datastructuren.SLL
{
    class List
    {
        public Node First { get;  set; }

        public Node Last { get;  set; }
        
        public int Lenght { get; set; }

        public List()
        {
            Lenght = 0;
        }
        public Node AddFirst(int value)
        {
            //TODO: addFirst function maken
            var node = new Node(value);
            if (First != null)
                node.Next = First;
            else
                Last = node;

            First = node;
            Lenght++;
            return node;
        }


        public Node AddLast(int value)
        {
            //TODO: addLast function maken
            Node n = new Node(value);
            Node n2 = new Node(value);
            if (First == null)
            {
                First = n;
            }
            else
            {
                Last.Next = n;
              
            }
            Last = n;

            Lenght++;
            return n;
        }

        public int RemoveNode(Node node)
        {
           
            if (node == null)
                throw new ArgumentException("The node cannot be NULL");

            if (First == null)
                throw new Exception("list is empty");

            
            if (ReferenceEquals(First, node)) // eerste  rm
            {
                First = node.Next;
                if (First == null)
                    Last = null;
                Lenght--;
                return node.Value; // waarom
            }

            var prev = FindPrev(node);
            if (prev != null)
            {
                prev.Next = node.Next;
                if (prev.Next == null)
                {
                    Last = prev;
                }
                Lenght--;
                return node.Value;
            }
            throw new Exception("The specified node is not part of this list");
  
        }

        public Node AddAfter(Node afterNode, int value)
        {
            //TODO: 
            if (afterNode == null)
                throw new ArgumentException("The afterNode cannot be NULL");

            Node n = new Node(value);
            n.Next = afterNode.Next;
            afterNode.Next = n;
            Lenght++;
            return n;
        }
        public Node AddBefore(Node beforeNode, int value)
        {
            if (beforeNode == null)
                throw new ArgumentException("The beforeNode cannot be NULL");

            Node n = new Node(value);
            if (ReferenceEquals(First,beforeNode))
            {
                return AddFirst(value);
            }

            Node tmp = FindPrev(beforeNode);

            if (tmp  != null )
            {
                n.Next = tmp.Next;
                tmp.Next = n;
            }
            else
                throw new Exception("The specified node is not part of this list");
            Lenght++;
            return n;
        }

        public Node FindNode(int value)
        {
            var tmp = First;
            while (tmp != null)
            {
                if (tmp.Value == value)
                    return tmp;
                

                tmp = tmp.Next;
            }

            return tmp; 
        }
        public Node Findode(int value)
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
     

        private Node FindPrev(Node n)
        {
            Node tmp = First;

            while(tmp != null && !ReferenceEquals(tmp.Next,n))
            {
                tmp = tmp.Next;
            }

            return tmp;
        }
        public bool IsEmpty
        {
            get
            {
                return First == null;
            }
        }




    }
}
