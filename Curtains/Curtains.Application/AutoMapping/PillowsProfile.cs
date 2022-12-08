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
    public class PillowsProfile : Profile
    {
        public PillowsProfile()
        {
            CreateMap<PillowsModel, PillowsDTO>().ReverseMap();
            CreateMap<PillowProduct, PillowsDTO>().ReverseMap();
        }
    }
}
