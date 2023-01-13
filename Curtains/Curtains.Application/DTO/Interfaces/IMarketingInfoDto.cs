namespace Curtains.Application.DTO.Interfaces;

public interface IMarketingInfoDto
{
    public bool IsNew { get; set; }
    public bool IsOnSale { get; set; }
    public bool IsPopular { get; set; }
}