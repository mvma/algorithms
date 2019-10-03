using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramBinarySearchTest
    {
        [Fact]
        public void BinarySearch_ShouldReturnPositionThreeAndSteps4_WhenSendArrayWithTargetAtPositionThreeAndNineLenght()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20, 23, 24 };

            var program = new Program();
            var (position, steps) = program.BinarySearch(array, 4);

            Assert.Equal(3, position);
            Assert.Equal(4, steps);
        }

        [Fact]
        public void BinarySearch_ShouldReturnPositionNull_WhenSendArrayWithoutTheExpectedTarget()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20 };

            var program = new Program();
            var (position, unused) = program.BinarySearch(array, 21);

            Assert.Null(position);
        }

        [Fact]
        public void BinarySearch_ShouldReturnSteps3_WhenSendArrayWithSevenLenghtAndTargetGreatherThanLast()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20 };

            var program = new Program();
            var (position, steps) = program.BinarySearch(array, 21);

            Assert.Equal(3, steps);
        }
    }
}
