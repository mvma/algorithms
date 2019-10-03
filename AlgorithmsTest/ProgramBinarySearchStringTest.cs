using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramBinarySearchStringTest
    {
        [Fact]
        public void BinarySearchString_ShouldReturnPositionThreeAndSteps4_WhenSendArrayWithTargetAtPositionThreeAndNineLenght()
        {
            var array = new string[] { "adriana", "adrian", "adriano", "beta", "beti", "beto", "marcus", "marck", "mark" };

            var program = new Program();
            var (position, steps) = program.BinarySearchString(array, "beta");

            Assert.Equal(3, position);
            Assert.Equal(4, steps);
        }
    }
}
