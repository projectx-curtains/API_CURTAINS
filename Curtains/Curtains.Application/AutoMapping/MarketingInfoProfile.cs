using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with marketing info
    /// </summary>
    public class MarketingInfoProfile : Profile
    {
        public MarketingInfoProfile()
        {
            CreateMap<MarketingInfoModel, MarketingInfoDTO>().ReverseMap();
        }
    }
}
