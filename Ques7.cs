using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MockRepositoryTest
{
    public class User
    {
        public string Name { get; set; }
    }

    public interface IUserRepository
    {
        void AddUser(User user);
    }

    public class UserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public void RegisterUser(User user)
        {
            repository.AddUser(user);
        }
    }

    [TestClass]
    public class UserServiceTests
    {
        [TestMethod]
        public void RegisterUser_CallsAddUserOnce()
        {
            var mockRepo = new Mock<IUserRepository>();
            var service = new UserService(mockRepo.Object);

            var user = new User { Name = "John" };

            service.RegisterUser(user);

            mockRepo.Verify(r => r.AddUser(It.IsAny<User>()), Times.Once);
        }
    }
}