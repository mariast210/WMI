using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMI_Backend.Models.Response;
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

        public async Task<List<CountryResponse>> GetAll()
        {
            const string blankCountry = "Blank";
            var countries = await _carsRepository.GetCountries();
            return countries.Select(x => new CountryResponse { Value = x ?? blankCountry, Label = x ?? blankCountry }).ToList();
        }
    }
}