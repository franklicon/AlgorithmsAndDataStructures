using DataStructures.Lists;
using Xunit;

namespace DataStructuresTests
{
    public class DoublyLinkedListTest
    {
        [Fact]
        public void DoublyLinkedList_AddFirst_Test()
        {
            // Arrange
            var doublyLinkedList = new DoublyLinkedList<int>();

            // Act
            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddFirst(0);

            // Assert
            Assert.Equal(1, doublyLinkedList.Tail!.Value);
            Assert.Equal(0, doublyLinkedList.Head!.Value);
            Assert.Equal(0, doublyLinkedList.Tail!.Previous!.Value);
            Assert.Equal(1, doublyLinkedList.Head!.Next!.Value);
        }

        [Fact]
        public void DoublyLinkedList_AddLast_Test()
        {
            // Arrange
            var doublyLinkedList = new DoublyLinkedList<int>();

            // Act
            doublyLinkedList.AddLast(1);
            doublyLinkedList.AddLast(0);

            // Assert
            Assert.Equal(0, doublyLinkedList.Tail!.Value);
            Assert.Equal(1, doublyLinkedList.Head!.Value);
            Assert.Equal(1, doublyLinkedList.Tail!.Previous!.Value);
            Assert.Equal(0, doublyLinkedList.Head!.Next!.Value);
        }

        [Fact]
        public void DoublyLinkedList_AddFirstAndLast_Test()
        {
            // Arrange
            var doublyLinkedList = new DoublyLinkedList<int>();

            // Act
            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddFirst(0);
            doublyLinkedList.AddLast(2);
            doublyLinkedList.AddLast(3);

            // Assert
            Assert.Equal(0, doublyLinkedList.Head!.Value);
            Assert.Equal(2, doublyLinkedList.Tail!.Previous!.Value);
            Assert.Equal(1, doublyLinkedList.Head.Next!.Value);
        }

        [Fact]
        public void DoublyLinkedList_RemoveFirst_Test_Exception()
        {
            // Arrage
            var doublyLinkedList = new DoublyLinkedList<int>();
            var exceptionType = typeof(InvalidOperationException);
            var expectedMessage = "The operation is invalid.";

            // Act
            var ex = Record.Exception(doublyLinkedList.RemoveFirst);

            // Arrange
            Assert.NotNull(ex);
            Assert.IsType(exceptionType, ex);
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void DoublyLinkedList_RemoveFirst_Test()
        {
            // Arrage
            var doublyLinkedList = new DoublyLinkedList<int>();


            // Act
            doublyLinkedList.AddFirst(2);
            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddFirst(0);
            doublyLinkedList.RemoveFirst();

            // Arrange
            Assert.Equal(1, doublyLinkedList.Head!.Value);
            Assert.Null(doublyLinkedList.Head!.Previous);
        }

        [Fact]
        public void DoublyLinkedList_RemoveLast_Test_Exception()
        {
            // Arrage
            var doublyLinkedList = new DoublyLinkedList<int>();
            var exceptionType = typeof(InvalidOperationException);
            var expectedMessage = "The operation is invalid.";

            // Act
            var ex = Record.Exception(doublyLinkedList.RemoveLast);

            // Arrange
            Assert.NotNull(ex);
            Assert.IsType(exceptionType, ex);
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void DoublyLinkedList_RemoveLast_Test()
        {
            // Arrage
            var doublyLinkedList = new DoublyLinkedList<int>();


            // Act
            doublyLinkedList.AddFirst(2);
            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddFirst(0);
            doublyLinkedList.RemoveLast();
            doublyLinkedList.RemoveLast();

            // Arrange
            Assert.Equal(0, doublyLinkedList.Tail!.Value);
            Assert.Equal(1, doublyLinkedList.Count);
        }
    }
}
