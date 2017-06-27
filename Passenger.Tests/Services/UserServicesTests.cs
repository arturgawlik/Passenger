using System;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using Moq;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.Services;
using Xunit;
using System.Collections.Generic;

namespace Passenger.Tests.Services
{
    public class UserServicesTests
    {
        [Fact]
        public async Task register_async_should_invoke_add_async_on_repository()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            var mapperMock = new Mock<IMapper>();

            var userService = new UserService(userRepositoryMock.Object, mapperMock.Object);
            await userService.RegisterAsync("user321@email.com", "user3213", "secret321321");

            userRepositoryMock.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);

        }

        [Fact]
        public async Task trying_to_register_user_that_have_email_witch_is_already_in_use_should_trow_exeption()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            var mapperMock = new Mock<IMapper>();
            
            var userService = new UserService(userRepositoryMock.Object, mapperMock.Object);
            await userService.RegisterAsync("test@email.com", "test", "password");
            var a = await userService.GetAsync("test@email.com");

            //await Assert.ThrowsAnyAsync<Exception>(() => userService.RegisterAsync("user1@op.pl", "test", "password"));
        }
    }
}