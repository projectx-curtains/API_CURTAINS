using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with lambrequins
    /// </summary>
    public class LambrequinsProfile : Profile
    {
        public LambrequinsProfile()
        {
            CreateMap<LambrequinsDTO, LambrequinsModel>().ReverseMap();
        }
    }
}
