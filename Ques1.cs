using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AsyncExceptionTest
{
    public class SampleService
    {
        public async Task ThrowErrorAsync()
        {
            await Task.Delay(100);
            throw new InvalidOperationException("Error occurred");
        }
    }

    [TestClass]
    public class SampleServiceTests
    {
        [TestMethod]
        public async Task ThrowErrorAsync_ShouldThrowException()
        {
            var service = new SampleService();

            await Assert.ThrowsExceptionAsync<InvalidOperationException>(
                async () => await service.ThrowErrorAsync()
            );
        }
    }
}