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
        public Task InsertAsync(MarketingInfoDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(MarketingInfoDTO entity);
        public Task RemoveAsync(MarketingInfoDTO entity);
    }
}
