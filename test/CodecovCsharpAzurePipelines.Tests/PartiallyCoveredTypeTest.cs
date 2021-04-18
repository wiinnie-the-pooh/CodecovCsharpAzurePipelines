using System;
using Xunit;

namespace CodecovCsharpAzurePipelines.Tests
{
    public class PartiallyCoveredTypeTest
    {
        [InlineData(Options.Yes)]
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

        [Fact]
        public void GetResult_UnknownOption_Throws()
        {
            // Arrange
            var type = new PartiallyCoveredType();

            // Act & Assert
            Assert.Throws<NotImplementedException>(() => type.GetResult(Options.Unknown));
        }
    }
}
