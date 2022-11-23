using Curtains.Application.DTO.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService.Interfaces
{
    public interface IFilterService
    {
        public CurtainsFilter GetCurtainsFilters();
        public FabricFilter GetFabricFilters();
        public LambrequinsFilter GetLambrequinsFilters();
        public PillowsFilter GetPillowsFilters();
        public BedspreadsFilter GetBedspreadsFilter();
        public AccessoriesFilter GetAccessoriesFilters();
        public BaseFilter GetAllCategoriesFilters();
    }
}
