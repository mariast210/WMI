using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WMI_Backend.Models;
using WMI_Backend.Repository;

namespace WMI_Backend.Services
{
    public class CarsService : ICarsService
    {
        private readonly CarsRepository _carsRepository;

        public CarsService(CarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        public PageResult<Car> GetAll(ODataQueryOptions<Car> options)
        {
            var data = _carsRepository.GetAll(options);
            var totalCount = _carsRepository.GetTotalCount(options.Filter);
            return new PageResult<Car> { Data = data, TotalCount = totalCount };
        }
    }
}

