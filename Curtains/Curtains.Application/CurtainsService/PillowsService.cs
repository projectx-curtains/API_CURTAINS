using AutoMapper;
using Curtains.Application.CurtainsService.Interfaces;
using Curtains.Application.DTO;
using Curtains.Domain.Models;
using Curtains.Infrastructure.Interfaces;
using Curtains.Infrastructure.Repositories;

namespace Curtains.Application.CurtainsService
{
    /// <summary>
    /// Class <c> PillowsService </c> a default implementetion of <c> IPillowsService </c>
    /// </summary>
    public class PillowsService : IPillowsService
    {
        private readonly IPillowsRepository _pillowRepository;
        private readonly IMapper _mapper;

        public PillowsService(IPillowsRepository pillowsRepository, IMapper mapper)
        {
            _pillowRepository = pillowsRepository;
            _mapper = mapper;
        }

        public IEnumerable<PillowsDTO> GetAll()
        {
            var pillows = _mapper.Map<IEnumerable<PillowsDTO>>(_pillowRepository.GetAll());
            return pillows;
        }

        public async Task<PillowsDTO> GetByIdAsync(int Id)
        {
            var pillow = await _pillowRepository.GetByIdAsync(Id);
            var pillowDTO = _mapper.Map<PillowsDTO>(pillow);
            return pillowDTO;
        }

        public async Task InsertAsync(PillowsDTO entity, CancellationToken cancelationToken)
        {
            var pillow = _mapper.Map<PillowsModel>(entity);
            await _pillowRepository.InsertAsync(pillow, cancelationToken);
        }

        public async Task RemoveAsync(PillowsDTO entity)
        {
            var pillow = _mapper.Map<PillowsModel>(entity);
            await _pillowRepository.RemoveAsync(pillow);
        }

        public async Task UpdateAsync(PillowsDTO entity)
        {
            var pillow = _mapper.Map<PillowsModel>(entity);
            await _pillowRepository.UpdateAsync(pillow);
        }
    }
}
