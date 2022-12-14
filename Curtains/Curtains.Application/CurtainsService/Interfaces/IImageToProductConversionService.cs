using Curtains.Application.ConstructorObjects.Interfaces;
using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IImageToProductConversionService
    {
        public IProduct Convert(ProductImageDTO productImage);
        public IEnumerable<IProduct> ConvertAll(IEnumerable<ProductImageDTO> productImages);
    }
}
