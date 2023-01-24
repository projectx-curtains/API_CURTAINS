﻿using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with product set
    /// </summary>
    public class ProductSetProfile : Profile
    {
        public ProductSetProfile()
        {
            CreateMap<ProductSetModel, ProductSetDTO>().ReverseMap();
            CreateMap<SetProduct, ProductSetDTO>().ReverseMap();
        }
    }
}