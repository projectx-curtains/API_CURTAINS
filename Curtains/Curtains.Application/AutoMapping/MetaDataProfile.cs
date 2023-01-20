using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with meta data
    /// </summary>
    public class MetaDataProfile : Profile
    {
        public MetaDataProfile()
        {
            CreateMap<MetaDataDTO, MetaDataModel>().ReverseMap();
        }
    }
}
