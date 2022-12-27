using AutoMapper;
using Curtains.Application.ConstructorObjects;
using Curtains.Application.ConstructorObjects.Interfaces;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;

namespace Curtains.Application.CurtainsService
{
    public class ImageToProductConversionService : IImageToProductConversionService
    {
        private readonly IMapper _mapper;

        public ImageToProductConversionService(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Convert single image into product that can return information required for an order
        /// </summary>
        /// <param name="productImage">Product image that should be converted</param>
        public IProduct Convert(ProductImageDTO productImage)
        {
            return productImage switch
            {
                { Bedspreads: not null } => _mapper.Map<BedspreadsProduct>(productImage.Bedspreads),
                { Curtains: not null } => _mapper.Map<CurtainProduct>(productImage.Curtains),
                { Pillows: not null } => _mapper.Map<PillowProduct>(productImage.Pillows),
                { Sets: not null } => _mapper.Map<SetProduct>(productImage.Sets),
                { Fabrics: not null } => _mapper.Map<FabricProduct>(productImage.Fabrics),
            };
        }

        /// <summary>
        /// Convert several images into product that can return information required for an order
        /// </summary>
        /// <param name="productImages">List of product images</param>
        public IEnumerable<IProduct> ConvertAll(IEnumerable<ProductImageDTO> productImages)
        {
            foreach (var productImage in productImages)
            {
                yield return Convert(productImage);
            }
        }
    }
}
