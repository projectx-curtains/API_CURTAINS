using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface ICurtainsService
    {
        public IEnumerable<CurtainsDTO> GetAll();
        public Task<CurtainsDTO> GetByIdAsync(int Id);
        public Task InsertAsync(CurtainsDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(CurtainsDTO entity);
        public Task RemoveAsync(CurtainsDTO entity);
    }
}
