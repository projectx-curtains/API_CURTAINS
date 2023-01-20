using Curtains.Application.DTO;
using Curtains.Infrastructure.Interfaces;
using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Infrastructure.Repositories;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Shared.Exceptions;

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

        public async Task<OurWorksDTO> GetByIdAsync(int Id)
        {
            var ourWork = await _ourWorksRepository.GetByIdAsync(Id);
            if (ourWork == null)
            {
                _logger.LogError("Our work model is null");
                throw new ResourceNotFoundException("Our work model is null");
            }
            var ourWorksDTO = _mapper.Map<OurWorksDTO>(ourWork);
            return ourWorksDTO;
        }

        public async Task InsertAsync(OurWorksDTO entity, CancellationToken cancelationToken)
        {
            var ourWork = _mapper.Map<OurWorksModel>(entity);
            if (ourWork == null)
            {
                _logger.LogError("Our work model is null");
                throw new ResourceNotFoundException("Our work model is null");
            }
            await _ourWorksRepository.InsertAsync(ourWork, cancelationToken);
        }

        public async Task RemoveAsync(OurWorksDTO entity)
        {
            var ourWork = _mapper.Map<OurWorksModel>(entity);
            if (ourWork == null)
            {
                _logger.LogError("Our work model is null");
                throw new ResourceNotFoundException("Our work model is null");
            }
            await _ourWorksRepository.RemoveAsync(ourWork);
        }

        public async Task UpdateAsync(OurWorksDTO entity)
        {
            var ourWork = _mapper.Map<OurWorksModel>(entity);
            if (ourWorks == null)
            {
                _logger.LogError("Our work model is null");
                throw new ResourceNotFoundException("Our work model is null");
            }
            await _ourWorksRepository.UpdateAsync(ourWork);
        }
        #endregion
    }
}
