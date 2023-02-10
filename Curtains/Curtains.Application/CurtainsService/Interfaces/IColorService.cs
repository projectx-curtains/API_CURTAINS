using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IColorService
    {
        public IEnumerable<ColorDTO> GetAll();
        public Task<ColorDTO> GetByIdAsync(int Id);
        public Task InsertAsync(ColorDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(ColorDTO entity);
        public Task RemoveAsync(ColorDTO entity);
    }
}
