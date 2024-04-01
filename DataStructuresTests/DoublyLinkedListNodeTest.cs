using DataStructures.Lists;
using Xunit;

namespace DataStructuresTests
{
    public class DoublyLinkedListNodeTest
    {
        [Fact]
        public void DoublyLinkedListNodeTest_Int()
        {
            // Arrange
            var firstNode = new DoublyLinkedListNode<int>(5);
            var secondNode = new DoublyLinkedListNode<int>(6);

            // Act
            firstNode.Next = secondNode;
            secondNode.Previous = firstNode;

            // Assert
            Assert.Equal(6, firstNode.Next.Value);
            Assert.Equal(5, secondNode.Previous.Value);
        }
    }
}
