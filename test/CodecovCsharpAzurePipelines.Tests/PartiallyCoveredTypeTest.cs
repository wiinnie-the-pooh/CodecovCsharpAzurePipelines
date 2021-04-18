using Xunit;

namespace CodecovCsharpAzurePipelines.Tests
{
    public class PartiallyCoveredTypeTest
    {
        [InlineData(Options.Maybe)]
        [Theory]
        public void GetResult_ValidOptions_ReturnsNonEmptyResult(Options options)
        {
            // Arrange
            var type = new PartiallyCoveredType();

            // Act
            var result = type.GetResult(options);

            // Assert
            var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(result);
            Assert.False(isNullOrWhiteSpace);
        }
    }
}
