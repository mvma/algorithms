using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ProgramReadChunkTest
    {
        [Fact]
        public void ReadChunk_ShouldReturnBOMIdentifier_WhenEncondedLikeUTF8BOM()
        {
            var program = new Program();
            var chunk = program.ReadChunk();

            Assert.Equal(0xEF, chunk[0]);
            Assert.Equal(0xBB, chunk[1]);
            Assert.Equal(0xBF, chunk[2]);
        }
    }
}
