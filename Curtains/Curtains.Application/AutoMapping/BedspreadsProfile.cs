using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class BedspreadsProfile : Profile
    {
        public BedspreadsProfile()
        {
            CreateMap<BedspreadsModel, BedspreadsDTO>().ReverseMap();
            CreateMap<BedspreadsDTO, BedspreadsProduct>().ReverseMap();
        }
    }
}
