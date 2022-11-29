using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class CurtainsTypeProfile : Profile
    {
        public CurtainsTypeProfile()
        {
            CreateMap<CurtainsTypeModel, CurtainsTypeDTO>().ReverseMap();
        }
    }
}
