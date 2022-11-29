using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class PillowsProfile : Profile
    {
        public PillowsProfile()
        {
            CreateMap<PillowsModel, PillowsDTO>().ReverseMap();
        }
    }
}
