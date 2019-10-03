using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramBinarySearchStringRecursivelyTest
    {
        [Fact]
        public void ProgramBinarySearchStringRecursively_ShouldReturnPositionThreeAndSteps4_WhenSendArrayWithTargetAtPositionThreeAndNineLenght()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20, 23, 24 };

            var program = new Program();
            var position = program.BinarySearchTreeFromScratchRecursively(array, 4, 0, array.Length - 1);

            Assert.Equal(3, position);
        }

        [Fact]
        public void ProgramBinarySearchStringRecursively_ShouldReturnPositionMinusOne_WhenSendArrayWithoutTheExpectedTarget()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20 };

            var program = new Program();
            var position = program.BinarySearchTreeFromScratchRecursively(array, 21, 0, array.Length - 1);

            Assert.Equal(-1, position);
        }
    }
}
