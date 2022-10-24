using Curtains.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsServices.Interfaces
{
    public interface IProductImageService
    {
        public IEnumerable<ProductImageDTO> GetAll();

        public Task<ProductImageDTO> GetByIdAsync(int Id);

        public Task InsertAsync(ProductImageDTO entity, CancellationToken cancelationToken);

        public Task UpdateAsync(ProductImageDTO entity);

        public Task RemoveAsync(ProductImageDTO entity);
    }
}