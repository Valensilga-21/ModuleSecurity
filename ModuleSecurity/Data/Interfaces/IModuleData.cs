using Entity.DTO;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IModuleData
    {
        public Task Delete(int id);
        public Task<IEnumerable<Module>> GetAll();

        //public Task<IEnumerable<Module>> GetAll();

        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<Module> GetById(int id);
        //public Task<Module> GetByDescription(string Description);
        public Task<Module> Save(Module entity);
        public Task Update(Module entity);
    }
}
