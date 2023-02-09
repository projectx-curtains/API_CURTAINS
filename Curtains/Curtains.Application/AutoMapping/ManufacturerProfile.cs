using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with manufacturer
    /// </summary>
    public class ManufacturerProfile : Profile
    {
        public ManufacturerProfile()
        {
            CreateMap<ManufacturerModel, ManufacturerDTO>().ReverseMap();
        }
    }
}
