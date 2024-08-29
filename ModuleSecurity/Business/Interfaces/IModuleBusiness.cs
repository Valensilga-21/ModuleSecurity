using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IModuleBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<DataModuleDto>> GetAll();
        Task<IEnumerable<DataModuleDto>> GetAllSelect();
        Task<DataModuleDto> GetById(int id);
        Task<DataModuleDto> GetByName(string name);
        Task<DataModuleDto> Save(DataModuleDto entity);
        Task Update(DataModuleDto entity);
    }
}
