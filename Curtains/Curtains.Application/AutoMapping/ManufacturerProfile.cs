using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class ManufacturerProfile : Profile
    {
        public ManufacturerProfile()
        {
            CreateMap<ManufacturerModel, ManufacturerDTO>().ReverseMap();
        }
    }
}
