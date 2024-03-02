using System.Collections.Concurrent;

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
        public static void SelectionSort(T[] array)
        {
            var n = array.Length;
            for(var i = n - 1; i > 0; i--)
            {
                var maxIndex = 0;
                for (var j = 1; j <= i; j++)
                {
                    if (array[maxIndex].CompareTo(array[j]) < 0)
                    {
                        maxIndex = j;
                    }
                }
                (array[maxIndex], array[i]) = (array[i], array[maxIndex]);       
            }
        }

        /// <summary>
        /// Sorts an one-dimensional array using insertion sort.
        /// </summary>
        /// <param name="array">The one-dimensional array to sort.</param>
        public static void InsertionSort(T[] array)
        {
            var n = array.Length;
            for(var i = 1; i < n; i++)
            {
                var currentElement = array[i];
                int j;
                for (j = i; j > 0 && (array[j - 1].CompareTo(currentElement) > 0); j--)
                {
                    array[j] = array[j - 1];
                }
                array[j] = currentElement;
            }
        }

        /// <summary>
        /// Sorts an one-dimensional array using shell sort.
        /// </summary>
        /// <param name="array">The one-dimensional array to sort.</param>
        public static void ShellSort(T[] array)
        {
            var n = array.Length;
            var gap = 1;
            while(gap < n/3)
            {
                gap = 3 * gap + 1;
            }
            while(gap > 0)
            {
                for (var i = gap; i < n; i++)
                {
                    for(var j = i; j >= gap && array[j].CompareTo(array[j - gap]) < 0; j -= gap)
                    {
                        (array[j], array[j - gap]) = (array[j - gap], array[j]);
                    }
                }
                gap /= 3;
            }
        }

        /// <summary>
        /// Sorts an one-dimensional array using merge sort.
        /// </summary>
        /// <param name="array">The one-dimensional array to sort.</param>
        public static void MergeSort(T[] array)
        {
            var n = array.Length;
            MSort(array, 0, n - 1);
        }

        private static void MSort(T[] array, int left, int right)
        {
            if (left < right)
            {
                var mid = (left + right) / 2;
                MSort(array, left, mid);
                MSort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }    
        }

        private static void Merge(T[] array, int left, int mid, int right)
        {
            var k = left;
            var i = left;
            var j = mid + 1;
            var auxArray = new T[array.Length];
            while (i <= mid && j <= right)
            {
                if (array[i].CompareTo(array[j]) < 0)
                {
                    auxArray[k] = array[i];
                    i++;
                }
                else
                {
                    auxArray[k] = array[j];
                    j++;
                }
                k++;
            }

            while(i <= mid)
            {
                auxArray[k] = array[i];
                i++;
                k++;
            }

            while(j <= right)
            {
                auxArray[k] = array[j];
                j++;
                k++;
            }

            for(var m = left; m <= right; m++)
            {
                array[m] = auxArray[m];
            }
        }

        /// <summary>
        /// Sorts an one-dimensional array using quick sort.
        /// </summary>
        /// <param name="array">The one-dimensional array to sort.</param>
        public static void QuickSort(T[] array)
        {
            var n = array.Length;
            QSort(array, 0, n - 1);
        }

        private static void QSort(T[] array, int left, int right)
        {
            if(left < right)
            {
                var pivot = Partition(array, left, right);
                QSort(array, left, pivot);
                QSort(array, pivot + 1, right);
            }
        }

        private static int Partition(T[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = array[left];
            while(true)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if(i >= j)
                {
                    return j;
                }

                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }
        }
    }
}
