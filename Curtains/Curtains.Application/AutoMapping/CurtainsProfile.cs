using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Domain.Projections;

namespace Curtains.Application.AutoMapping
{
    public class CurtainsProfile : Profile
    {
        public CurtainsProfile()
        {
            CreateMap<CurtainsModel, CurtainsDTO>()
                .ReverseMap();

            CreateMap<CurtainsDTO, CurtainsProjection>()
                .ForMember(dst => dst.FabricId, opt => opt
                        .MapFrom(src => src.FabricId))
                .ForMember(dst => dst.ColorId, opt => opt
                        .MapFrom(src => src.Fabric.Color.Id))
                .ForMember(dst => dst.MaterialId, opt => opt
                        .MapFrom(src => src.MaterialId))
                .ForMember(dst => dst.CurtainsTypeId, opt => opt
                        .MapFrom(src => src.CurtainsTypeId))
                .ForMember(dst => dst.CurtainsKindId, opt => opt
                        .MapFrom(src => src.CurtainsKindId))
                .ReverseMap();


        }
    }
}
