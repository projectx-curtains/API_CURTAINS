using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with fabric kind
    /// </summary>
    public class FabricKindProfile : Profile
    {
        public FabricKindProfile()
        {
            CreateMap<FabricKindProfile, FabricKindModel>().ReverseMap();
        }
    }
}
