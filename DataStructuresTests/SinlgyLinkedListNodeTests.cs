using Xunit;
using DataStructures.LinkedList;
using Xunit.Abstractions;

namespace DataStructuresTests
{
    public class SinlgyLinkedListNodeTests
    {
        public SinlgyLinkedListNodeTests(ITestOutputHelper output) => this.output = output;

        private readonly ITestOutputHelper output;
    
        [Fact]
        public void SinlgyLinkedListNodeTest_Int()
        {
            // Arrange
            var firstNode = new SinlgyLinkedListNode<int>(5);
            var secondNode = new SinlgyLinkedListNode<int>(6);
           
            // Act
            firstNode.Next = secondNode;
            Print(firstNode);

            // Assert
            Assert.Equal(6, firstNode.Next.Value);
        }

        private void Print(SinlgyLinkedListNode<int> node)
        {
            while (node != null)
            {
                output.WriteLine(node.Value.ToString());
                node = node.Next;
            }
        }
    }
}
