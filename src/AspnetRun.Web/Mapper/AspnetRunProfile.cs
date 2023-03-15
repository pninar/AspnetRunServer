using AspnetRun.Application.Models;
using AspnetRun.Web.ViewModels;
using AutoMapper;

namespace AspnetRun.Web.Mapper
{
    public class AspnetRunProfile : Profile
    {
        // create a map between each model and its associated viewModel
        public AspnetRunProfile()
        {
            CreateMap<ProductModel, ProductViewModel>().ReverseMap();
            CreateMap<CategoryModel, CategoryViewModel>().ReverseMap();
            CreateMap<PatientModel, PatientViewModel>().ReverseMap();
            CreateMap<CityModel, CityViewModel>().ReverseMap();
            CreateMap<KupahModel, KupahViewModel>().ReverseMap();
        }
    }
}
