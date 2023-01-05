using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with curtains type
    /// </summary>
    public class CurtainsTypeProfile : Profile
    {
        public CurtainsTypeProfile()
        {
            CreateMap<CurtainsTypeModel, CurtainsTypeDTO>().ReverseMap();
        }
    }
}
