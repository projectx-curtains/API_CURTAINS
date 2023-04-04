using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Domain.Projections;
using Curtains.Infrastructure.SearchQueries;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with curtains
    /// </summary>
    public class CurtainsProfile : Profile
    {
        public CurtainsProfile()
        {
            CreateMap<CurtainsDTO, CurtainsProjection>()
                .ForMember(dst => dst.Fabric, opt => opt
                    .MapFrom(src => src.Fabric.Title))
                .ForMember(dst => dst.CurtainsType, opt => opt
                    .MapFrom(src => src.CurtainsType.Title))
                .ForMember(dst => dst.CurtainsKind, opt => opt
                    .MapFrom(src => src.CurtainsKind.Title))
                .ForMember(dst => dst.Purpose, opt => opt
                    .MapFrom(src => src.Purpose.Title))
                .ForMember(dst => dst.Material, opt => opt
                    .MapFrom(src => src.Material.Title))
                .ForMember(dst => dst.FabricStructure, opt => opt
                    .MapFrom(src => src.Material.Description))
                .ForMember(dst => dst.Color, opt => opt
                    .MapFrom(src => src.Fabric.Color.Title))
                .ForMember(dst => dst.Desing, opt => opt
                    .MapFrom(src => src.Fabric.Design.Title))
                .ForMember(dst => dst.Bracing, opt => opt
                    .MapFrom(src => src.Accessories.Bracing.Title))
                .ReverseMap();

            CreateMap<CurtainSearchDTO, CurtainsProjection>()
                .ReverseMap();

            CreateMap<ElasticSearchQuery<CurtainSearchDTO>, ElasticSearchQuery<CurtainsProjection>>()
                .ReverseMap();

            CreateMap<CurtainsModel, CurtainsDTO>()
                .ReverseMap();

            CreateMap<CurtainProduct, CurtainsInfoDTO>()
                .ReverseMap();
        }
    }
}
