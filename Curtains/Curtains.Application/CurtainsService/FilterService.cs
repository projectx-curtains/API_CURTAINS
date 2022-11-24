using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO.Filters;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> FilterService </c> describes the interaction model of the data transfer object to the database.
    /// </summary>
    public class FilterService : IFilterService
    {
        #region FieldsRegion
        private readonly ILogger _logger;
        private readonly IColorRepository _colorRepository;
        private readonly ICurtainsRepository _curtainsRepository;
        private readonly IFabricRepository _fabricRepository;
        private readonly IPillowsRepository _pillowsRepository;
        private readonly IBedspreadsRepository _bedspreadsRepository;
        private readonly IAccessoriesRepository _accessoriesRepository;

        private List<string> marketingInfo = new List<string> { "Новинки", "Популярное", "Распродажа" };
        #endregion

        public FilterService(ILogger logger, IColorRepository colorRepository, ICurtainsRepository curtainsRepository, 
            IFabricRepository fabricRepository, IPillowsRepository pillowsRepository, IBedspreadsRepository bedspreadsRepository,
            IAccessoriesRepository accessoriesRepository)
        {
            _logger = logger;
            _colorRepository = colorRepository;
            _curtainsRepository = curtainsRepository;
            _fabricRepository = fabricRepository;
            _pillowsRepository = pillowsRepository;
            _bedspreadsRepository = bedspreadsRepository;
            _accessoriesRepository = accessoriesRepository;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get <c> BaseFilter <c> 
        /// </summary>
        /// <returns> BaseFilter </returns>
        public BaseFilter GetAllCategoriesFilters()
        {
            return new BaseFilter
            {
                MarketingInfo = marketingInfo,
                Colors = _colorRepository.GetAll().ToDictionary(c => c.Id, c => c.Title) 
            };
        }

        /// <summary>
        /// This method get <c> CurtainsFilter <c> 
        /// </summary>
        /// <returns> CurtainsFilter </returns>
        public CurtainsFilter GetCurtainsFilters()
        {
            return new CurtainsFilter 
            {
                MarketingInfo = marketingInfo,
                MinPrice = _curtainsRepository.GetAll().GroupBy(c => c.Price).Min(c => c.Key),
                MaxPrice = _curtainsRepository.GetAll().GroupBy(c => c.Price).Max(c => c.Key),
                Colors = _curtainsRepository.GetAll().GroupBy(c => c.Fabric.Color.Id, c => c.Fabric.Color.Title)
                .ToDictionary(c => c.Key, c => c.First()),
                CurtainsTypes = _curtainsRepository.GetAll().GroupBy(c => c.CurtainsType.Id, c => c.CurtainsType.Title)
                .ToDictionary(c => c.Key, c => c.First()),
                CurtainsKinds = _curtainsRepository.GetAll().GroupBy(c => c.CurtainsKind.Id, c => c.CurtainsKind.Title)
                .ToDictionary(c => c.Key, c => c.First()),
                Purposes = _curtainsRepository.GetAll().GroupBy(c => c.Purpose).Select(c => c.Key).ToList(),
                FabricMaterials = _curtainsRepository.GetAll().GroupBy(c => c.Material.Id, c => c.Material.Title)
                .ToDictionary(c => c.Key, c => c.First()),
                Height = _curtainsRepository.GetAll().GroupBy(c => c.Height).Select(c => c.Key).ToList(),
                Width = _curtainsRepository.GetAll().GroupBy(c => c.Width).Select(c => c.Key).ToList(),
            };
        }

        /// <summary>
        /// This method get <c> FabricFilter <c> 
        /// </summary>
        /// <returns> FabricFilter </returns>
        public FabricFilter GetFabricFilters()
        {
            return new FabricFilter
            {
                MarketingInfo = marketingInfo,
                MinPrice = _fabricRepository.GetAll().GroupBy(c => c.Price).Min(c => c.Key),
                MaxPrice = _fabricRepository.GetAll().GroupBy(c => c.Price).Max(c => c.Key),
                Colors = _fabricRepository.GetAll().GroupBy(c => c.Color.Id, c => c.Color.Title)
                .ToDictionary(c => c.Key, c => c.First()),
            };
        }

        public LambrequinsFilter GetLambrequinsFilters()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method get <c> PillowsFilter <c> 
        /// </summary>
        /// <returns> PillowsFilter </returns>
        public PillowsFilter GetPillowsFilters()
        {
            return new PillowsFilter
            {
                MarketingInfo = marketingInfo,
                MinPrice = _pillowsRepository.GetAll().GroupBy(c => c.Price).Min(c => c.Key),
                MaxPrice = _pillowsRepository.GetAll().GroupBy(c => c.Price).Max(c => c.Key),
                Colors = _pillowsRepository.GetAll().GroupBy(c => c.Fabric.Color.Id, c => c.Fabric.Color.Title)
                .ToDictionary(c => c.Key, c => c.First()),
            };
        }

        /// <summary>
        /// This method get <c> BedspreadsFilter <c> 
        /// </summary>
        /// <returns> BedspreadsFilter </returns>
        public BedspreadsFilter GetBedspreadsFilters()
        {
            return new BedspreadsFilter
            {
                MarketingInfo = marketingInfo,
                MinPrice = _bedspreadsRepository.GetAll().GroupBy(c => c.Price).Min(c => c.Key),
                MaxPrice = _bedspreadsRepository.GetAll().GroupBy(c => c.Price).Max(c => c.Key),
                Colors = _bedspreadsRepository.GetAll().GroupBy(c => c.Fabric.Color.Id, c => c.Fabric.Color.Title)
                .ToDictionary(c => c.Key, c => c.First()),
                Sizes = _bedspreadsRepository.GetAll().GroupBy(c => c.Size).Select(c => c.Key).ToList()
            };
        }

        /// <summary>
        /// This method get <c> AccessoriesFilter <c> 
        /// </summary>
        /// <returns> AccessoriesFilter </returns>
        public AccessoriesFilter GetAccessoriesFilters()
        {
            return new AccessoriesFilter
            {
                MarketingInfo = marketingInfo,
                MinPrice = _accessoriesRepository.GetAll().GroupBy(c => c.Price).Min(c => c.Key),
                MaxPrice = _accessoriesRepository.GetAll().GroupBy(c => c.Price).Max(c => c.Key),
                Colors = _accessoriesRepository.GetAll().GroupBy(c => c.Color.Id, c => c.Color.Title)
                .ToDictionary(c => c.Key, c => c.First()),
            };
        }
        #endregion
    }
}
