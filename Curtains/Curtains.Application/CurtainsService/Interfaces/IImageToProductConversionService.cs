using Curtains.Application.ConstructorObjects.Interfaces;
using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService.Interfaces
{
    /// <summary>
    /// This interface describes the Conversion service than conver product image into product that can return information required for an order.
    /// </summary>
    public interface IImageToProductConversionService
    {
        public IProduct Convert(ProductImageDTO productImage);
        public IEnumerable<IProduct> ConvertAll(IEnumerable<ProductImageDTO> productImages);
    }
}
