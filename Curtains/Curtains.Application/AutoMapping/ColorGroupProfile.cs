using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with color group
    /// </summary>
    public class ColorGroupProfile : Profile
    {
        public ColorGroupProfile()
        {
            CreateMap<ColorGroupDTO, ColorGroupModel>().ReverseMap();
        }
    }
}
