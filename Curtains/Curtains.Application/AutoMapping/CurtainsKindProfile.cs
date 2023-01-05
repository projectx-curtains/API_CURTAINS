using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with curtains kind
    /// </summary>
    public class CurtainsKindProfile : Profile
    {
        public CurtainsKindProfile()
        {
            CreateMap<CurtainsKindModel, CurtainsKindDTO>().ReverseMap();
        }
    }
}
