using AspnetRun.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRun.Application.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityModel>> GetCityList();
    }
}