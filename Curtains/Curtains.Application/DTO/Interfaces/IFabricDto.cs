namespace Curtains.Application.DTO.Interfaces;

public interface IFabricDto
{
    public bool Density { get; set; }
    public decimal Price { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public bool Design { get; set; }
    public abstract ConsistencyDTO Consistency { get; set; }
    public abstract ColorDTO Color { get; set; }
    public DecorationsDTO Decorations { get; set; }
    public ManufacturerDTO Manufacturer { get; set; }
}