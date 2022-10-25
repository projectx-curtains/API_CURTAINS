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
    public class CurtainsProfile : Profile
    {
        public CurtainsProfile()
        {
            CreateMap<CurtainsModel, CurtainsDTO>().ReverseMap();
        }
    }
}
