using AutoMapper;
using Curtains.Domain.Models;
using Curtains.Application.DTO;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with our works
    /// </summary>
    public class OurWorksProfile : Profile
    {
        public OurWorksProfile()
        {
            CreateMap<OurWorksDTO, OurWorksModel>().ReverseMap();
        }
    }
}
