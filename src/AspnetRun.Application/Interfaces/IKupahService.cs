using AspnetRun.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRun.Application.Interfaces
{
    public interface IKupahService
    {
        Task<IEnumerable<KupahModel>> GetKupahList();
    }
}