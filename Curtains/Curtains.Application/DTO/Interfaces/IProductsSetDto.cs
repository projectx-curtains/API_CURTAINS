namespace Curtains.Application.DTO.Interfaces;

public interface IProductsSetDto
{
    public decimal Price { get; set; }
    public CurtainsDTO Curtains { get; set; }
    public PillowsDTO Pillows { get; set; }
    public BedspreadsDTO Bedspreads { get; set; }
}