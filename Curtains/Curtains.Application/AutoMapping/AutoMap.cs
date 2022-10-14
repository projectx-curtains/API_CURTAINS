using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.AutoMapping
{
    public class AutoMap : Profile
    {   
        public AutoMap()
        {
            CreateMap<ColorModel, ColorDTO>().ReverseMap();
            CreateMap<ConsistencyModel, ConsistencyDTO>().ReverseMap();
            CreateMap<CurtainsKindModel, CurtainsKindDTO>().ReverseMap();
            CreateMap<CurtainsTypeModel, CurtainsTypeDTO>().ReverseMap();
            CreateMap<DecorationsModel, DecorationsDTO>().ReverseMap();
            CreateMap<ManufacturerModel, ManufacturerDTO>().ReverseMap();
            CreateMap<MaterialModel, MaterialDTO>().ReverseMap();
            CreateMap<AccessoriesModel, AccessoriesDTO>().ReverseMap();
            CreateMap<FabricModel, FabricDTO>().ReverseMap();
            CreateMap<BedspreadsModel, BedspreadsDTO>().ReverseMap();
            CreateMap<CurtainsModel, CurtainsDTO>().ReverseMap();
            CreateMap<PillowsModel, PillowsDTO>().ReverseMap();
            CreateMap<ProductSetModel, ProductSetDTO>().ReverseMap();
            CreateMap<ProductImageModel, ProductImageDTO>().ReverseMap();
            CreateMap<MarketingInfoModel, MarketingInfoDTO>().ReverseMap();
        }
    }
}
