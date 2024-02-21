namespace Algorithms.Sorting
{
    public static class Sort<T> where T : IComparable
    {
        /// <summary>
        /// Sorts an one-dimensional array using bubble sort.
        /// </summary>
        /// <param name="array">The one-dimensional array to sort.</param>
        public static void BubbleSort(T[] array)
        {
            var n = array.Length;
            for (var i = 0; i < n - 1; i++)
            {
                for (var j = 0; j < n - i - 1; j++)
                {
                    if (array[j + 1].CompareTo(array[j]) < 0)
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
                }
            }
        }
        /// <summary>
        /// Sorts an one-dimensional array using selection sort.
        /// </summary>
        /// <param name="array">The one-dimensional array to sort.</param>
        /// <exception cref="NotSupportedException"></exception>
        public static void SelectionSort(T[] array)
        {
            throw new NotSupportedException();
        }
    }
}
