using Xunit;
using Sample.Services;
namespace Sample.UnitTests.Services
{
    public class SampleService_IsTrueShould
    {
        [Fact]
        public void IsTrue_InputIs1_ReturnFalse()
        {
            var sampleService = new SampleService();
            bool result = sampleService.IsTrue(1);
            Assert.False(result, "1 should not be true");
        }
    }
}