using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WMI_Backend.Models;

namespace WMI_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
	{
        private readonly ILogger<CountriesController> _logger;

        public CountriesController(ILogger<CountriesController> logger)
		{
            _logger = logger;
		}

        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return new List<Country>();
        }
    }
}

