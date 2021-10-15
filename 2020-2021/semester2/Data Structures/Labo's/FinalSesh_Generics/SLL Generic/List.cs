using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSesh_Generics.SLL_Generic
{
    class List<T>
    {
        public Node<T> First { get; set; }

        public Node<T> Last { get; set; }

        public int Lenght { get; set; }

        public List()
        {
            Lenght = 0;
        }
        public Node<T> AddFirst(T value)
        {
            //TODO: addFirst function maken
            var node = new Node<T>(value);
            if (First != null)
                node.Next = First;
            else
                Last = node;

            First = node;
            Lenght++;
            return node;
        }


        public Node<T> AddLast(T value)
        {
            //TODO: addLast function maken
            Node<T> n = new Node<T>(value);
            Node<T> n2 = new Node<T>(value);
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

        public T RemoveNode(Node<T> node)
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

        public Node<T> AddAfter(Node<T> afterNode, T value)
        {
            //TODO: 
            if (afterNode == null)
                throw new ArgumentException("The afterNode cannot be NULL");

            var n = new Node<T>(value);
            n.Next = afterNode.Next;
            afterNode.Next = n;
            Lenght++;
            return n;
        }
        public Node<T> AddBefore(Node<T> beforeNode, T value)
        {
            if (beforeNode == null)
                throw new ArgumentException("The beforeNode cannot be NULL");

            var n = new Node<T>(value);
            if (ReferenceEquals(First, beforeNode))
            {
                return AddFirst(value);
            }

            var tmp = FindPrev(beforeNode);

            if (tmp != null)
            {
                n.Next = tmp.Next;
                tmp.Next = n;
            }
            else
                throw new Exception("The specified node is not part of this list");
            Lenght++;
            return n;
        }

        public Node<T> FindNode(T value)
        {
            var tmp = First;
            while (tmp != null)
            {
                if (tmp.Value.Equals(value))
                    return tmp;


                tmp = tmp.Next;
            }

            return tmp;
        }
        public Node<T> FindNde(int value)
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


        private Node<T> FindPrev(Node<T> n)
        {
            var tmp = First;

            while (tmp != null && !ReferenceEquals(tmp.Next, n))
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
