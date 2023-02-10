using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IBedspreadsService
    {
        public IEnumerable<BedspreadsDTO> GetAll();
        public Task<BedspreadsDTO> GetByIdAsync(int Id);
        public Task InsertAsync(BedspreadsDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(BedspreadsDTO entity);
        public Task RemoveAsync(BedspreadsDTO entity);
    }
}
