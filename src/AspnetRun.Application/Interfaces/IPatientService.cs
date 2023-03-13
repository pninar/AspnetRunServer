using AspnetRun.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetRun.Application.Interfaces
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientModel>> GetPatientList();
        Task<PatientModel> GetPatientById(int patientId);
        Task<IEnumerable<PatientModel>> GetPatientByName(string patientName);
        Task<PatientModel> Create(PatientModel patientModel);
        Task Update(PatientModel patientModel);
        Task Delete(PatientModel patientModel);
    }
}
