using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class ProductSetProfile : Profile
    {
        public ProductSetProfile()
        {
            CreateMap<ProductSetModel, ProductSetDTO>().ReverseMap();
        }
    }
}
