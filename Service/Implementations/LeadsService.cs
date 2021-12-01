using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Service.DTOs;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Implementations
{
    public class LeadsService : ILeadsInterface
    {
        private ApplicationContext _applicationContext;
        private IMapper _mapper;
        public LeadsService(ApplicationContext _applicationContext, IMapper _mapper)
        {
            this._applicationContext = _applicationContext;
            this._mapper = _mapper;
        }
        public async Task<LeadsDto> Add(LeadsDto leadsDto)
        {
            var mapper = _mapper.Map<Leads>(leadsDto); 
            var SavedData= await _applicationContext.Leads.AddAsync(mapper);
            _applicationContext.SaveChanges();
            var data = new Description()
            {
                LeadId=SavedData.Entity.LeadId,
                Descriptions=leadsDto.Descrip
            };
            await _applicationContext.Description.AddAsync(data);
            _applicationContext.SaveChanges();
            return leadsDto;
        }
        public async Task<bool> Delete(int id)
        {
            var data = await _applicationContext.Leads.FindAsync(id);
            _applicationContext.Remove(data);
            var a=_applicationContext.SaveChanges();
            return true;
        }
        public async Task<LeadsDto> Get(int id)
        {
            var Lead = await _applicationContext.Leads.FindAsync(id);
            return _mapper.Map<LeadsDto>(Lead);
        }
        public async Task<List<LeadsDto>> GetAll()
        {
            var data = await _applicationContext.Leads.ToListAsync();
            var data1 = (from l in _applicationContext.Leads
                       join d in _applicationContext.Description on l.LeadId equals d.LeadId
                       select new LeadsDto
                       {
                           LeadId = d.LeadId,
                           Address=l.Address,
                           WhatsApp=l.WhatsApp,
                           ClientName=l.ClientName,
                           Descrip=d.Descriptions,
                           FollowUpDate=l.FollowUpDate,
                           Phone=l.Phone
                       });
            return _mapper.Map<List<LeadsDto>>(data);
        }
        public async Task<LeadsDto> Update(LeadsDto leadsDto)
        {
            var data = await _applicationContext.Leads.FindAsync(leadsDto.LeadId);
            _applicationContext.Entry(data).CurrentValues.SetValues(leadsDto);
            _applicationContext.SaveChanges();
            return leadsDto;
        }
    }
}
