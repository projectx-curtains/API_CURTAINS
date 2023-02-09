using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with product image
    /// </summary>
    public class ProductImageProfile : Profile
    {
        public ProductImageProfile()
        {
            CreateMap<ProductImageModel, ProductImageDTO>().ReverseMap();
        }
    }
}
