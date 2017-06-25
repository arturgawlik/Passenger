using System.Threading.Tasks;
<<<<<<< HEAD
using AutoMapper;
using FluentAssertions;
using Moq;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.Services;
=======
using FluentAssertions;
>>>>>>> d69ef3b50bbd70b51db4b0add5a804ddb97549d5
using Xunit;

namespace Passenger.Tests.Services
{
    public class UserServicesTests
    {
        [Fact]
<<<<<<< HEAD
        public async Task register_async_should_invoke_add_async_on_repository()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            var mapperMock = new Mock<IMapper>();

            var userService = new UserService(userRepositoryMock.Object, mapperMock.Object);
            await userService.RegisterAsync("user321@email.com", "user3213", "secret321321");

            userRepositoryMock.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);

=======
        public async Task Test()
        {
            true.ShouldBeEquivalentTo(false);
>>>>>>> d69ef3b50bbd70b51db4b0add5a804ddb97549d5
        }
    }
}