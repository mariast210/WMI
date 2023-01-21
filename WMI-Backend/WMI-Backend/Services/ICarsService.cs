using Microsoft.AspNetCore.OData.Query;
using WMI_Backend.Models;
using WMI_Backend.Models.Response;

namespace WMI_Backend.Services
{
    public interface ICarsService
    {
        PageResponse<Car> GetAll(ODataQueryOptions<Car> options);
    }
}