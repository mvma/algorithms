using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramArrayCountTest
    {
        [Fact]
        public void Count_ShouldReturnFive_WhenGivenAnArrayWithFiveElements()
        {
            var array = new int[] { 1, 2, 3, 4, 2 };

            var program = new Program();
            var count = program.Count(array);

            Assert.Equal(5, count);
        }

        [Fact]
        public void Countv2_ShouldReturnFive_WhenGivenAnArrayWithFiveElements()
        {
            var array = new int[] { 1, 2, 3, 4, 2 };

            var program = new Program();
            var count = program.Countv2(array.Length);

            Assert.Equal(5, count);
        }
    }
}
