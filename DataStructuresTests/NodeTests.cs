using Xunit;
using DataStructures.Lists;
using Xunit.Abstractions;

namespace DataStructuresTests
{
    public class NodeTests
    {
        public NodeTests(ITestOutputHelper output) => this.output = output;

        private readonly ITestOutputHelper output;
    
        [Fact]
        public void NodeTest_Int()
        {
            // Arrange
            var firstNode = new Node<int>(5);
            var secondNode = new Node<int>(6);
           
            // Act
            firstNode.Next = secondNode;
            Print(firstNode);

            // Assert
            Assert.Equal(6, firstNode.Next.Value);
        }

        private void Print(Node<int> node)
        {
            while (node != null)
            {
                output.WriteLine(node.Value.ToString());
                node = node.Next;
            }
        }
    }
}
