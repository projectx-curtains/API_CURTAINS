namespace Curtains.Domain.Projections
{
    public class CurtainsProjection
    {
        public Guid Id { get; set; }
        public string Title{ get; set; }
        public decimal Price { get; set; }
        public string Purpose { get; set; }
        public bool SunProtection { get; set; }
        public int FabricId { get; set; }
        public int MaterialId { get; set; }
        public int CurtainsTypeId { get; set; }
        public int CurtainsKindId { get; set; }
    }
}