using Curtains.Application.ConstructorObjects.Interfaces;
using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    /// <summary>
    /// This interface describes the Conversion service than conver product image into IProduct.
    /// </summary>
    public interface IImageToProductConversionService
    {
        public IProduct Convert(ProductImageDTO productImage);
        public IEnumerable<IProduct> ConvertAll(IEnumerable<ProductImageDTO> productImages);
    }
}
