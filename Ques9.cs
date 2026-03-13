using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiResponseTest
{
    public class ApiResponse
    {
        public string status { get; set; }
        public List<string> data { get; set; }
    }

    public class ApiService
    {
        public ApiResponse GetResponse()
        {
            return new ApiResponse
            {
                status = "success",
                data = new List<string> { "Item1", "Item2", "Item3" }
            };
        }
    }

    [TestClass]
    public class ApiServiceTests
    {
        [TestMethod]
        public void GetResponse_ShouldReturnValidResponseShape()
        {
            ApiService service = new ApiService();

            ApiResponse response = service.GetResponse();

            Assert.IsNotNull(response);
            Assert.AreEqual("success", response.status);
            Assert.IsNotNull(response.data);
            Assert.IsTrue(response.data.Count > 0);
        }
    }
}