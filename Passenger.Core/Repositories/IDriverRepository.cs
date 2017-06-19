using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Passenger.Core.Domain;

namespace Passenger.Core.Repositories
{
    public interface IDriverRepository
    {
         Task AddAsync(Driver driver);
         Task<Driver> GetAsync(Guid id);
         Task<IEnumerable<Driver>> GetAllAsync();
         Task UpdateAsync(Driver driver);
    }
}