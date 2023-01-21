using Microsoft.AspNetCore.OData.Query;
using WMI_Backend.Models;
using WMI_Backend.Models.Response;
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

        public PageResponse<Car> GetAll(ODataQueryOptions<Car> options)
        {
            var data = _carsRepository.GetAll(options);
            var totalCount = _carsRepository.GetTotalCount(options.Filter);
            return new PageResponse<Car> { Data = data, TotalCount = totalCount };
        }
    }
}