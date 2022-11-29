using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class FabricProfile : Profile
    {
        public FabricProfile()
        {
            CreateMap<FabricModel, FabricDTO>().ReverseMap();
        }
    }
}
