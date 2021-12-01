using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Service.DTOs;
using Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Implementations
{
    public class DescriptionService : IDescriptionInterface
    {
        private ApplicationContext _applicationContext;
        private IMapper _mapper;
        public DescriptionService(ApplicationContext _applicationContext, IMapper _mapper)
        {
            this._applicationContext = _applicationContext;
            this._mapper = _mapper;
        }
        public async Task<DescriptionDto> Add(DescriptionDto descriptionDto)
        {
            var mapperDescription = _mapper.Map<Description>(descriptionDto);
            var savedData = await _applicationContext.Description.AddAsync(mapperDescription);
            _applicationContext.SaveChanges();
            return _mapper.Map<DescriptionDto>(savedData.Entity);
        }

        public async Task<bool> Delete(int id)
        {
            var data = await _applicationContext.Description.FindAsync(id);
            _applicationContext.Remove(data);
            _applicationContext.SaveChanges();
            return true;
        }

        public async Task<DescriptionDto> Get(int id)
        {
            var data = await _applicationContext.Description.FindAsync(id);
            return _mapper.Map<DescriptionDto>(data);
        }

        public async Task<List<DescriptionDto>> GetAll()
        {
            var dataList = await _applicationContext.Description.ToListAsync();
            return _mapper.Map<List<DescriptionDto>>(dataList);
        }

        public async Task<DescriptionDto> Update(DescriptionDto descriptionDto)
        {
            var data = await _applicationContext.Description.FindAsync(descriptionDto.DescriptionId);
            _applicationContext.Entry(data).CurrentValues.SetValues(descriptionDto);
            _applicationContext.SaveChanges();
            return descriptionDto;
        }
    }
}