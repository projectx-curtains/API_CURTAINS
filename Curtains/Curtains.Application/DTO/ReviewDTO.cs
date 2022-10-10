using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Curtains.Domain.Models;

namespace Curtains.Application.DTO
{
    [AutoMap(typeof(ReviewModel))]
    public class ReviewDTO
    {
        [SourceMember(nameof(ReviewModel.Id))]
        public int Id { get; set; }

        [SourceMember(nameof(ReviewModel.Title))]
        public string Title { get; set; }

        [SourceMember(nameof(ReviewModel.Description))]
        public string Description { get; set; }

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
