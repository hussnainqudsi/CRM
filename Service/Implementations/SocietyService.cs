using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Service.DTOs;
using Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Implementations
{
    public class SocietyService : ISocietyInterface
    {
        private ApplicationContext _applicationContext;
        private IMapper _mapper;
        public SocietyService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }
        public async Task<SocietyDto> Add(SocietyDto societyDto)
        {
            var society = _mapper.Map<Society>(societyDto);
            var savedData = await _applicationContext.Society.AddAsync(society);
            _applicationContext.SaveChanges();
            return _mapper.Map<SocietyDto>(savedData.Entity);
        }

        public async Task<bool> Delete(int id)
        {
            var society = await _applicationContext.Society.FindAsync(id);
            _applicationContext.Remove(society);
            _applicationContext.SaveChanges();
            return true;
        }

        public async Task<SocietyDto> Get(int id)
        {
            var society = await _applicationContext.Society.FindAsync(id);
            return _mapper.Map<SocietyDto>(society);
        }

        public async Task<List<SocietyDto>> GetAll()
        {
            var data = await _applicationContext.Society.ToListAsync();
            return _mapper.Map<List<SocietyDto>>(data);
        }

        public async Task<SocietyDto> Update(SocietyDto societyDto)
        {
            var data= await _applicationContext.Society.FindAsync(societyDto.SocietyId);
            _applicationContext.Entry(data).CurrentValues.SetValues(societyDto);
            _applicationContext.SaveChanges();
            return societyDto;
        }
    }
}
