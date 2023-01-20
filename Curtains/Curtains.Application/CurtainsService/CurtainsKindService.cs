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
    /// Class <c> CurtainsKindService </c> a default implementetion of <c> ICurtainsKindService </c>
    /// </summary>
    public class CurtainsKindService : ICurtainsKindService
    {
        private readonly ICurtainsKindRepository _curtainsKindRepostiory;
        private readonly IMapper _mapper;

        public CurtainsKindService(ICurtainsKindRepository curtainsKindRepository, IMapper mapper)
        {
            _curtainsKindRepostiory = curtainsKindRepository;
            _mapper = mapper;
        }

        public IEnumerable<CurtainsKindDTO> GetAll()
        {
            var curtainsKinds = _mapper.Map<IEnumerable<CurtainsKindDTO>>(_curtainsKindRepostiory.GetAll());
            return curtainsKinds;
        }

        public async Task<CurtainsKindDTO> GetByIdAsync(int Id)
        {
            var curtiansKind = await _curtainsKindRepostiory.GetByIdAsync(Id);
            var curtainsKindDTO = _mapper.Map<CurtainsKindDTO>(curtiansKind);
            return curtainsKindDTO;
        }

        public async Task InsertAsync(CurtainsKindDTO entity, CancellationToken cancelationToken)
        {
            var curtainsKind = _mapper.Map<CurtainsKindModel>(entity);
            await _curtainsKindRepostiory.InsertAsync(curtainsKind, cancelationToken);
        }

        public async Task RemoveAsync(CurtainsKindDTO entity)
        {
            var curtainsKind = _mapper.Map<CurtainsKindModel>(entity);
            await _curtainsKindRepostiory.RemoveAsync(curtainsKind);
        }

        public async Task UpdateAsync(CurtainsKindDTO entity)
        {
            var curtainsKind = _mapper.Map<CurtainsKindModel>(entity);
            await _curtainsKindRepostiory.UpdateAsync(curtainsKind);
        }
    }
}
