using AspnetRun.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetRun.Core.Repositories.Base
{
    public interface IRepositoryByName<T> where T : Entity
    {
        Task<IReadOnlyList<T>> GetListByNameAsync();
    }
}
