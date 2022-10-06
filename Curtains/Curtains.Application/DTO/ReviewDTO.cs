using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Curtains.Domain.Models;

namespace Curtains.Application.DTO
{
    [AutoMap(typeof(ReviewModel))]
    public class ReviewDTO
    {
        [SourceMember(nameof(ReviewModel.PersonName))]
        public string PersonName { get; set; }

        [SourceMember(nameof(ReviewModel.Country))]
        public string Country { get; set; }

        [SourceMember(nameof(ReviewModel.City))]
        public string City { get; set; }

        [SourceMember(nameof(ReviewModel.Review))]
        public string Review { get; set; }

        [SourceMember(nameof(ReviewModel.Image))]
        public string Image { get; set; }
    }
}
