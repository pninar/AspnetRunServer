using AspnetRun.Application.Interfaces;
using AspnetRun.Web.Interfaces;
using AspnetRun.Web.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRun.Web.Services
{
    public class CityPageService : ICityPageService
    {
        private readonly ICityService _cityAppService;
        private readonly IMapper _mapper;

        public CityPageService(ICityService cityAppService, IMapper mapper)
        {
            _cityAppService = cityAppService ?? throw new ArgumentNullException(nameof(cityAppService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<CityViewModel>> GetCities()
        {
            var list = await _cityAppService.GetCityList();
            var mapped = _mapper.Map<IEnumerable<CityViewModel>>(list);
            return mapped;
        }
    }
}
