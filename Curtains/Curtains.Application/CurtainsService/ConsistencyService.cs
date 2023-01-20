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
    /// Class <c> ConsistencyService </c> a default implementetion of <c> IConsistencyService </c>
    /// </summary>
    public class ConsistencyService : IConsistencyService
    {
        private readonly IConsistencyRepository _consistencyRepository;
        private readonly IMapper _mapper;

        public ConsistencyService(IConsistencyRepository consistencyRepository, IMapper mapper)
        {
            _consistencyRepository = consistencyRepository;
            _mapper = mapper;
        }

        public IEnumerable<ConsistencyDTO> GetAll()
        {
            var consistencies = _mapper.Map<IEnumerable<ConsistencyDTO>>(_consistencyRepository.GetAll());
            return consistencies;
        }

        public async Task<ConsistencyDTO> GetByIdAsync(int Id)
        {
            var consistency = await _consistencyRepository.GetByIdAsync(Id);
            var consistencyDTO = _mapper.Map<ConsistencyDTO>(consistency);
            return consistencyDTO;
        }

        public async Task InsertAsync(ConsistencyDTO entity, CancellationToken cancelationToken)
        {
            var consistency = _mapper.Map<ConsistencyModel>(entity);
            await _consistencyRepository.InsertAsync(consistency, cancelationToken);
        }

        public async Task RemoveAsync(ConsistencyDTO entity)
        {
            var consistency = _mapper.Map<ConsistencyModel>(entity);
            await _consistencyRepository.RemoveAsync(consistency);
        }

        public async Task UpdateAsync(ConsistencyDTO entity)
        {
            var consistency = _mapper.Map<ConsistencyModel>(entity);
            await _consistencyRepository.UpdateAsync(consistency);
        }
    }
}
