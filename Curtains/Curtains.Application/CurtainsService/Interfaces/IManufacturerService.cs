using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IManufacturerService
    {
        public IEnumerable<ManufacturerDTO> GetAll();
        public Task<ManufacturerDTO> GetByIdAsync(int Id);
        public Task InsertAsync(ManufacturerDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(ManufacturerDTO entity);
        public Task RemoveAsync(ManufacturerDTO entity);
    }
}
