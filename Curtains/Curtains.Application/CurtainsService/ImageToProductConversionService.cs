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

        public IEnumerable<IProduct> ConvertAll(IEnumerable<ProductImageDTO> productImages)
        {
            foreach (var productImage in productImages)
            {
                yield return Convert(productImage);
            }
        }
    }
}
