using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IAccessoriesService
    {
        public IEnumerable<AccessoriesDTO> GetAll();
        public Task<AccessoriesDTO> GetByIdAsync(int Id);
        public Task InsertAsync(AccessoriesDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(AccessoriesDTO entity);
        public Task RemoveAsync(AccessoriesDTO entity);
    }
}
