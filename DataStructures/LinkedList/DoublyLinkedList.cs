namespace DataStructures.LinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T>? Head { get; set; }
        public DoublyLinkedListNode<T>? Tail { get; set; }
        public int Count { get; set; }
        private bool isEmpty => Count == 0;

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);

            if(isEmpty)
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
            
            if(isEmpty)
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
            if (isEmpty)
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
            if (isEmpty)
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
