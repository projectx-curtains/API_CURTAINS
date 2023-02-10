using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IMetaDataService
    {
        public IEnumerable<MetaDataDTO> GetAll();
        public Task<MetaDataDTO> GetByIdAsync(int Id);
        public Task InsertAsync(MetaDataDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(MetaDataDTO entity);
        public Task RemoveAsync(MetaDataDTO entity);
    }
}
