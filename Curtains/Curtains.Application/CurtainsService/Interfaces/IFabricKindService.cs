using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IFabricKindService
    {
        public IEnumerable<FabricKindDTO> GetAll();
        public Task<FabricKindDTO> GetByIdAsync(int Id);
        public Task InsertAsync(FabricKindDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(FabricKindDTO entity);
        public Task RemoveAsync(FabricKindDTO entity);
    }
}
