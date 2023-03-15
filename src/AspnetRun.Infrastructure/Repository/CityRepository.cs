using AspnetRun.Core.Entities;
using AspnetRun.Core.Repositories;
using AspnetRun.Core.Specifications;
using AspnetRun.Infrastructure.Data;
using AspnetRun.Infrastructure.Repository.Base;
using Kolgraph.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRun.Infrastructure.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(KolgraphContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<City>> GetListByNameAsync()
        {
            var spec = new CityByNameSpecification();
            return await GetAsync(spec);
        }
    }
}

