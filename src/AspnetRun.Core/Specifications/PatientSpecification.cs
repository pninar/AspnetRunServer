using AspnetRun.Core.Entities;
using AspnetRun.Core.Specifications.Base;
using System;
using System.Linq.Expressions;

namespace AspnetRun.Core.Specifications
{
    public class PatientSpecification : BaseSpecification<Patient> 
    {
        int PageSize = 10;
        public PatientSpecification(string patientName, int pageIndex)
            : base(GetNameCriteria(patientName))
        {
            AddPatientInclude();            

            int skip;

            if (pageIndex <= 0)
            {
                skip = 0;
            }
            else
            {
                skip = (pageIndex - 1) * PageSize;
            }
            ApplyPaging(skip, PageSize);
        }

        public PatientSpecification() : base(null)
        {
            //AddPatientInclude();
            //ApplyPaging(0, PageSize);
        }

        private void AddPatientInclude()
        {
            AddInclude(p => p.City);
            AddInclude(p => p.Kupah);
            AddInclude(p => p.Branch);
        }
        private static Expression<Func<Patient, bool>> GetNameCriteria(string patientName)
        {
            if (patientName == null)
            {
                return null;
            }
            else
            {
                return p => p.FirstName.ToLower().Contains(patientName.ToLower()) || p.LastName.ToLower().Contains(patientName.ToLower());
            }
        }
    }
}
