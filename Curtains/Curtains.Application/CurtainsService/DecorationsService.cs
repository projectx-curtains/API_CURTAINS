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
    /// Class <c> DecorationsService </c> a default implementetion of <c> IDecorationsService </c>
    /// </summary>
    public class DecorationsService : IDecorationsService
    {
        private readonly IDecorationsRepository _decorationsRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public DecorationsService(IDecorationsRepository decorationsRepository, IMapper mapper, ILogger logger)
        {
            _decorationsRepository = decorationsRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<DecorationsDTO> GetAll()
        {
            var decorations = _mapper.Map<IEnumerable<DecorationsDTO>>(_decorationsRepository.GetAll());
            return decorations;
        }

        public async Task<DecorationsDTO> GetByIdAsync(int Id)
        {
            var decorations = await _decorationsRepository.GetByIdAsync(Id);
            if (decorations == null)
            {
                _logger.LogError("Decorations model is null");
                throw new ResourceNotFoundException("Decorations model is null");
            }
            var decorationsDTO = _mapper.Map<DecorationsDTO>(decorations);
            return decorationsDTO;
        }

        public async Task InsertAsync(DecorationsDTO entity, CancellationToken cancelationToken)
        {
            var decorations = _mapper.Map<DecorationsModel>(entity);
            if (decorations == null)
            {
                _logger.LogError("Decorations model is null");
                throw new ResourceNotFoundException("Decorations model is null");
            }
            await _decorationsRepository.InsertAsync(decorations, cancelationToken);
        }

        public async Task RemoveAsync(DecorationsDTO entity)
        {
            var decoration = _mapper.Map<DecorationsModel>(entity);
            if (decoration == null)
            {
                _logger.LogError("Decorations model is null");
                throw new ResourceNotFoundException("Decorations model is null");
            }
            await _decorationsRepository.RemoveAsync(decoration);
        }

        public async Task UpdateAsync(DecorationsDTO entity)
        {
            var decoration = _mapper.Map<DecorationsModel>(entity);
            if (decoration == null)
            {
                _logger.LogError("Decorations model is null");
                throw new ResourceNotFoundException("Decorations model is null");
            }
            await _decorationsRepository.UpdateAsync(decoration);
        }
    }
}
