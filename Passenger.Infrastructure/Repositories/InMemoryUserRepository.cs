using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Add(User user)
        {
            _useres.Add(user);
        }

        public User Get(Guid id) => _useres.Single(x => x.Id == id);

        public User Get(string email) 
        {
            if(_useres.Single(x => x.Email == email.ToLowerInvariant()) == null)
                throw new Exception("Email does not Exeist!");

            return _useres.Single(x => x.Email == email.ToLowerInvariant());
        }
        public IEnumerable<User> GetAll() => _useres;

        public void Remove(Guid id)
        {
            var user = Get(id);
            _useres.Remove(user);
        }

        public void Update(User user)
        {
        }
    }
}