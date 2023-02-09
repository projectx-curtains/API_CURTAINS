using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IProductSetService
    {
        public IEnumerable<ProductSetDTO> GetAll();
        public Task<ProductSetDTO> GetByIdAsync(int Id);
        public Task InsertAsync(ProductSetDTO entity, CancellationToken cancelationToken);
        public Task UpdateAsync(ProductSetDTO entity);
        public Task RemoveAsync(ProductSetDTO entity);
    }
}
