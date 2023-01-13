namespace Curtains.Application.DTO.Interfaces;

public interface IOrderDto
{
    public string Comment { get; set; }
    public string PhoneNumber { get; set; }
    public int[] ProductIds { get; set; }
}