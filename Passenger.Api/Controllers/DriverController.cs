using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Commands;
using Passenger.Infrastructure.DTO;
using Passenger.Infrastructure.Services;

namespace Passenger.Api.Controllers
{
    [Route("[controller]")]
    public class DriverController : ApiControllerBase
    {
        private readonly IDriverService _driverService;
        public DriverController(IDriverService driverService, ICommandDispatcher commmandDispatcher) : base(commmandDispatcher)
        {
            _driverService = driverService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAsync(Guid userId)
        {
            var driver = await _driverService.GetAsync(userId);
            if(driver == null)
                return NotFound();
            
            return Json(driver);
        }
    }
}
