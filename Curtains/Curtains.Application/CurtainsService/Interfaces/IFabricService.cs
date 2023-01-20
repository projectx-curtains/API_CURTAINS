using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IFabricService
    {
        public IEnumerable<FabricDTO> GetAll();
        public Task<FabricDTO> GetByIdAsync(int Id);
        public Task InsertAsync(FabricDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(FabricDTO entity);
        public Task RemoveAsync(FabricDTO entity);
    }
}
