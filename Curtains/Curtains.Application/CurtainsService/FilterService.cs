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
        #endregion

        public FilterService(ILogger logger, IColorRepository colorRepository, ICurtainsRepository curtainsRepository)
        {
            _logger = logger;
            _colorRepository = colorRepository;
            _curtainsRepository = curtainsRepository;
        }

        #region MethodsRegion
        /// <summary>
        /// This method get <c> BaseFilter <c> 
        /// </summary>
        /// <returns> BaseFilter </returns>
        public BaseFilter GetAllCategoriesFilters()
        {
            return new BaseFilter { Colors = _colorRepository.GetAll().ToDictionary(c => c.Id, c => c.Title) };
        }
        /// <summary>
        /// This method get <c> CurtainsFilter <c> 
        /// </summary>
        /// <returns> CurtainsFilter </returns>
        public CurtainsFilter GetCurtainsFilters()
        {
            return new CurtainsFilter 
            { 
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

        Task<AccessoriesFilter> IFilterService.GetAccessoriesFilters()
        {
            throw new NotImplementedException();
        }

        Task<BedspreadsFilter> IFilterService.GetBedspreadsFilter()
        {
            throw new NotImplementedException();
        }

        Task<FabricFilter> IFilterService.GetFabricFilters()
        {
            throw new NotImplementedException();
        }

        Task<LambrequinsFilter> IFilterService.GetLambrequinsFilters()
        {
            throw new NotImplementedException();
        }

        Task<PillowsFilter> IFilterService.GetPillowsFilter()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
