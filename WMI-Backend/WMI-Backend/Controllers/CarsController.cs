using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WMI_Backend.Models;
using WMI_Backend.Services;
using Microsoft.AspNetCore.OData.Query;
using WMI_Backend.Models.Response;

namespace WMI_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;
        private readonly ICarsService _carsService;

        public CarsController(ILogger<CarsController> logger, ICarsService carsService)
        {
            _logger = logger;
            _carsService = carsService;
        }

        [HttpGet]
        public ActionResult<PageResponse<Car>> GetAll(ODataQueryOptions<Car> options)
        {
            try
            {
                var carsPageResult = _carsService.GetAll(options);
                return Ok(carsPageResult);
            }
            catch(Exception ex)
            {
                _logger.LogError("An error occured when getting list of cars: {message}", ex.Message);
                return BadRequest(new Error(ex.Message));
            }
        }
    }
}

