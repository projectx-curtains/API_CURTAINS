namespace Curtains.Application.DTO.Interfaces;

public interface ICrutainsDto
{
    public string Title { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Count { get; set; }
    public string CurtainsType { get; set; }
    public string Design { get; set; }
    public string FabricType { get; set; }
    public string Color { get; set; }
}