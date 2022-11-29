using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class ConsistencyProfile : Profile
    {
        public ConsistencyProfile()
        {
            CreateMap<ConsistencyModel, ConsistencyDTO>().ReverseMap();
        }
    }
}
