using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.DTO;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with order
    /// </summary>
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, ConstructorDTO>()
                .ForMember(x => x.Curtains, o => o.Ignore()).ReverseMap();
            CreateMap<Order, OrderDTO>()
                .ForMember(x => x.ProductIds, o => o.Ignore()).ReverseMap();
        }
    }
}
