
namespace ClassLibrary.Tree.Binary.Generic
{
    /// <summary>
    /// Deze klasse NIET aanpassen !!!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public Node(T value) 
        {
            Value = value;
        }

        public T Value { get; internal set; }

        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
