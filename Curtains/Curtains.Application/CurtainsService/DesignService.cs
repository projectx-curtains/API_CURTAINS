﻿using AutoMapper;
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
    /// Class <c> DesignService </c> a default implementetion of <c> IDesignService </c>
    /// </summary>
    public class DesignService : IDesignService
    {
        private readonly IDesignRepository _designRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public DesignService(IDesignRepository designRepository, IMapper mapper, ILogger logger)
        {
            _designRepository = designRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<DesignDTO> GetAll()
        {
            var designs = _mapper.Map<IEnumerable<DesignDTO>>(_designRepository.GetAll());
            return designs;
        }

        public async Task<DesignDTO> GetByIdAsync(int Id)
        {
            var design = await _designRepository.GetByIdAsync(Id);
            if (design == null)
            {
                _logger.LogError("Design model is null");
                throw new ResourceNotFoundException("Design model is null");
            }
            var designDTO = _mapper.Map<DesignDTO>(design);
            return designDTO;
        }

        public async Task InsertAsync(DesignDTO entity, CancellationToken cancelationToken)
        {
            var design = _mapper.Map<DesignModel>(entity);
            if (design == null)
            {
                _logger.LogError("Design model is null");
                throw new ResourceNotFoundException("Design model is null");
            }
            await _designRepository.InsertAsync(design, cancelationToken);
        }

        public async Task RemoveAsync(DesignDTO entity)
        {
            var design = _mapper.Map<DesignModel>(entity);
            if (design == null)
            {
                _logger.LogError("Design model is null");
                throw new ResourceNotFoundException("Design model is null");
            }
            await _designRepository.RemoveAsync(design);
        }

        public async Task UpdateAsync(DesignDTO entity)
        {
            var design = _mapper.Map<DesignModel>(entity);
            if (design == null)
            {
                _logger.LogError("Design model is null");
                throw new ResourceNotFoundException("Design model is null");
            }
            await _designRepository.UpdateAsync(design);
        }
    }
}