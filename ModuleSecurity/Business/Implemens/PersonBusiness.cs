using Business.Interfaces;
using Data.Implements;
using Data.Interfaces;
using Entity.DTO;
using Entity.Model.Security;

namespace Business.Implemens
{
    public class PersonBusiness : IPersonBusiness
    {
        protected readonly IPersonData data;

        public PersonBusiness(IPersonData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<DataPersonDto>> GetAll()
        {
            IEnumerable<Person> persons = await this.data.GetAll();
            var personDtos = persons.Select(person => new DataPersonDto
            {
                Id = person.Id,
                First_name = person.First_name,
            });
            return personDtos;
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        public async Task<DataPersonDto> GetById(int id)
        {

            Person person = await this.data.GetById(id);
            DataPersonDto personDto = new DataPersonDto();

            personDto.Id = person.Id;
            personDto.First_name = person.First_name;
            return personDto;
        }

        public Task<DataPersonDto> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Person mapData(Person person, DataPersonDto entity)
        {
            person.Id = entity.Id;
            person.First_name = entity.First_name;
            return person;
        }

        public async Task<Person> Save(DataPersonDto entity)
        {
            Person person = new Person();
            person.CreateAt = DateTime.Now.AddHours(-5);
            person = this.mapData(person, entity);

            return await this.data.Save(person);
        }

        public async Task Update(DataPersonDto entity)
        {
            Person person = await this.data.GetById(entity.Id);
            if (person == null)
            {
                throw new Exception("Registro no encontrado");
            }
            person = this.mapData(person, entity);
            await this.data.Update(person);
        }

        Task<DataPersonDto> IPersonBusiness.Save(DataPersonDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
