using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IFabricTypeService
    {
        public IEnumerable<FabricTypeDTO> GetAll();
        public Task<FabricTypeDTO> GetByIdAsync(int Id);
        public Task InsertAsync(FabricTypeDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(FabricTypeDTO entity);
        public Task RemoveAsync(FabricTypeDTO entity);
    }
}
