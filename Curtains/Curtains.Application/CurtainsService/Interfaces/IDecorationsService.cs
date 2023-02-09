using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IDecorationsService
    {
        public IEnumerable<DecorationsDTO> GetAll();
        public Task<DecorationsDTO> GetByIdAsync(int Id);
        public Task InsertAsync(DecorationsDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(DecorationsDTO entity);
        public Task RemoveAsync(DecorationsDTO entity);
    }
}
