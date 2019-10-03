using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramBubleSortTest
    {
        [Fact]
        public void BubleSort_ShouldReturnSortedArray_WhenGivenANonSortedOne()
        {
            var array = new int[] { 4, 2, 3, 1 };

            var program = new Program();
            var sortedArr = program.BubleSort(array);

            Assert.True(sortedArr[0] == 1);
            Assert.True(sortedArr[1] == 2);
            Assert.True(sortedArr[2] == 3);
            Assert.True(sortedArr[3] == 4);
        }

        [Fact]
        public void BubleSort_ShouldReturnSortedArray_WhenGivenAnAlreadySortedArray()
        {
            var array = new int[] { 1, 2, 3, 4 };

            var program = new Program();
            var sortedArr = program.BubleSort(array);

            Assert.True(sortedArr[0] == 1);
            Assert.True(sortedArr[1] == 2);
            Assert.True(sortedArr[2] == 3);
            Assert.True(sortedArr[3] == 4);
        }
    }
}
