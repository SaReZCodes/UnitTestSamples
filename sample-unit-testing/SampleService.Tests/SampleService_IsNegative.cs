using Xunit;
using Sample.Services;

namespace Sample.UnitTests.Services
{
    public class SampleService_IsNegative
    {
        [Theory]
        [InlineData(2)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsNegative_ReturnTrue(int value)
        {
            var sampleService = new SampleService();
            bool result = sampleService.IsNegativeNumber(1);
            Assert.False(result, $"{value} should not be negative");
        }
    }
}
