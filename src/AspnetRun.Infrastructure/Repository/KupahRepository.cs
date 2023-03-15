using AspnetRun.Core.Entities;
using AspnetRun.Core.Repositories;
using AspnetRun.Core.Repositories.Base;
using AspnetRun.Core.Specifications;
using AspnetRun.Infrastructure.Data;
using AspnetRun.Infrastructure.Repository.Base;
using Kolgraph.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRun.Infrastructure.Repository
{
    public class KupahRepository : Repository<Kupah>, IKupahRepository
    {
        public KupahRepository(KolgraphContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<Kupah>> GetListByNameAsync()
        {
            var spec = new KupahByNameSpecification();
            return await GetAsync(spec);
        }
    }
}
