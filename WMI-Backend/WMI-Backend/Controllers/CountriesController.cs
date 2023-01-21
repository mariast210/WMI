using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WMI_Backend.Models;
using WMI_Backend.Services;

namespace WMI_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
	{
        private readonly ILogger<CountriesController> _logger;
        private readonly ICountriesService _countriesService;

        public CountriesController(ILogger<CountriesController> logger, ICountriesService countriesService)
		{
            _logger = logger;
            _countriesService = countriesService;
		}

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var countries = await _countriesService.GetAll();
                return Ok(countries);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occured when getting list of countries: {message}", ex.Message);
                return BadRequest(new Error(ex.Message));
            }
        }
    }
}

