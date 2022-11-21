using AutoMapper;
using Curtains.Domain.Models;
using Curtains.Application.DTO;

namespace Curtains.Application.AutoMapping
{
    public class OurWorksProfile : Profile
    {
        public OurWorksProfile()
        {
            CreateMap<OurWorksDTO, OurWorksModel>().ReverseMap();
        }
    }
}
