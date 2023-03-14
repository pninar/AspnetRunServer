using AspnetRun.Core.Entities;
using AspnetRun.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetRun.Core.Repositories
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Task<IEnumerable<Patient>> GetPatientListAsync(int pageIndex);
        Task<IEnumerable<Patient>> GetPatientByNameAsync(string patientName);
    }
}
