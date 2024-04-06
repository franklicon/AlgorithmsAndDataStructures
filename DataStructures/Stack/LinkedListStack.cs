using System.Collections;

namespace DataStructures.Stack
{
    public class LinkedListStack<T> : IEnumerable<T>
    {
        public int Count => stack.Count;
        public bool IsEmpty => Count == 0;
        private readonly LinkedList<T> stack = new();

        public void Push(T item)
        {
            stack.AddFirst(item);
        }

        public T Pop()
        {
            if(IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var item = stack.First();
            stack.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return stack.First();
        }

        public IEnumerator<T> GetEnumerator()
        {
          return stack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
