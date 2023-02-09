using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    /// <summary>
    /// This interface describes the interaction model of the data transfer object to the database.
    /// </summary>
    public interface IMarketingInfoService
    {
        public IEnumerable<MarketingInfoDTO> GetAll();
        public Task<MarketingInfoDTO> GetByIdAsync(int Id);
    }
}
