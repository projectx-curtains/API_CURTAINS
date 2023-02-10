using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with design
    /// </summary>
    public class DesignProfile : Profile
    {
        public DesignProfile()
        {
            CreateMap<DesignModel, DesignDTO>().ReverseMap();
        }
    }
}
