namespace Curtains.Application.DTO.Interfaces;

public interface IBedspreadsDto
{
    public string Size { get; set; }
    public string Purpose { get; set; }
    public decimal Price { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public string Shape { get; set; }
    public FabricDTO Fabric { get; set; }
}