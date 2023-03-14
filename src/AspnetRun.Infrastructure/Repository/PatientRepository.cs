using AspnetRun.Core.Entities;
using AspnetRun.Core.Repositories;
using AspnetRun.Core.Specifications;
using AspnetRun.Infrastructure.Data;
using AspnetRun.Infrastructure.Repository.Base;
using Kolgraph.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetRun.Infrastructure.Repository
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(KolgraphContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Patient>> GetPatientListAsync(int pageIndex)
        {
            var spec = new PatientSpecification(null, pageIndex);
            return await GetAsync(spec);

            // second way
            // return await GetAllAsync();
        }

        public async Task<IEnumerable<Patient>> GetPatientByNameAsync(string patientName)
        {
            var spec = new PatientSpecification(patientName, 0);
            return await GetAsync(spec);

            // second way
            // return await GetAsync(x => x.ProductName.ToLower().Contains(productName.ToLower()));

            // third way
            //return await _dbContext.Products
            //    .Where(x => x.ProductName.Contains(productName))
            //    .ToListAsync();
        }

        public override async Task<Patient> GetByIdAsync(int id)
        {
            var spec = new PatientSpecification();
            return await base.GetByIdAsync(id, spec);
        }
    }
}
