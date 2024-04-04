using DataStructures.LinkedList;
using Xunit;

namespace DataStructuresTests
{
    public class SinglyLinkedListTest
    {
        [Fact]
        public void SinglyLinkedList_AddFirst_Test()
        {
            // Arrange
            var singlyLinkedList = new SinglyLinkedList<int>();

            // Act
            singlyLinkedList.AddFirst(1);

            // Assert
            Assert.Equal(singlyLinkedList.Tail, singlyLinkedList.Head);
        }

        [Fact]
        public void SinglyLinkedList_AddLast_Test()
        {
            // Arrange
            var singlyLinkedList = new SinglyLinkedList<int>();

            // Act
            singlyLinkedList.AddLast(1);

            // Assert
            Assert.Equal(singlyLinkedList.Tail, singlyLinkedList.Head);
        }

        [Fact]
        public void SinglyLinkedList_AddFirstAndLast_Test()
        {
            // Arrange
            var singlyLinkedList = new SinglyLinkedList<int>();

            // Act
            singlyLinkedList.AddFirst(1);
            singlyLinkedList.AddFirst(0);
            singlyLinkedList.AddLast(2);
            singlyLinkedList.AddLast(3);

            // Assert
            Assert.Equal(0, singlyLinkedList.Head!.Value);
            Assert.Equal(3, singlyLinkedList.Tail!.Value);
            Assert.Equal(1, singlyLinkedList.Head.Next!.Value);
        }

        [Fact]
        public void SinglyLinkedList_RemoveFirst_Test_Exception()
        {
            // Arrage
            var singlyLinkedList = new SinglyLinkedList<int> ();
            var exceptionType = typeof(InvalidOperationException);
            var expectedMessage = "The operation is invalid.";

            // Act
            var ex = Record.Exception(singlyLinkedList.RemoveFirst);

            // Arrange
            Assert.NotNull(ex);
            Assert.IsType(exceptionType, ex);
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void SinglyLinkedList_RemoveFirst_Test()
        {
            // Arrage
            var singlyLinkedList = new SinglyLinkedList<int>();
           

            // Act
            singlyLinkedList.AddFirst(2);
            singlyLinkedList.AddFirst(1);
            singlyLinkedList.AddFirst(0);
            singlyLinkedList.RemoveFirst();

            // Arrange
            Assert.Equal(1, singlyLinkedList.Head!.Value);
        }

        [Fact]
        public void SinglyLinkedList_RemoveLast_Test_Exception()
        {
            // Arrage
            var singlyLinkedList = new SinglyLinkedList<int>();
            var exceptionType = typeof(InvalidOperationException);
            var expectedMessage = "The operation is invalid.";

            // Act
            var ex = Record.Exception(singlyLinkedList.RemoveLast);

            // Arrange
            Assert.NotNull(ex);
            Assert.IsType(exceptionType, ex);
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void SinglyLinkedList_RemoveLast_Test()
        {
            // Arrage
            var singlyLinkedList = new SinglyLinkedList<int>();


            // Act
            singlyLinkedList.AddFirst(2);
            singlyLinkedList.AddFirst(1);
            singlyLinkedList.AddFirst(0);
            singlyLinkedList.RemoveLast();

            // Arrange
            Assert.Equal(1, singlyLinkedList.Tail!.Value);
            Assert.Equal(2, singlyLinkedList.Count);
        }
    }
}
