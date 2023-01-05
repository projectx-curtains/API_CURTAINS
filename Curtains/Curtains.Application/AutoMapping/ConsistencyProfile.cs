using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with consistency
    /// </summary>
    public class ConsistencyProfile : Profile
    {
        public ConsistencyProfile()
        {
            CreateMap<ConsistencyModel, ConsistencyDTO>().ReverseMap();
        }
    }
}
