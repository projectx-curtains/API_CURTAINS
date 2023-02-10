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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> BracingService </c> a default implementetion of <c> IBracingService </c>
    /// </summary>
    public class BracingService : IBracingService
    {
        private readonly IBracingRepository _bracingRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public BracingService(IBracingRepository bracingRepository, IMapper mapper, ILogger logger)
        {
            _bracingRepository = bracingRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<BracingDTO> GetAll()
        {
            var bracings = _mapper.Map<IEnumerable<BracingDTO>>(_bracingRepository.GetAll());
            return bracings;
        }

        public async Task<BracingDTO> GetByIdAsync(int Id)
        {
            var bracing = await _bracingRepository.GetByIdAsync(Id);
            if (bracing == null)
            {
                _logger.LogError("bracing model is null");
                throw new ResourceNotFoundException("bracing model is null");
            }
            var bracingDTO = _mapper.Map<BracingDTO>(bracing);
            return bracingDTO;
        }

        public async Task InsertAsync(BracingDTO entity, CancellationToken cancelationToken)
        {
            var bracing = _mapper.Map<BracingModel>(entity);
            if (bracing == null)
            {
                _logger.LogError("bracing model is null");
                throw new ResourceNotFoundException("bracing model is null");
            }
            await _bracingRepository.InsertAsync(bracing, cancelationToken);
        }

        public async Task RemoveAsync(BracingDTO entity)
        {
            var bracing = _mapper.Map<BracingModel>(entity);
            if (bracing == null)
            {
                _logger.LogError("bracing model is null");
                throw new ResourceNotFoundException("bracing model is null");
            }
            await _bracingRepository.RemoveAsync(bracing);
        }

        public async Task UpdateAsync(BracingDTO entity)
        {
            var bracing = _mapper.Map<BracingModel>(entity);
            if (bracing == null)
            {
                _logger.LogError("bracing model is null");
                throw new ResourceNotFoundException("bracing model is null");
            }
            await _bracingRepository.UpdateAsync(bracing);
        }
    }
}
