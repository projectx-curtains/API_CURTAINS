using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Curtains.Domain.Models;
using Curtains.Application.DTO;

namespace Curtains.Application.AutoMapping
{
    public class AutoMap : Profile
    {
        public AutoMap()
        {
            CreateMap<ReviewModel, ReviewDTO>().ReverseMap();       
        }
    }
}
