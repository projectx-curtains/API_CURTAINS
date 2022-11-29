using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    public class MarketingInfoProfile : Profile
    {
        public MarketingInfoProfile()
        {
            CreateMap<MarketingInfoModel, MarketingInfoDTO>().ReverseMap();
        }
    }
}
