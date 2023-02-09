using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
    /// <summary>
    /// This class describes the behavior of automapping when working with fabric type
    /// </summary>
    public class FabricTypeService : Profile
    {
        public FabricTypeService()
        {
            CreateMap<FabricTypeDTO, FabricTypeModel>().ReverseMap();
        }
    }
}
