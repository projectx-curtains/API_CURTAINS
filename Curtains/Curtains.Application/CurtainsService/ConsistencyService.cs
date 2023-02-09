using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
using Curtains.Infrastructure.Shared.Exceptions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> ConsistencyService </c> a default implementetion of <c> IConsistencyService </c>
    /// </summary>
    public class ConsistencyService : IConsistencyService
    {
        private readonly IConsistencyRepository _consistencyRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ConsistencyService(IConsistencyRepository consistencyRepository, IMapper mapper, ILogger logger)
        {
            _consistencyRepository = consistencyRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<ConsistencyDTO> GetAll()
        {
            var consistencies = _mapper.Map<IEnumerable<ConsistencyDTO>>(_consistencyRepository.GetAll());
            return consistencies;
        }

        public async Task<ConsistencyDTO> GetByIdAsync(int Id)
        {
            var consistency = await _consistencyRepository.GetByIdAsync(Id);
            if (consistency == null)
            {
                _logger.LogError("Сonsistency model is null");
                throw new ResourceNotFoundException("Сonsistency model is null");
            }
            var consistencyDTO = _mapper.Map<ConsistencyDTO>(consistency);
            return consistencyDTO;
        }

        public async Task InsertAsync(ConsistencyDTO entity, CancellationToken cancelationToken)
        {
            var consistency = _mapper.Map<ConsistencyModel>(entity);
            if (consistency == null)
            {
                _logger.LogError("Сonsistency model is null");
                throw new ResourceNotFoundException("Сonsistency model is null");
            }
            await _consistencyRepository.InsertAsync(consistency, cancelationToken);
        }

        public async Task RemoveAsync(ConsistencyDTO entity)
        {
            var consistency = _mapper.Map<ConsistencyModel>(entity);
            if (consistency == null)
            {
                _logger.LogError("Сonsistency model is null");
                throw new ResourceNotFoundException("Сonsistency model is null");
            }
            await _consistencyRepository.RemoveAsync(consistency);
        }

        public async Task UpdateAsync(ConsistencyDTO entity)
        {
            var consistency = _mapper.Map<ConsistencyModel>(entity);
            if (consistency == null)
            {
                _logger.LogError("Сonsistency model is null");
                throw new ResourceNotFoundException("Сonsistency model is null");
            }
            await _consistencyRepository.UpdateAsync(consistency);
        }
    }
}
