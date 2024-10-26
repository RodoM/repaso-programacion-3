using Application.Interfaces;
using Application.Models.Request;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _DriverService;
        public DriverController(IDriverService DriverService)
        {
            _DriverService = DriverService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDrivers()
        {
            var response = await _DriverService.GetAllDrivers();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDriver([FromBody] DriverRequest Driver)
        {
            var response =await _DriverService.CreateDriver(Driver);
            return Ok(response);
        }
    }
}
