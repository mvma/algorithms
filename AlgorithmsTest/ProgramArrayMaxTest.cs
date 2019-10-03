using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramArrayMaxTest
    {
        [Fact]
        public void Max_ShouldReturnFive_WhenGivenAnArrayWithFiveElementsFromOneToFive()
        {
            var array = new int[] { 1, 2, 3, 5, 4 };

            var program = new Program();
            var max = program.Max(array);

            Assert.Equal(5, max);
        }

        [Fact]
        public void Max_ShouldReturnTwenty_WhenGivenAnArrayWithFourElementsWhereTwentyIsTheMaximum()
        {
            var array = new int[] { 20, 18, 0, 1 };

            var program = new Program();
            var max = program.Max(array);

            Assert.Equal(20, max);
        }

        [Fact]
        public void Maxv2_ShouldReturnFive_WhenGivenAnArrayWithFiveElementsFromOneToFive()
        {
            var array = new int[] { 1, 2, 3, 5, 4 };

            var program = new Program();
            var max = program.Maxv2(array, array.Length - 1);

            Assert.Equal(5, max);
        }

        [Fact]
        public void Maxv2_ShouldReturnTwenty_WhenGivenAnArrayWithFourElementsWhereTwentyIsTheMaximum()
        {
            var array = new int[] { 20, 18, 0, 1 };

            var program = new Program();
            var max = program.Maxv2(array, array.Length - 1);

            Assert.Equal(20, max);
        }
    }
}
