using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.AutoMapping
{
    public class FabricProfile : Profile
    {
        public FabricProfile()
        {
            CreateMap<FabricModel, FabricDTO>().ReverseMap();
            CreateMap<FabricProduct, FabricDTO>().ReverseMap();
        }
    }
}
