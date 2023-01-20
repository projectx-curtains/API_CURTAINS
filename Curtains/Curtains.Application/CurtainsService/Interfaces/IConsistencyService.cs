using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IConsistencyService
    {
        public IEnumerable<ConsistencyDTO> GetAll();
        public Task<ConsistencyDTO> GetByIdAsync(int Id);
        public Task InsertAsync(ConsistencyDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(ConsistencyDTO entity);
        public Task RemoveAsync(ConsistencyDTO entity);
    }
}
