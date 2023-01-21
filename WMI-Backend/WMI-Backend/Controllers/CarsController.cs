﻿using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WMI_Backend.Models;
using WMI_Backend.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OData.Query;
using System.Linq;
using Microsoft.AspNetCore.OData.Formatter;
using WMI_Backend.Repository;
using Microsoft.OData;

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
        public ActionResult<PageResult<Car>> GetAll(ODataQueryOptions<Car> options)
        {
            try
            {
                var carsPageResult = _carsService.GetAll(options);
                return Ok(carsPageResult);
            }
            catch(ODataException ex)
            {
                _logger.LogError("An error occured when running odata request: {message}", ex.Message);
                return BadRequest(new Error(ex.Message));
            }
        }
    }
}

