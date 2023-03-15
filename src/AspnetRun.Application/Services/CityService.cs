using AspnetRun.Application.Mapper;
using AspnetRun.Application.Interfaces;
using AspnetRun.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspnetRun.Core.Repositories;
using AspnetRun.Application.Models;

namespace AspnetRun.Application.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IAppLogger<CityService> _logger;

        public CityService(ICityRepository cityRepository, IAppLogger<CityService> logger)
        {
            _cityRepository = cityRepository ?? throw new ArgumentNullException(nameof(cityRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<CityModel>> GetCityList()
        {
            var list = await _cityRepository.GetListByNameAsync();
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<CityModel>>(list);
            return mapped;
        }

    }
}
