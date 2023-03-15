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
    public class KupahPageService : IKupahPageService
    {
        private readonly IKupahService _kupahAppService;
        private readonly IMapper _mapper;

        public KupahPageService(IKupahService kupahAppService, IMapper mapper)
        {
            _kupahAppService = kupahAppService ?? throw new ArgumentNullException(nameof(kupahAppService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<KupahViewModel>> GetKupahs()
        {
            var list = await _kupahAppService.GetKupahList();
            var mapped = _mapper.Map<IEnumerable<KupahViewModel>>(list);
            return mapped;
        }
    }
}
