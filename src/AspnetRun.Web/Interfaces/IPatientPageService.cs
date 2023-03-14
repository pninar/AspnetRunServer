using AspnetRun.Web.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRun.Web.Interfaces
{
    public interface IPatientPageService
    {
        Task<IEnumerable<PatientViewModel>> GetPatients(string patientName, int pageIndex);
        Task<PatientViewModel> GetPatientById(int productId);
        //Task<IEnumerable<ProductViewModel>> GetProductByCategory(int categoryId);
        //Task<IEnumerable<CategoryViewModel>> GetCategories();
        Task<PatientViewModel> CreatePatient(PatientViewModel productViewModel);
        Task UpdatePatient(PatientViewModel productViewModel);
        Task DeletePatient(PatientViewModel productViewModel);
    }
}

