using Entity.DTO;
using Entity.Model.Security;

namespace Data.Interfaces
{
    public interface IRoleData
    {
        public Task Delete(int id);
        public Task<Role> GetById(int id);

        public Task<Role> Save(Role entity);

        public Task<Role> Update(Role entity);

        public Task<Role> GetByName(string name);
        Task<IEnumerable<Role>> GetAll();
        Task<IEnumerable<DataSelectDto>> GetAllSelect();

        //public Task<IEnumerable<Role>>
    }
}
