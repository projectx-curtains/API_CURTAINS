using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<ColorModel, ColorDTO>().ReverseMap();
        }
    }
}
