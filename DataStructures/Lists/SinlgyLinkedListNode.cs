namespace DataStructures.Lists
{
    public class SinlgyLinkedListNode<T>
    {
        public SinlgyLinkedListNode(T value) => Value = value;

        public T Value { get; set; }

        public SinlgyLinkedListNode<T>? Next { get; set; }
    }
}
