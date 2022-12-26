using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    /// <summary>
    /// This interface describes the interaction model of the data transfer object to the database.
    /// </summary>
    public interface IProductImageService
    {
        public IEnumerable<ProductImageDTO> GetAll();

        public IEnumerable<ProductImageDTO> GetNewItems();

        public IEnumerable<ProductImageDTO> GetPopularItems();

        public Task<ProductImageDTO> GetByIdAsync(int Id);

        public Task<IEnumerable<ProductImageDTO>> GetAllByIdAsync(int[] Ids);

        public Task InsertAsync(ProductImageDTO entity, CancellationToken cancelationToken);

        public Task UpdateAsync(ProductImageDTO entity);

        public Task RemoveAsync(ProductImageDTO entity);
    }
}