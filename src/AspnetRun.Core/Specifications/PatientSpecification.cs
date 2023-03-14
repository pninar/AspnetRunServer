using AspnetRun.Core.Entities;
using AspnetRun.Core.Specifications.Base;

namespace AspnetRun.Core.Specifications
{
    public class PatientSpecification : BaseSpecification<Patient> 
    {
        int PageSize = 10;
        public PatientSpecification(string patientName, int pageIndex)
            : base(p => p.FirstName.ToLower().Contains(patientName.ToLower()) || p.LastName.ToLower().Contains(patientName.ToLower()))
        {
            AddInclude(p => p.City);
            AddInclude(p => p.Kupah);
            AddInclude(p => p.Branch);

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
            AddInclude(p => p.City);
            AddInclude(p => p.Kupah);
            AddInclude(p => p.Branch);
            ApplyPaging(0, PageSize);
        }
    }
}
