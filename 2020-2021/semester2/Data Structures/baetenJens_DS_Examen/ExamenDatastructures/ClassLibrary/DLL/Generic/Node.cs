
namespace ClassLibrary.DLL.Generic
{
    /// <summary>
    /// Deze klasse NIET aanpassen !!!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        private Node<T> next, prev;

        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; internal set; }

        /// <summary>
        /// While setting the Next, we always assure that that node points also to this node
        /// </summary>
        public Node<T> Next
        {
            get
            {
                return next;
            }
            internal set
            {
                this.next = value;
                if (value != null && !ReferenceEquals(value.Prev, this))
                    value.Prev = this;
            }
        }

        /// <summary>
        /// While setting the Previous, we always assure that that node points also to this node
        /// </summary>
        public Node<T> Prev
        {
            get
            {
                return prev;
            }
            internal set
            {
                prev = value;
                if (value != null && !ReferenceEquals(value.Next, this))
                    prev.Next = this;
            }
        }

        

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
