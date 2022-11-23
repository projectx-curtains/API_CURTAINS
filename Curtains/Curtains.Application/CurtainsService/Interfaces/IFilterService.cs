﻿using Curtains.Application.DTO.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IFilterService
    {
        public Task<CurtainsFilter> GetCurtainsFilters();
        public Task<FabricFilter> GetFabricFilters();
        public Task<LambrequinsFilter> GetLambrequinsFilters();
        public Task<PillowsFilter> GetPillowsFilter();
        public Task<BedspreadsFilter> GetBedspreadsFilter();
        public Task<AccessoriesFilter> GetAccessoriesFilters();
        public Task<BaseFilter> GetAllCategoriesFilters();
    }
}
