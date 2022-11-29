using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class CurtainsKindProfile : Profile
    {
        public CurtainsKindProfile()
        {
            CreateMap<CurtainsKindModel, CurtainsKindDTO>().ReverseMap();
        }
    }
}
