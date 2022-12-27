using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Domain.Projections;
using Curtains.Infrastructure.SearchQueries;

namespace Curtains.Application.AutoMapping
{
    public class CurtainsProfile : Profile
    {
        public CurtainsProfile()
        {
            CreateMap<CurtainsModel, CurtainsDTO>()
                .ReverseMap();

            /*CreateMap<CurtainsDTO, CurtainsProjection>()
                .ForMember(dst => dst.Fabric, opt => opt
                    .MapFrom(src => src.Fabric.Title))
                .ForMember(dst => dst.Color, opt => opt
                    .MapFrom(src => src.Fabric.Color.Title))
                .ForMember(dst => dst.Material, opt => opt
                    .MapFrom(src => src.Material.Title))
                .ForMember(dst => dst.CurtainsType, opt => opt
                    .MapFrom(src => src.CurtainsType.Title))
                .ForMember(dst => dst.CurtainsKind, opt => opt
                    .MapFrom(src => src.CurtainsKind.Title))
                .ReverseMap();*/

            CreateMap<CurtainSearchDTO, CurtainsProjection>()
                .ReverseMap();

            CreateMap<ElasticSearchQuery<CurtainSearchDTO>, ElasticSearchQuery<CurtainsProjection>>()
                .ReverseMap();
        }
    }
}
