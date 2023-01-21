using System.Collections.Generic;
using System.Threading.Tasks;
using WMI_Backend.Models;
using WMI_Backend.Models.Response;

namespace WMI_Backend.Services
{
    public interface ICountriesService
    {
        Task<List<CountryResponse>> GetAll();
    }
}