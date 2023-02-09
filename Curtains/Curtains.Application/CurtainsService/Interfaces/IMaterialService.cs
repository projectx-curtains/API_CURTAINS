using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IMaterialService
    {
        public IEnumerable<MaterialDTO> GetAll();
        public Task<MaterialDTO> GetByIdAsync(int Id);
        public Task InsertAsync(MaterialDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(MaterialDTO entity);
        public Task RemoveAsync(MaterialDTO entity);
    }
}
