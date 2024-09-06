using Entity.DTO;
using Entity.Model.Security;

namespace Bussines.Interfaces
{
    public interface IRoleViewBusiness
    {
        public Task Delete(int id);
        public Task<IEnumerable<RoleViewDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<RoleViewDto> GetById(int id);
        public Task<RoleView> Save(RoleViewDto entity);
        public Task Update(RoleViewDto entity);
    }
}
