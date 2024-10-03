using Entity.DTO;
using Entity.Model.Security;

namespace Bussines.Interfaces
{
    public interface IRoleBusiness
    {
        public Task Delete(int id);
        public Task<IEnumerable<RoleDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<RoleDto> GetById(int id);
        public Task<RoleDto> GetByName(string name);
        public Task<Role> Save(RoleDto entity);
        public Task Update(RoleDto entity);
    }
}
