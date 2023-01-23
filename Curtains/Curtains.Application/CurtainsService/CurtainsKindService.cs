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
    /// Class <c> CurtainsKindService </c> a default implementetion of <c> ICurtainsKindService </c>
    /// </summary>
    public class CurtainsKindService : ICurtainsKindService
    {
        private readonly ICurtainsKindRepository _curtainsKindRepostiory;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public CurtainsKindService(ICurtainsKindRepository curtainsKindRepository, IMapper mapper, ILogger logger)
        {
            _curtainsKindRepostiory = curtainsKindRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public IEnumerable<CurtainsKindDTO> GetAll()
        {
            var curtainsKinds = _mapper.Map<IEnumerable<CurtainsKindDTO>>(_curtainsKindRepostiory.GetAll());
            return curtainsKinds;
        }

        public async Task<CurtainsKindDTO> GetByIdAsync(int Id)
        {
            var curtainsKind = await _curtainsKindRepostiory.GetByIdAsync(Id);
            if (curtainsKind == null)
            {
                _logger.LogError("Сurtians Kind model is null");
                throw new ResourceNotFoundException("Сurtians Kind model is null");
            }
            var curtainsKindDTO = _mapper.Map<CurtainsKindDTO>(curtainsKind);
            return curtainsKindDTO;
        }

        public async Task InsertAsync(CurtainsKindDTO entity, CancellationToken cancelationToken)
        {
            var curtainsKind = _mapper.Map<CurtainsKindModel>(entity);
            if (curtainsKind == null)
            {
                _logger.LogError("Сurtians Kind model is null");
                throw new ResourceNotFoundException("Сurtians Kind model is null");
            }
            await _curtainsKindRepostiory.InsertAsync(curtainsKind, cancelationToken);
        }

        public async Task RemoveAsync(CurtainsKindDTO entity)
        {
            var curtainsKind = _mapper.Map<CurtainsKindModel>(entity);
            if (curtainsKind == null)
            {
                _logger.LogError("Сurtians Kind model is null");
                throw new ResourceNotFoundException("Сurtians Kind model is null");
            }
            await _curtainsKindRepostiory.RemoveAsync(curtainsKind);
        }

        public async Task UpdateAsync(CurtainsKindDTO entity)
        {
            var curtainsKind = _mapper.Map<CurtainsKindModel>(entity);
            if (curtainsKind == null)
            {
                _logger.LogError("Сurtians Kind model is null");
                throw new ResourceNotFoundException("Сurtians Kind model is null");
            }
            await _curtainsKindRepostiory.UpdateAsync(curtainsKind);
        }
    }
}
