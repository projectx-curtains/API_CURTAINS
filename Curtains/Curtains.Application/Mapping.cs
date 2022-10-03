using AutoMapper;
using Curtains.Domain.Models;
using Curtains.Application.DTO;

namespace Curtains.Application
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<ReviewModel, ReviewDTO>().ReverseMap();
        }
    }
}
