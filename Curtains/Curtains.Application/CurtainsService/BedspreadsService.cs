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
    /// Class <c> BedspreadsService </c> a default implementetion of <c> IBedspreadsService </c>
    /// </summary>
    public class BedspreadsService : IBedspreadsService
    {
        private readonly IBedspreadsRepository _bedspreadsRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public BedspreadsService(IBedspreadsRepository bedspreadsRepository, IMapper mapper, ILogger logger)
        {
            _bedspreadsRepository = bedspreadsRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<BedspreadsDTO> GetAll()
        {
            var bedspreads = _mapper.Map<IEnumerable<BedspreadsDTO>>(_bedspreadsRepository.GetAll());
            return bedspreads;
        }

        public async Task<BedspreadsDTO> GetByIdAsync(int Id)
        {
            var bedspreads = await _bedspreadsRepository.GetByIdAsync(Id);
            if (bedspreads == null)
            {
                _logger.LogError("Bedspreads model is null");
                throw new ResourceNotFoundException("Bedspreads model is null");
            }
            var bedspreadsDTO = _mapper.Map<BedspreadsDTO>(bedspreads);
            return bedspreadsDTO;
        }

        public async Task InsertAsync(BedspreadsDTO entity, CancellationToken cancelationToken)
        {
            var bedspread = _mapper.Map<BedspreadsModel>(entity);
            if (bedspread == null)
            {
                _logger.LogError("Bedspreads model is null");
                throw new ResourceNotFoundException("Bedspreads model is null");
            }
            await _bedspreadsRepository.InsertAsync(bedspread, cancelationToken);
        }

        public async Task RemoveAsync(BedspreadsDTO entity)
        {
            var bedspread = _mapper.Map<BedspreadsModel>(entity);
            if (bedspread == null)
            {
                _logger.LogError("Bedspreads model is null");
                throw new ResourceNotFoundException("Bedspreads model is null");
            }
            await _bedspreadsRepository.RemoveAsync(bedspread);
        }

        public async Task UpdateAsync(BedspreadsDTO entity)
        {
            var bedspread = _mapper.Map<BedspreadsModel>(entity);
            if (bedspread == null)
            {
                _logger.LogError("Bedspreads model is null");
                throw new ResourceNotFoundException("Bedspreads model is null");
            }
            await _bedspreadsRepository.UpdateAsync(bedspread);
        }
    }
}
