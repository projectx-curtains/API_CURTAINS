using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with fabric
    /// </summary>
    public class FabricProfile : Profile
    {
        public FabricProfile()
        {
            CreateMap<FabricModel, FabricDTO>().ReverseMap();
            CreateMap<FabricProduct, FabricDTO>().ReverseMap();
        }
    }
}
