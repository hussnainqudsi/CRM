using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ILeadsInterface
    {
        Task<List<LeadsDto>> GetAll();
        Task<LeadsDto> Get(int id);
        Task<LeadsDto> Update(LeadsDto leadsDto);
        Task<LeadsDto> Add(LeadsDto leadsDto);
        Task<bool> Delete(int id);
    }
}
