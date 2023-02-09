using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IPillowsService
    {
        public IEnumerable<PillowsDTO> GetAll();
        public Task<PillowsDTO> GetByIdAsync(int Id);
        public Task InsertAsync(PillowsDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(PillowsDTO entity);
        public Task RemoveAsync(PillowsDTO entity);
    }
}
