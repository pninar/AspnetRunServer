using AspnetRun.Core.Entities;
using AspnetRun.Core.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRun.Core.Repositories
{
    public interface IKupahRepository : IRepository<Kupah>, IRepositoryByName<Kupah>
    {
    }
}
