using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ISocietyInterface
    {
        Task<List<SocietyDto>> GetAll();
        Task<SocietyDto> Get(int id);
        Task<SocietyDto> Update(SocietyDto societyDto);
        Task<SocietyDto> Add(SocietyDto societyDto);
        Task<bool> Delete(int id);
    }
}
