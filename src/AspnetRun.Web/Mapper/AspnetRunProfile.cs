﻿using AspnetRun.Application.Models;
using AspnetRun.Web.ViewModels;
using AspnetRun.Web.ViewModels.Product;
using AutoMapper;

namespace AspnetRun.Web.Mapper
{
    public class AspnetRunProfile : Profile
    {
        public AspnetRunProfile()
        {
            CreateMap<ProductModel, ProductViewModel>().ReverseMap();
            CreateMap<CategoryModel, CategoryViewModel>().ReverseMap();
        }
    }
}
