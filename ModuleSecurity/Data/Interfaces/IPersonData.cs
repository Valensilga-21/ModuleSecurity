using Entity.DTO;
using Entity.Model.Security;

namespace Data.Interfaces
{
    public interface IPersonData
    {
        public Task Delete(int id);
        public Task<IEnumerable<Person>> GetAll();
        public Task<Person> GetById(int id);
        public Task<Person> GetByFirst_name(string First_name);
        public Task<Person> Save(Person entity);
        public Task Update(Person entity);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
    }
}
