using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface ICurtainsTypeService
    {
        public IEnumerable<CurtainsTypeDTO> GetAll();
        public Task<CurtainsTypeDTO> GetByIdAsync(int Id);
        public Task InsertAsync(CurtainsTypeDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(CurtainsTypeDTO entity);
        public Task RemoveAsync(CurtainsTypeDTO entity);
    }
}
