using AutoMapper;
using Curtains.Domain.Models;
using Curtains.Application.DTO;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with pillows size
    /// </summary>
    public class PillowsSizeProfile : Profile
    {
        public PillowsSizeProfile()
        {
            CreateMap<PillowsSizeDTO, PillowsSizeModel>().ReverseMap();
        }
    }
}
