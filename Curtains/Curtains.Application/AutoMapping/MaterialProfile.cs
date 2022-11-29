using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class MaterialProfile : Profile
    {
        public MaterialProfile()
        {
            CreateMap<MaterialModel, MaterialDTO>().ReverseMap();
        }
    }
}
