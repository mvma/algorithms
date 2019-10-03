using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramArraySumTest
    {
        [Fact]
        public void Sum_ShouldReturnTwelve_WhenGivenNumbersThatTheSumResultsTwelve()
        {
            var array = new int[] { 1, 2, 3, 4, 2 };

            var program = new Program();
            var sum = program.Sum(array);

            Assert.Equal(12, sum);
        }

        [Fact]
        public void Sumv2_ShouldReturnTwelve_WhenGivenNumbersThatTheSumResultsTwelve()
        {
            var array = new int[] { 1, 2, 3, 4, 2 };

            var program = new Program();
            var sum = program.Sumv2(array, array.Length - 1);

            Assert.Equal(12, sum);
        }
    }
}
