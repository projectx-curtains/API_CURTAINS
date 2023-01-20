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
    /// Class <c> CurtainsTypeService </c> a default implementetion of <c> ICurtainsTypeService </c>
    /// </summary>
    public class CurtainsTypeService : ICurtainsTypeService
    {
        private readonly ICurtainsTypeRepository _curtainsTypeRepository;
        private readonly IMapper _mapper;

        public CurtainsTypeService(ICurtainsTypeRepository curtainsTypeRepository, IMapper mapper)
        {
            _curtainsTypeRepository = curtainsTypeRepository;
            _mapper = mapper;
        }

        public IEnumerable<CurtainsTypeDTO> GetAll()
        {
            var curtainsTypes = _mapper.Map<IEnumerable<CurtainsTypeDTO>>(_curtainsTypeRepository.GetAll());
            return curtainsTypes;
        }

        public async Task<CurtainsTypeDTO> GetByIdAsync(int Id)
        {
            var curtainsType = await _curtainsTypeRepository.GetByIdAsync(Id);
            var curtainsTypeDTO = _mapper.Map<CurtainsTypeDTO>(curtainsType);
            return curtainsTypeDTO;
        }

        public async Task InsertAsync(CurtainsTypeDTO entity, CancellationToken cancelationToken)
        {
            var curtainsType = _mapper.Map<CurtainsTypeModel>(entity);
            await _curtainsTypeRepository.InsertAsync(curtainsType, cancelationToken);
        }

        public async Task RemoveAsync(CurtainsTypeDTO entity)
        {
            var curtainsType = _mapper.Map<CurtainsTypeModel>(entity);
            await _curtainsTypeRepository.RemoveAsync(curtainsType);
        }

        public async Task UpdateAsync(CurtainsTypeDTO entity)
        {
            var curtainsType = _mapper.Map<CurtainsTypeModel>(entity);
            await _curtainsTypeRepository.UpdateAsync(curtainsType);
        }
    }
}
