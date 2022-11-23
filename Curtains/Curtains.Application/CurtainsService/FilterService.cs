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
        #endregion

        public FilterService(IMapper mapper, ILogger logger)
        {
            _logger = logger;
        }

        #region MethodsRegion
        Task<AccessoriesFilter> IFilterService.GetAccessoriesFilters()
        {
            throw new NotImplementedException();
        }

        Task<BaseFilter> IFilterService.GetAllCategoriesFilters()
        {
            throw new NotImplementedException();
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
