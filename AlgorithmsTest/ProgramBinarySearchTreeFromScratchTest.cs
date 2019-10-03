using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramBinarySearchTreeFromScratchTest
    {
        [Fact]
        public void ProgramBinarySearchTreeFromScratch_ShouldReturnPositionThreeAndSteps4_WhenSendArrayWithTargetAtPositionThreeAndNineLenght()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20, 23, 24 };

            var program = new Program();
            var position = program.BinarySearchTreeFromScratch(array, 4);
            
            Assert.Equal(3, position);
        }

        [Fact]
        public void ProgramBinarySearchTreeFromScratch_ShouldReturnPositionMinusOne_WhenSendArrayWithoutTheExpectedTarget()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 10, 20 };

            var program = new Program();
            var position = program.BinarySearchTreeFromScratch(array, 21);

            Assert.Equal(-1, position);
        }
    }
}
