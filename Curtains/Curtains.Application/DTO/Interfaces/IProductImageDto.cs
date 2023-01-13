namespace Curtains.Application.DTO.Interfaces;

public interface IProductImageDto
{
    public string ImagePath { get; set; }
    public CurtainsDTO Curtains { get; set; }
    public PillowsDTO Pillows { get; set; }
    public BedspreadsDTO Bedspreads { get; set; }
    public ProductSetDTO Sets { get; set; }
    public FabricDTO Fabrics { get; set; }
    public MarketingInfoDTO MarketingInfo { get; set; }
}