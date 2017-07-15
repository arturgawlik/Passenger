using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Passenger.Api;
using Xunit;
using FluentAssertions;
using Passenger.Infrastructure.DTO;
using System.Net;
using System.Text;
using Passenger.Infrastructure.Commands.Users;

namespace Passenger.Tests.EndToEnd.Controllers
{
    public class UsersControllerTests : ControllerTestBase
    {
        [Fact]
        public async Task given_valid_email_user_should_exist()
        {
            var email = "user1@op.pl";
            var user = await GetUserAsync(email);
            user.Email.ShouldBeEquivalentTo(email);
        }

        [Fact]
        public async Task given_invalid_email_user_should_not_exist()
        {
            var email = "user1000@op.pl";
            var response = await Client.GetAsync($"users/{email}");
            response.StatusCode.ShouldBeEquivalentTo(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task given_uniqiue_email_user_should_be_created()
        {
            var command = new CreateUser 
            {
                Email = "test@email.com",
                UserName = "test",
                Password = "secret"
            };
            var payload = GetPayload(command);
            var response = await Client.PostAsync("users", payload);
            response.StatusCode.ShouldBeEquivalentTo(HttpStatusCode.Created);
            response.Headers.Location.ToString().ShouldBeEquivalentTo($"users/{command.Email}");

            var user = await GetUserAsync(command.Email);
            user.Email.ShouldBeEquivalentTo(command.Email);

        }

        private async Task<UserDto> GetUserAsync(string email)
        {
            var response = await Client.GetAsync($"users/{email}");
            var responseString = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<UserDto>(responseString);
        }
    }
}