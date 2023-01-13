namespace Curtains.Application.DTO.Interfaces;

public interface IPillowsDto
{
    public string Size { get; set; }
    public string Filler { get; set; }
    public bool RemovableCover { get; set; }
    public decimal Price { get; set; }
    public string Shape { get; set; }
    public FabricDTO Fabric { get; set; }
}