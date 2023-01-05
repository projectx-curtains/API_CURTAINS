using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with material
    /// </summary>
    public class MaterialProfile : Profile
    {
        public MaterialProfile()
        {
            CreateMap<MaterialModel, MaterialDTO>().ReverseMap();
        }
    }
}
