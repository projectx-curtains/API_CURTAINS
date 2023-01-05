using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with curtains
    /// </summary>
    public class CurtainsProfile : Profile
    {
        public CurtainsProfile()
        {
            CreateMap<CurtainsModel, CurtainsDTO>().ReverseMap();
            CreateMap<CurtainProduct, CurtainsDTO>().ReverseMap();
        }
    }
}
