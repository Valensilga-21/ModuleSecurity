using Entity.DTO;
using Entity.Model.Security;

namespace Bussines.Interfaces
{
    public interface IUserBusiness
    {
        public Task Delete(int id);
        public Task<IEnumerable<UserDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<UserDto> GetById(int id);
        public Task<User> Save(UserDto entity);
        public Task Update(UserDto entity);
    }
}
