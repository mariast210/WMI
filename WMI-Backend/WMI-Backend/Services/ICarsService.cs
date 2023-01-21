using Microsoft.AspNetCore.OData.Query;
using WMI_Backend.Models;

namespace WMI_Backend.Services
{
    public interface ICarsService
    {
        PageResult<Car> GetAll(ODataQueryOptions<Car> options);
    }
}