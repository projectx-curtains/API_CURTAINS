using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IDesignService
    {
        public IEnumerable<DesignDTO> GetAll();
        public Task<DesignDTO> GetByIdAsync(int Id);
        public Task InsertAsync(DesignDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(DesignDTO entity);
        public Task RemoveAsync(DesignDTO entity);
    }
}
