namespace DataStructures.LinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T>? Head { get; set; }
        public DoublyLinkedListNode<T>? Tail { get; set; }
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);

            if(IsEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Head!.Previous = newNode;
                newNode.Next = Head;
                Head = newNode;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            
            if(IsEmpty)
            {
                Head = newNode;
            }
            else
            {
                Tail!.Next = newNode;
                newNode.Previous = Tail;
            }
            Tail = newNode;
            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("The operation is invalid.");
            }

            Head = Head!.Next;

            if(Head is null)
            {
                Tail = null;
            }
            else
            {
                Head.Previous = null;
            }
           
            Count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("The operation is invalid.");
            }

            Tail = Tail!.Previous;

            if(Tail is null)
            {
                Head = null;
            }
            else
            {
                Tail.Next = null;
            }
           
            Count--;
        }
    }
}
