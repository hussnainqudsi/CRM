using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IDescriptionInterface
    {
        Task<List<DescriptionDto>> GetAll();
        Task<DescriptionDto> Get(int id);
        Task<DescriptionDto> Update(DescriptionDto descriptionDto);
        Task<DescriptionDto> Add(DescriptionDto descriptionDto);
        Task<bool> Delete(int id);
    }
}
