using Algorithms;
using System;
using System.IO;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramRecursionTest
    {
        [Fact]
        public void CountDown_ShouldReturnText_WhenSendATermToGoThrough()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                var program = new Program();
                program.CountDown(3);

                Assert.Equal(" 3 2 1", sw.ToString());
            }
        }

        [Fact]
        public void Factorial_ShouldReturnSix_WhenThreeWasGiven()
        {
            var program = new Program();
            var result = program.Factorial(3);

            Assert.Equal(6, result);
        }

        [Fact]
        public void Factorial_ShouldReturnTwentyFour_WhenFourWasGiven()
        {
            var program = new Program();
            var result = program.Factorial(4);

            Assert.Equal(24, result);
        }
    }
}
