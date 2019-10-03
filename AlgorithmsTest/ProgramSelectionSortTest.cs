using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramSelectionSortTest
    {
        [Fact]
        public void SelectionSort_ShouldReturnSortedArray_WhenGivenANonSortedOne()
        {
            var array = new int[] { 4, 2, 3, 1 };

            var program = new Program();
            var sortedArr = program.SelectionSort(array);

            Assert.True(sortedArr[0] == 1);
            Assert.True(sortedArr[1] == 2);
            Assert.True(sortedArr[2] == 3);
            Assert.True(sortedArr[3] == 4);
        }

        [Fact]
        public void SelectionSort_ShouldReturnSortedArray_WhenGivenAnAlreadySortedArray()
        {
            var array = new int[] { 1, 2, 3, 4 };

            var program = new Program();
            var sortedArr = program.SelectionSort(array);

            Assert.True(sortedArr[0] == 1);
            Assert.True(sortedArr[1] == 2);
            Assert.True(sortedArr[2] == 3);
            Assert.True(sortedArr[3] == 4);
        }
    }
}
