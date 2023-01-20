using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
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

        public BracingService(IBracingRepository bracingRepository, IMapper mapper)
        {
            _bracingRepository = bracingRepository;
            _mapper = mapper;
        }

        public IEnumerable<BracingDTO> GetAll()
        {
            var bracings = _mapper.Map<IEnumerable<BracingDTO>>(_bracingRepository.GetAll());
            return bracings;
        }

        public async Task<BracingDTO> GetByIdAsync(int Id)
        {
            var bracing = await _bracingRepository.GetByIdAsync(Id);
            var bracingDTO = _mapper.Map<BracingDTO>(bracing);
            return bracingDTO;
        }

        public async Task InsertAsync(BracingDTO entity, CancellationToken cancelationToken)
        {
            var bracing = _mapper.Map<BracingModel>(entity);
            await _bracingRepository.InsertAsync(bracing, cancelationToken);
        }

        public async Task RemoveAsync(BracingDTO entity)
        {
            var bracing = _mapper.Map<BracingModel>(entity);
            await _bracingRepository.RemoveAsync(bracing);
        }

        public async Task UpdateAsync(BracingDTO entity)
        {
            var bracing = _mapper.Map<BracingModel>(entity);
            await _bracingRepository.UpdateAsync(bracing);
        }
    }
}
