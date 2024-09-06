using Entity.DTO;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUserData
    {
        public Task Delete(int id);
        public Task<IEnumerable<User>> GetAll();
        Task<IEnumerable<DataSelectDto>> GetAllSelect();

        //public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<User> GetById(int id);
        //public Task<User> GetByName(string name);
        public Task<User> Save(User entity);
        public Task Update(User entity);
    }
}
