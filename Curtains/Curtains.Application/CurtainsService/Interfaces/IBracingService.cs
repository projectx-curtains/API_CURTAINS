using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IBracingService
    {
        public IEnumerable<BracingDTO> GetAll();
        public Task<BracingDTO> GetByIdAsync(int Id);
        public Task InsertAsync(BracingDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(BracingDTO entity);
        public Task RemoveAsync(BracingDTO entity);
    }   
}
