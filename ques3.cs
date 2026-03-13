using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AsyncGreetingTest
{
    // Service Class
    public class GreetingService
    {
        // Async method returning greeting after delay
        public async Task<string> GetGreetingAsync()
        {
            await Task.Delay(1000); // simulate delay
            return "Hello, Welcome!";
        }
    }

    // Test Class
    [TestClass]
    public class GreetingServiceTests
    {
        [TestMethod]
        public async Task GetGreetingAsync_ReturnsCorrectGreeting()
        {
            // Arrange
            GreetingService service = new GreetingService();

            // Act
            string result = await service.GetGreetingAsync();

            // Assert
            Assert.AreEqual("Hello, Welcome!", result);
        }
    }
}