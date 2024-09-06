using Entity.DTO;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IRoleViewData
    {
        public Task Delete(int id);
        public Task<IEnumerable<RoleView>> GetAll();
        Task<IEnumerable<DataSelectDto>> GetAllSelect();

        //public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<RoleView> GetById(int id);
        //public Task<RoleView> GetByName(string name);
        public Task<RoleView> Save(RoleView entity);
        public Task Update(RoleView entity);
    }
}
