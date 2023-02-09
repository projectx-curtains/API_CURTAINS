using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with accessories
    /// </summary>
    public class AccessoriesProfile : Profile
    {
        public AccessoriesProfile()
        {
            CreateMap<AccessoriesModel, AccessoriesDTO>().ReverseMap();
        }
    }
}
