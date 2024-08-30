using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRoleBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<DataRoleDto>> GetAll();
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<DataRoleDto> GetById(int id);
        Task<DataRoleDto> GetByName(string name);
        Task<DataRoleDto> Save(DataRoleDto entity);
        Task Update(DataRoleDto entity);
    }
}
