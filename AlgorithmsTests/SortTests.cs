using Algorithms.Sorting;
using Xunit;

namespace AlgorithmsTests
{
    public class SortTests
    {
        private void SortTest_CharArray(Action<char[]> sort)
        {
            // Arrange
            var array = new char[] { 'b', 'z', 'c', 't', 'a', 'f', 'x' };
            var expectedArray = new char[] { 'a', 'b', 'c', 'f', 't', 'x', 'z' };

            // Act
            sort(array);

            // Assert
            Assert.True(array.SequenceEqual(expectedArray));
        }

        private void SortTest_IntArray(int min, int max, Action<int[]> sort)
        {
            // Arrange 
            var random = new Random();
            var array = Enumerable.Repeat(0, max).Select(i => random.Next(min, max)).ToArray();
            var expectedArray = new int[array.Length];
            for (var i = 0; i < expectedArray.Length; i++)
            { expectedArray[i] = array[i]; }

            // Act
            sort(array);
            Array.Sort(expectedArray);

            // Assert
            Assert.True(array.SequenceEqual(expectedArray));
        }

        [Fact]
        public void RunSortTests()
        {
            // Bubble Sort
            SortTest_IntArray(0, 100, Sort<int>.BubbleSort);
            SortTest_CharArray(Sort<char>.BubbleSort);

            // Selection Sort.
        }
    }
}