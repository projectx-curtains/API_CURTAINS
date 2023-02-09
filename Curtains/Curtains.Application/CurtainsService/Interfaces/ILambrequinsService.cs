using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface ILambrequinsService
    {
        public IEnumerable<LambrequinsDTO> GetAll();
        public Task<LambrequinsDTO> GetByIdAsync(int Id);
        public Task InsertAsync(LambrequinsDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(LambrequinsDTO entity);
        public Task RemoveAsync(LambrequinsDTO entity);
    }
}
