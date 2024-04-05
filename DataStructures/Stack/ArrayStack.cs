namespace DataStructures.Stack
{
    public class ArrayStack<T>
    {
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;
        private T[] stack;
        private const int defaultCapacity = 10;

        public ArrayStack()
        {
            stack = new T[defaultCapacity];
        }

        public ArrayStack(int capacity)
        {
            stack = new T[capacity];
        }

        public void Push(T item)
        {
            if(stack.Length == Count)
            {
                Array.Resize(ref stack, Count * 2);
            }

            stack[Count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return stack[--Count];
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return stack[Count - 1];
        }
    }
}
