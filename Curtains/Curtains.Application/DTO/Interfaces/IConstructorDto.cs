namespace Curtains.Application.DTO.Interfaces;

public interface IConstructorDto
{
    public IEnumerable<CurtainsDTO> Curtains { get; set; }

    public string PhoneNumber { get; set; }

    public string Comment { get; set; }
}