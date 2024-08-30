using Entity.DTO;
using Entity.Model.Security;

namespace Data.Interfaces
{
    public interface IPersonData
    {
        public Task Delete(int id);
        public Task<Person> GetById(int id);

        public Task<Person> Save(Person entity);

        public Task<Person> Update(Person entity);

        public Task<Person> GetByName(string first_name);
        Task<IEnumerable<Person>> GetAll();
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
    }
}
