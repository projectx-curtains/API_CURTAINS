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
    /// Class <c> AccessoriesService </c> a default implementetion of <c> IAccessoriesService </c>
    /// </summary>
    public class AccessoriesService : IAccessoriesService
    {
        private readonly IAccessoriesRepository _accessoriesRepository;
        private readonly IMapper _mapper;

        public AccessoriesService(IAccessoriesRepository accessoriesRepository, IMapper mapper)
        {
            _accessoriesRepository = accessoriesRepository;
            _mapper = mapper;
        }
         
        public IEnumerable<AccessoriesDTO> GetAll()
        {
            var accessories = _mapper.Map<IEnumerable<AccessoriesDTO>>(_accessoriesRepository.GetAll());
            return accessories;
        }

        public async Task<AccessoriesDTO> GetByIdAsync(int Id)
        {
            var accessories = await _accessoriesRepository.GetByIdAsync(Id);
            var accessoriesDTO = _mapper.Map<AccessoriesDTO>(accessories);
            return accessoriesDTO;
        }

        public async Task InsertAsync(AccessoriesDTO entity, CancellationToken cancelationToken)
        {
            var accessories = _mapper.Map<AccessoriesModel>(entity);
            await _accessoriesRepository.InsertAsync(accessories, cancelationToken);
        }

        public async Task RemoveAsync(AccessoriesDTO entity)
        {
            var accessory = _mapper.Map<AccessoriesModel>(entity);
            await _accessoriesRepository.RemoveAsync(accessory);
        }

        public async Task UpdateAsync(AccessoriesDTO entity)
        {
            var accessory = _mapper.Map<AccessoriesModel>(entity);
            await _accessoriesRepository.UpdateAsync(accessory);
        }
    }
}
