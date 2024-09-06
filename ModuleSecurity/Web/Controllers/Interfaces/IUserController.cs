using Entity.DTO;

namespace Web.Controllers.Interfaces
{
    public interface IUserController
    {
        public Task Delete(int id);
        public Task<IEnumerable<UserDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<UserDto> GetById(int id);
        public Task<UserDto> Save(UserDto userDto);
        public Task Update(UserDto userDto);
    }
}
