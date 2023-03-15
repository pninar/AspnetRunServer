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
    public class KupahService : IKupahService
    {
        private readonly IKupahRepository _kupahRepository;
        private readonly IAppLogger<KupahService> _logger;

        public KupahService(IKupahRepository kupahRepository, IAppLogger<KupahService> logger)
        {
            _kupahRepository = kupahRepository ?? throw new ArgumentNullException(nameof(kupahRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<KupahModel>> GetKupahList()
        {
            var list = await _kupahRepository.GetListByNameAsync();
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<KupahModel>>(list);
            return mapped;
        }

    }
}
