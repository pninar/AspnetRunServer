using AspnetRun.Core.Entities;
using AspnetRun.Core.Repositories.Base;
using System.Threading.Tasks;

namespace AspnetRun.Core.Repositories
{
    public interface ICityRepository : IRepository<City>, IRepositoryByName<City>
    {
        
    }
}

