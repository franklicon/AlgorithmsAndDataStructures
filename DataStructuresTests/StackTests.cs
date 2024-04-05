using DataStructures.LinkedList;
using DataStructures.Stack;
using Xunit;


namespace DataStructuresTests
{
    public class StackTests
    {
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

            // Assert
            Assert.Equal(2, arrayStack.Count);
            Assert.Equal(3, item);
        }
    }
}
