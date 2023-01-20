using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
using Curtains.Infrastructure.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> LambrequinsService </c> a default implementetion of <c> ILambrequinsService </c>
    /// </summary>
    public class LambrequinsService : ILambrequinsService
    {
        private readonly ILambrequinsRepository _lamberquinsRepository;
        private readonly IMapper _mapper;

        public LambrequinsService(ILambrequinsRepository lambrequinsRepository, IMapper mapper)
        {
            _lamberquinsRepository = lambrequinsRepository;
            _mapper = mapper;
        }

        public IEnumerable<LambrequinsDTO> GetAll()
        {
            var lambrequins = _mapper.Map<IEnumerable<LambrequinsDTO>>(_lamberquinsRepository.GetAll());
            return lambrequins;
        }

        public async Task<LambrequinsDTO> GetByIdAsync(int Id)
        {
            var lambrequins = await _lamberquinsRepository.GetByIdAsync(Id);
            if (lambrequins == null)
            {
                _logger.LogError("Lambrequins model is null");
                throw new ResourceNotFoundException("Lambrequins model is null");
            }
            var lambrequinsDTO = _mapper.Map<LambrequinsDTO>(lambrequins);
            return lambrequinsDTO;
        }

        public async Task InsertAsync(LambrequinsDTO entity, CancellationToken cancelationToken)
        {
            var lambrequins = _mapper.Map<LambrequinsModel>(entity);
            if (lambrequins == null)
            {
                _logger.LogError("Lambrequins model is null");
                throw new ResourceNotFoundException("Lambrequins model is null");
            }
            await _lamberquinsRepository.InsertAsync(lambrequins, cancelationToken);
        }

        public async Task RemoveAsync(LambrequinsDTO entity)
        {
            var lambrequins = _mapper.Map<LambrequinsModel>(entity);
            if (lambrequins == null)
            {
                _logger.LogError("Lambrequins model is null");
                throw new ResourceNotFoundException("Lambrequins model is null");
            }
            await _lamberquinsRepository.RemoveAsync(lambrequins);
        }

        public async Task UpdateAsync(LambrequinsDTO entity)
        {
            var lambrequins = _mapper.Map<LambrequinsModel>(entity);
            if (lambrequins == null)
            {
                _logger.LogError("Lambrequins model is null");
                throw new ResourceNotFoundException("Lambrequins model is null");
            }
            await _lamberquinsRepository.UpdateAsync(lambrequins);
        }
    }
}
