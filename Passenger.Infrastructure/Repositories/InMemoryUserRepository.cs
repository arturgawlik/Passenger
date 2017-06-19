using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;

namespace Passenger.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        public static ISet<User> _useres = new HashSet<User>
        {
            new User("user1@op.pl", "hufcio321", "tajneHasl123o", "32121234dqqwdq"),
            new User("user2@op.pl", "hufcio123", "tajneHaslo321", "3214dqq543wdq"),
            new User("mail@oppl", "hufciaszek", "passswwwd", "salttttasda")
        };
        public async Task AddAsync(User user)
        {
            await Task.FromResult(_useres.Add(user));
        }

        public async Task<User> GetAsync(Guid id) => await Task.FromResult(_useres.SingleOrDefault(x => x.Id == id));

        public async Task<User> GetAsync(string email) => await Task.FromResult(_useres.SingleOrDefault(x => x.Email == email.ToLowerInvariant()));

        public async Task<IEnumerable<User>> GetAllAsync() => await Task.FromResult(_useres);

        public async Task RemoveAsync(Guid id)
        {
            var user = await GetAsync(id);
            _useres.Remove(user);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(User user)
        {
            await Task.CompletedTask;
        }
    }
}