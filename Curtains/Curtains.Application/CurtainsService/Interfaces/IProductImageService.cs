using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsServices.Interfaces
{
    public interface IProductImageService
    {
        public IEnumerable<ProductImageDTO> GetAll();

        public IEnumerable<ProductImageDTO> GetNewItems();

        public IEnumerable<ProductImageDTO> GetPopularItems();

        public Task<ProductImageDTO> GetByIdAsync(int Id);

        public Task InsertAsync(ProductImageDTO entity, CancellationToken cancelationToken);

        public Task UpdateAsync(ProductImageDTO entity);

        public Task RemoveAsync(ProductImageDTO entity);
    }
}