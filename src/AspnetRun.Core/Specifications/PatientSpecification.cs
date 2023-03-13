using AspnetRun.Core.Entities;
using AspnetRun.Core.Specifications.Base;

namespace AspnetRun.Core.Specifications
{
    public class PatientSpecification : BaseSpecification<Patient> 
    {
        public PatientSpecification(string patientName)
            : base(p => p.FirstName.ToLower().Contains(patientName.ToLower()) || p.LastName.ToLower().Contains(patientName.ToLower()))
        {
            AddInclude(p => p.City);
            AddInclude(p => p.Kupah);
            AddInclude(p => p.Branch);
        }

        public PatientSpecification() : base(null)
        {
            AddInclude(p => p.City);
            AddInclude(p => p.Kupah);
            AddInclude(p => p.Branch);
        }
    }
}
