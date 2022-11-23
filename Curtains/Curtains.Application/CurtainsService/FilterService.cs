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
        #endregion

        public FilterService(ILogger logger, IColorRepository colorRepository)
        {
            _logger = logger;
            _colorRepository = colorRepository;
        }

        #region MethodsRegion
        Task<AccessoriesFilter> IFilterService.GetAccessoriesFilters()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method get <c> BaseFilter <c> 
        /// </summary>
        /// <returns> BaseFilter </returns>
        public BaseFilter GetAllCategoriesFilters()
        {
            return new BaseFilter { Colors = _colorRepository.GetAll().ToDictionary(c => c.Id, c => c.Title)};
        }

        Task<BedspreadsFilter> IFilterService.GetBedspreadsFilter()
        {
            throw new NotImplementedException();
        }

        Task<CurtainsFilter> IFilterService.GetCurtainsFilters()
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
