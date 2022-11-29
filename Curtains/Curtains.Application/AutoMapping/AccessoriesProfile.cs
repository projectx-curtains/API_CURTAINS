using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class AccessoriesProfile : Profile
    {
        public AccessoriesProfile()
        {
            CreateMap<AccessoriesModel, AccessoriesDTO>().ReverseMap();
        }
    }
}
