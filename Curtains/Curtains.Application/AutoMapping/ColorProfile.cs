using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with color
    /// </summary>
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<ColorModel, ColorDTO>().ReverseMap();
        }
    }
}
