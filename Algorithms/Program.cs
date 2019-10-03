using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public (int? position, int steps) BinarySearch(int[] list, int target)
        {
            var steps = 0;
            var low = 0;
            var high = list.Length - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = list[mid];
                steps++;

                if (guess == target) return (mid, steps);

                if (guess > target)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return (null, steps);
        }

        public (int? position, int steps) BinarySearchString(string[] list, string target)
        {
            var steps = 0;
            var low = 0;
            var high = list.Length - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = list[mid];
                steps++;

                if (guess == target) return (mid, steps);

                /*
                 * returns < 0 if guess is less than target
                 * returns 1 if guess is greater than target
                 */

                var result = string.Compare(guess, target, StringComparison.CurrentCultureIgnoreCase);

                if (result == 1)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return (null, steps);
        }

        // Selection sort performs a smaller number of swaps compared to bubble sort; 
        // therefore, even though both sorting methods are of O(N2), selection sort performs faster and more efficiently!

        // n * (n - 1) / 2
        public int[] SelectionSort(int[] arr)
        {
            for (var i = 0; i <= arr.Length - 1; i++)
            {
                var smallestIndex = i;
                for (var j = i + 1; j <= arr.Length - 1; j++)
                    if (arr[j] < arr[smallestIndex])
                        smallestIndex = j;

                var temp = arr[smallestIndex];
                arr[smallestIndex] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

        public int[] BubleSort(int[] arr)
        {
            bool noSwap = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (noSwap) break;

                noSwap = true;

                for (int j = 0; j < arr.Length - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                        noSwap = false;
                    }
            }

            return arr;
        }

        public void CountDown(int term)
        {
            if (term == 0) return;

            Console.Write(" ");
            Console.Write(term);

            CountDown(term - 1);
        }

        public int Factorial(int n)
        {
            if (n == 1) return n;

            return n * Factorial(n - 1);
        }

        public byte[] ReadChunk()
        {
            // the txt file was encoded using UTF8 - BOM
            // the first 3 bytes will be 0xEF, 0xBB and 0xBF
            var chunk = new byte[7];

            using (var fs = File.OpenRead(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.txt")))
            {
                int r = 0;

                while (r < 7)
                {
                    int n = fs.Read(chunk, r, 1);

                    if (n == 0) break;

                    r += n;
                }
            }

            return chunk;
        }

        public int Sum(Span<int> arr)
        {
            if (arr.Length == 1) return arr[0];

            return arr[0] + Sum(arr.Slice(1, arr.Length - 1));
        }

        public int Sumv2(int[] arr, int n)
        {
            if (n == 0) return arr[0];

            return arr[n] + Sumv2(arr, n - 1);
        }

        public int Count(Span<int> arr)
        {
            if (arr.Length == 1) return 1;

            return 1 + Count(arr.Slice(1, arr.Length - 1));
        }

        public int Countv2(int n)
        {
            if (n == 1) return 1;

            return 1 + Countv2(n - 1);
        }

        public int Max(Span<int> arr)
        {
            if (arr.Length == 1) return arr[0];

            return Math.Max(arr[0], Max(arr.Slice(1, arr.Length - 1)));
        }

        public int Maxv2(int[] arr, int n)
        {
            if (n == 0) return arr[0];

            return Math.Max(arr[n], Maxv2(arr, n - 1));
        }

        public int BinarySearchTreeFromScratch(int[] arr, int term)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = 0;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (arr[mid] == term) return mid;

                if (arr[mid] > term)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }

        public int BinarySearchTreeFromScratchRecursively(int[] arr, int term, int start, int end)
        {
            if (end < start) return -1;

            int mid = (start + end) / 2;

            if (term == arr[mid]) return mid;

            if (arr[mid] > term)
                return BinarySearchTreeFromScratchRecursively(arr, term, start, (mid - 1));
            else
                return BinarySearchTreeFromScratchRecursively(arr, term, (mid + 1), end);
        }

        public int[] QuickSort(int[] arr, int start, int end)
        {
            if (start >= end) return arr;

            int pivot = arr[(start + end) / 2];

            int i = start;
            int j = end;

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;

                while (arr[j] > pivot)
                    j--;

                if (i <= j)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;

                    i++;
                    j--;
                }
            }

            QuickSort(arr, start, i - 1);
            QuickSort(arr, i, end);

            return arr;
        }

        public T[] QuickSort<T>(T[] arr, int start, int end)
        {
            if (start >= end) return arr;

            T pivot = arr[(start + end) / 2];

            int i = start;
            int j = end;

            while (i <= j)
            {
                while (Comparer<T>.Default.Compare(pivot, arr[i]) > 0)
                    i++;

                while (Comparer<T>.Default.Compare(arr[j], pivot) > 0)
                    j--;

                if (i <= j)
                {
                    T tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;

                    i++;
                    j--;
                }
            }

            QuickSort(arr, start, i - 1);
            QuickSort(arr, i, end);

            return arr;
        }
    }
}