using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IMarketingInfoService
    {
        public IEnumerable<MarketingInfoDTO> GetAll();
        public Task<MarketingInfoDTO> GetByIdAsync(int Id);
    }
}
