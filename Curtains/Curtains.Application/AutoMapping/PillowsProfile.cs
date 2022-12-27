using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with pillows
    /// </summary>
    public class PillowsProfile : Profile
    {
        public PillowsProfile()
        {
            CreateMap<PillowsModel, PillowsDTO>().ReverseMap();
            CreateMap<PillowProduct, PillowsDTO>().ReverseMap();
        }
    }
}
