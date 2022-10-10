using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Curtains.Domain.Models;

namespace Curtains.Application.DTO
{

    public class ReviewDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PersonName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Review { get; set; }

        public string ImagePath { get; set; }
    }
}
