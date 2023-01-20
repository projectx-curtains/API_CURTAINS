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
    /// Class <c> ManufacturerService </c> a default implementetion of <c> IManufacturerService </c>
    /// </summary>
    public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IMapper _mapper;

        public ManufacturerService(IManufacturerRepository manufacturerRepository, IMapper mapper)
        {
            _manufacturerRepository = manufacturerRepository;
            _mapper = mapper;
        }
        public IEnumerable<ManufacturerDTO> GetAll()
        {
            var manufaturers = _mapper.Map<IEnumerable<ManufacturerDTO>>(_manufacturerRepository.GetAll());
            return manufaturers;
        }

        public async Task<ManufacturerDTO> GetByIdAsync(int Id)
        {
            var manufacturer = await _manufacturerRepository.GetByIdAsync(Id);
            if (manufacturer == null)
            {
                _logger.LogError("Manufacturer model is null");
                throw new ResourceNotFoundException("Manufacturer model is null");
            }
            var manufacturerDTO = _mapper.Map<ManufacturerDTO>(manufacturer);
            return manufacturerDTO;
        }

        public async Task InsertAsync(ManufacturerDTO entity, CancellationToken cancelationToken)
        {
            var manufacturer = _mapper.Map<ManufacturerModel>(entity);
            if (manufacturer == null)
            {
                _logger.LogError("Manufacturer model is null");
                throw new ResourceNotFoundException("Manufacturer model is null");
            }
            await _manufacturerRepository.InsertAsync(manufacturer, cancelationToken);
        }

        public async Task RemoveAsync(ManufacturerDTO entity)
        {
            var manufacturer = _mapper.Map<ManufacturerModel>(entity);
            if (manufacturer == null)
            {
                _logger.LogError("Manufacturer model is null");
                throw new ResourceNotFoundException("Manufacturer model is null");
            }
            await _manufacturerRepository.RemoveAsync(manufacturer);
        }

        public async Task UpdateAsync(ManufacturerDTO entity)
        {
            var manufacturer = _mapper.Map<ManufacturerModel>(entity);
            if (manufacturer == null)
            {
                _logger.LogError("Manufacturer model is null");
                throw new ResourceNotFoundException("Manufacturer model is null");
            }
            await _manufacturerRepository.UpdateAsync(manufacturer);
        }
    }
}
