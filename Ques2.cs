using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AsyncMethodTest
{
    // Service Class
    public class NumberService
    {
        // Async method returning a list of integers
        public async Task<List<int>> GetNumbersAsync()
        {
            await Task.Delay(100); // simulate async work

            return new List<int> { 10, 20, 30, 40, 50 };
        }
    }

    // Test Class
    public class NumberServiceTests
    {
        [Fact]
        public async Task GetNumbersAsync_ReturnsCorrectCount()
        {
            // Arrange
            var service = new NumberService();

            // Act
            List<int> numbers = await service.GetNumbersAsync();

            // Assert
            Assert.NotNull(numbers);
            Assert.Equal(5, numbers.Count);
        }
    }
}