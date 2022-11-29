using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class DecorationsProfile : Profile
    {
        public  DecorationsProfile()
        {
            CreateMap<DecorationsModel, DecorationsDTO>().ReverseMap();
        }
    }
}
