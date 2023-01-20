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
    /// Class <c> CurtainsService </c> a default implementetion of <c> ICurtainsService </c>
    /// </summary>
    public class CurtainsService : ICurtainsService
    {
        private readonly ICurtainsRepository _curtainsRepository;
        private readonly IMapper _mapper;

        public CurtainsService(ICurtainsRepository curtainsRepository, IMapper mapper)
        {
            _curtainsRepository = curtainsRepository;
            _mapper = mapper;
        }

        public IEnumerable<CurtainsDTO> GetAll()
        {
            var curtains = _mapper.Map<IEnumerable<CurtainsDTO>>(_curtainsRepository.GetAll());
            return curtains;
        }

        public async Task<CurtainsDTO> GetByIdAsync(int Id)
        {
            var curtains = await _curtainsRepository.GetByIdAsync(Id);
            var curtainsDTO = _mapper.Map<CurtainsDTO>(curtains);
            return curtainsDTO;
        }

        public async Task InsertAsync(CurtainsDTO entity, CancellationToken cancelationToken)
        {
            var curtains = _mapper.Map<CurtainsModel>(entity);
            await _curtainsRepository.InsertAsync(curtains, cancelationToken);
        }

        public async Task RemoveAsync(CurtainsDTO entity)
        {
            var curtains = _mapper.Map<CurtainsModel>(entity);
            await _curtainsRepository.RemoveAsync(curtains);
        }

        public async Task UpdateAsync(CurtainsDTO entity)
        {
            var curtains = _mapper.Map<CurtainsModel>(entity);
            await _curtainsRepository.UpdateAsync(curtains);
        }
    }
}
