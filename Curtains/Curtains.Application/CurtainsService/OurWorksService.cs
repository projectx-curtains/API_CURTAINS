using Curtains.Application.Interfaces;
using Curtains.Application.DTO;
using Curtains.Infrastructure.Interfaces;
using AutoMapper;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> OurWorksService </c> describes the interaction model of the data transfer object to the database.
    /// </summary>
    public class OurWorksService : IOurWorksService
    {
        #region FieldsRegion
        private readonly IOurWorksRepository _ourWorksRepository;
        private readonly IMapper _mapper;
        #endregion

        public OurWorksService(IOurWorksRepository ourWorksRepository, IMapper mapper)
        {
            _ourWorksRepository = ourWorksRepository;
            _mapper = mapper;
        }

        #region MethodsRegion

        /// <summary>
        /// This method return all<c> our works <c> entities from database
        /// </summary>
        /// <returns>Collection of OurWorks</returns>
        public IEnumerable<OurWorksDTO> GetAll()
        {
            var ourWorks = _mapper.Map<IEnumerable<OurWorksDTO>>(_ourWorksRepository.GetAll());
            return ourWorks;
        }
        #endregion
    }
}
