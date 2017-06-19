using System;
using System.Threading.Tasks;
using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverReposiory;
        private readonly IMapper _mapper;
        
        public DriverService(IDriverRepository driverRepository, IMapper mapper)
        {
            _driverReposiory = driverRepository;
            _mapper = mapper;
        }
        public async Task<DriverDto> GetAsync(Guid UserId)
        {
            var driver = await _driverReposiory.GetAsync(UserId);
            return _mapper.Map<Driver, DriverDto>(driver);
        }
    }
}