namespace DataStructures.LinkedList
{
    public class SinglyLinkedList<T>
    {
        public SinlgyLinkedListNode<T>? Head { get; set; }
        public SinlgyLinkedListNode<T>? Tail { get; set; } 
        public int Count { get; set; }
        private bool isEmpty => Count == 0;

        public void AddFirst(T value)
        {
            var newNode = new SinlgyLinkedListNode<T>(value)
            {
                Next = Head
            };

            Head = newNode;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            var newNode = new SinlgyLinkedListNode<T>(value);

            if (isEmpty)
            {
                Head = newNode;
            }
            else
            {
                Tail!.Next = newNode;
            }

            Tail = newNode;
            Count++;
        }

        public void RemoveFirst()
        {
            if(isEmpty)
            {
                throw new InvalidOperationException("The operation is invalid.");
            }

            Head = Head!.Next;

            if(Count == 1)
            {
                Tail = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if(isEmpty)
            {
                throw new InvalidOperationException("The operation is invalid.");
            }
            if(Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                var currentNode = Head;
                while(currentNode!.Next != Tail)
                {
                    currentNode = currentNode!.Next;
                }
                currentNode.Next = null;
                Tail = currentNode;
            }

            Count--;
        }
    }
}
