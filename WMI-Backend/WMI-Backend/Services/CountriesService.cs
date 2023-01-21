using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMI_Backend.Models;
using WMI_Backend.Repository;

namespace WMI_Backend.Services
{
    public class CountriesService : ICountriesService
    {
        private readonly CarsRepository _carsRepository;

        public CountriesService(CarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        public async Task<List<Country>> GetAll()
        {
            var countries = await _carsRepository.GetCountries();
            return countries.Select(x => new Country { Name = x ?? string.Empty }).ToList();
        }
    }
}

