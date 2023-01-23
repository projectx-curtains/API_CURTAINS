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
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> ColorService </c> a default implementetion of <c> IColorService </c>
    /// </summary>
    public class ColorService : IColorService
    {
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ColorService(IColorRepository colorRepository, IMapper mapper, ILogger logger)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<ColorDTO> GetAll()
        {
            var colors = _mapper.Map<IEnumerable<ColorDTO>>(_colorRepository.GetAll());
            return colors;
        }

        public async Task<ColorDTO> GetByIdAsync(int Id)
        {
            var color = await _colorRepository.GetByIdAsync(Id);
            if (color == null)
            {
                _logger.LogError("color model is null");
                throw new ResourceNotFoundException("color model is null");
            }
            var colorDTO = _mapper.Map<ColorDTO>(color);
            return colorDTO;
        }

        public async Task InsertAsync(ColorDTO entity, CancellationToken cancelationToken)
        {
            var color = _mapper.Map<ColorModel>(entity);
            if (color == null)
            {
                _logger.LogError("color model is null");
                throw new ResourceNotFoundException("color model is null");
            }
            await _colorRepository.InsertAsync(color, cancelationToken);
        }

        public async Task RemoveAsync(ColorDTO entity)
        {
            var color = _mapper.Map<ColorModel>(entity);
            if (color == null)
            {
                _logger.LogError("color model is null");
                throw new ResourceNotFoundException("color model is null");
            }
            await _colorRepository.RemoveAsync(color);
        }

        public async Task UpdateAsync(ColorDTO entity)
        {
            var color = _mapper.Map<ColorModel>(entity);
            if (color == null)
            {
                _logger.LogError("color model is null");
                throw new ResourceNotFoundException("color model is null");
            }
            await _colorRepository.UpdateAsync(color);
        }
    }
}
