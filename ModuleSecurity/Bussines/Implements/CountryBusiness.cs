using Business.Interface;
using Data.Interfaces;
using Entity.DTO;
using Entity.Model.Security;

namespace Business.Implements
{
    public class CountryBusiness : ICountryBusiness
    {
        protected readonly ICountryData data;

        public CountryBusiness(ICountryData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<CountryDto>> GetAll()
        {
            IEnumerable<Country> countries = await this.data.GetAll();
            var countriesDtos = countries.Select(countries => new CountryDto
            {
                Id = countries.Id,
                Name = countries.Name,
                State = countries.State,
            });

            return countriesDtos;
        }

        public async Task<CountryDto> GetById(int id)
        {
            Country countries = await this.data.GetById(id);
            CountryDto countriesDto = new CountryDto
            {
                Id = countries.Id,
                Name = countries.Name,
                State = countries.State,
            };
            return countriesDto;
        }

        public Country mapearDatos(Country countries, CountryDto entity)
        {
            countries.Id = entity.Id;
            countries.Name = entity.Name;
            countries.State = entity.State;
            return countries;
        }

        public async Task<Country> Save(CountryDto entity)
        {
            Country countries = new Country
            {
                CreateAt = DateTime.Now.AddHours(-5)
            };
            countries = this.mapearDatos(countries, entity);

            return await this.data.Save(countries);
        }

        public async Task Update(CountryDto entity)
        {
            Country countries = await this.data.GetById(entity.Id);
            if (countries == null)
            {
                throw new Exception("Registro no encontrado");
            }

            countries = this.mapearDatos(countries, entity);
            await this.data.Update(countries);
        }
    }
}
