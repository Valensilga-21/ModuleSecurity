using Entity.DTO;
using Entity.Model.Security;

namespace Bussines.Interfaces
{
    public interface IPersonBusiness
    {
        public Task Delete(int id);
        public Task<IEnumerable<PersonDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<PersonDto> GetById(int id);
        public Task<PersonDto> GetByFirst_name(string First_name);
        public Task<Person> Save(PersonDto entity);
        public Task Update(PersonDto entity);
    }
}
