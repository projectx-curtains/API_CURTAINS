using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface ICurtainsKindService
    {
        public IEnumerable<CurtainsKindDTO> GetAll();
        public Task<CurtainsKindDTO> GetByIdAsync(int Id);
        public Task InsertAsync(CurtainsKindDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(CurtainsKindDTO entity);
        public Task RemoveAsync(CurtainsKindDTO entity);
    }
}
