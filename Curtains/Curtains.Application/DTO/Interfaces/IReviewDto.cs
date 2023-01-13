namespace Curtains.Application.DTO.Interfaces;

public interface IReviewDto
{
    public string PersonName { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Review { get; set; }
    public string ImagePath { get; set; }
}