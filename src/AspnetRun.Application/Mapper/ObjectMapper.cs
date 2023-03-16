using AspnetRun.Application.Models;
using AspnetRun.Core.Entities;
using AutoMapper;
using System;

namespace AspnetRun.Application.Mapper
{
    // The best implementation of AutoMapper for class libraries -> https://www.abhith.net/blog/using-automapper-in-a-net-core-class-library/
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<AspnetRunDtoMapper>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }

    public class AspnetRunDtoMapper : Profile
    {
        // create a map between each model and its associated entity
        public AspnetRunDtoMapper()
        {
            CreateMap<Product, ProductModel>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductName)).ReverseMap();

            CreateMap<Category, CategoryModel>().ReverseMap();

            CreateMap<Patient, PatientModel>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName.Trim()))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName.Trim()))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.CityId))
                .ForMember(dest => dest.KupahId, opt => opt.MapFrom(src => src.KupahId))
                .ForMember(dest => dest.Zehut, opt => opt.MapFrom(src => src.Zehut.Trim()));
            //.ReverseMap();

            CreateMap<PatientModel, Patient>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName.Trim()))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName.Trim()))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.CityId))
                .ForMember(dest => dest.KupahId, opt => opt.MapFrom(src => src.KupahId))
                .ForMember(dest => dest.Zehut, opt => opt.MapFrom(src => src.Zehut.Trim()));
            //.ReverseMap();

            CreateMap<City, CityModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Trim())).ReverseMap();

            CreateMap<Kupah, KupahModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Trim())).ReverseMap();
        }
    }
}
