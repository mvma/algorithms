using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramQuickSortTest
    {
        [Fact]
        public void QuickSort_ShouldReturnSortedArray_WhenGivenANonSortedOne()
        {
            var array = new int[] { 4, 2, 3, 1 };

            var program = new Program();
            var sortedArr = program.QuickSort<int>(array, 0, 3);

            Assert.True(sortedArr[0] == 1);
            Assert.True(sortedArr[1] == 2);
            Assert.True(sortedArr[2] == 3);
            Assert.True(sortedArr[3] == 4);
        }

        [Fact]
        public void QuickSort_ShouldReturnSortedArray_WhenGivenAnAlreadySortedArray()
        {
            var array = new int[] { 1, 2, 3, 4 };

            var program = new Program();
            var sortedArr = program.QuickSort(array, 0, 3);

            Assert.True(sortedArr[0] == 1);
            Assert.True(sortedArr[1] == 2);
            Assert.True(sortedArr[2] == 3);
            Assert.True(sortedArr[3] == 4);
        }
    }
}
