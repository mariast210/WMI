using System.Collections.Generic;
using System.Threading.Tasks;
using WMI_Backend.Models;

namespace WMI_Backend.Services
{
    public interface ICountriesService
    {
        Task<List<Country>> GetAll();
    }
}