using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with bedspreads size
    /// </summary>
    public class BedspreadSizeProfile : Profile
    {
        public BedspreadSizeProfile()
        {
            CreateMap<BedspreadsSizeDTO, BedspreadsSizeModel>().ReverseMap();
        }
    }
}
