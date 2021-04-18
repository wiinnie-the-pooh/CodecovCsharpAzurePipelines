using Xunit;

namespace CodecovCsharpAzurePipelines.Tests
{
    public class FullyCoveredTypeTest
    {
        [InlineData(Options.Yes)]
        [InlineData(Options.No)]
        [InlineData(Options.Maybe)]
        [Theory]
        public void GetResult_ValidOptions_ReturnsNonEmptyResult(Options options)
        {
            // Arrange
            var type = new FullyCoveredType();

            // Act
            var result = type.GetResult(options);

            // Assert
            var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(result);
            Assert.False(isNullOrWhiteSpace);
        }
    }
}
