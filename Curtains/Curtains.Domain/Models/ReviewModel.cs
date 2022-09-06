
namespace Curtains.Domain.Models
{
    public partial class ReviewModel
    {
        public int Id { get; set; }
        public string PersonName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Review { get; set; } = null!;      
        public byte[] Photo { get; set; } = null!;
    }
}
