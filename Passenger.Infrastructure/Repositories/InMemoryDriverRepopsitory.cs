using System;
using System.Collections.Generic;
using Passenger.Core.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace Passenger.Core.Repositories
{
    public class InMemoryDriverRepopsitory : IDriverRepository
    {
        private static ISet<Driver> _drivers = new HashSet<Driver>();
        public async Task AddAsync(Driver driver)
        {
            _drivers.Add(driver);
            await Task.CompletedTask;
        }

        public async Task<Driver> GetAsync(Guid id) => await Task.FromResult(_drivers.SingleOrDefault(x => x.UserId == id));

        public async Task<IEnumerable<Driver>> GetAllAsync() => await Task.FromResult(_drivers);

        public async Task UpdateAsync(Driver driver)
        {
            await Task.CompletedTask;
        }
    }
}