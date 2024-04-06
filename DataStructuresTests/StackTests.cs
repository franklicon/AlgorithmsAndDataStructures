using DataStructures.Stack;
using Xunit;
using Xunit.Abstractions;

namespace DataStructuresTests
{
    public class StackTests
    {
        public StackTests(ITestOutputHelper output) => this.output = output;
        private readonly ITestOutputHelper output;

        [Fact]
        public void ArrayStack_IsEmpty_Test()
        {
            // Arrange
            var arrayStack = new ArrayStack<int>();

            // Assert
            Assert.True(arrayStack.IsEmpty);
        }

        [Fact]
        public void ArrayStack_Push_Test()
        {
            // Arrange
            var arrayStack = new ArrayStack<int>();

            // Act
            arrayStack.Push(1);

            // Assert
            Assert.False(arrayStack.IsEmpty);
            Assert.Equal(1, arrayStack.Count);
        }

        [Fact]
        public void ArrayStack_Peek_Test()
        {
            // Arrange
            var arrayStack = new ArrayStack<int>();

            // Act
            arrayStack.Push(1);
            var item = arrayStack.Peek();

            // Assert
            Assert.False(arrayStack.IsEmpty);
            Assert.Equal(1, item);
        }

        [Fact]
        public void ArrayStack_Pop_Test()
        {
            // Arrange
            var arrayStack = new ArrayStack<int>();

            // Act
            arrayStack.Push(1);
            arrayStack.Push(2);
            arrayStack.Push(3);
            var item = arrayStack.Pop();
            Print(arrayStack);

            // Assert
            Assert.Equal(2, arrayStack.Count);
            Assert.Equal(3, item);
        }

        [Fact]
        public void LinkedListStack_IsEmpty_Test()
        {
            // Arrange
            var linkedListStack = new LinkedListStack<int>();

            // Assert
            Assert.True(linkedListStack.IsEmpty);
        }

        [Fact]
        public void LinkedListStack_Push_Test()
        {
            // Arrange
            var linkedListStack = new LinkedListStack<int>();

            // Act
            linkedListStack.Push(1);

            // Assert
            Assert.False(linkedListStack.IsEmpty);
            Assert.Equal(1, linkedListStack.Count);
        }

        [Fact]
        public void LinkedListStack_Peek_Test()
        {
            // Arrange
            var linkedListStack = new LinkedListStack<int>();

            // Act
            linkedListStack.Push(1);
            var item = linkedListStack.Peek();

            // Assert
            Assert.False(linkedListStack.IsEmpty);
            Assert.Equal(1, item);
        }

        [Fact]
        public void LinkedListStack_Pop_Test()
        {
            // Arrange
            var linkedListStack = new LinkedListStack<int>();

            // Act
            linkedListStack.Push(1);
            linkedListStack.Push(2);
            linkedListStack.Push(3);
            var item = linkedListStack.Pop();
            Print(linkedListStack);

            // Assert
            Assert.Equal(2, linkedListStack.Count);
            Assert.Equal(3, item);
        }

        private void Print(dynamic stack)
        {
            if(stack is ArrayStack<int> || stack is LinkedListStack<int>)
            {
                foreach (var item in stack)
                {
                    output.WriteLine(item.ToString());
                }
            }       
        }
    }
}
