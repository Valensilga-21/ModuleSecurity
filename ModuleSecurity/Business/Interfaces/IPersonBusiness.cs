using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IPersonBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<DataPersonDto>> GetAll();
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<DataPersonDto> GetById(int id);
        Task<DataPersonDto> GetByName(string name);
        Task<DataPersonDto> Save(DataPersonDto entity);
        Task Update(DataPersonDto entity);
    }
}
