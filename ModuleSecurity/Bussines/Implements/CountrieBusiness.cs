using Business.Interface;
using Data.Interfaces;
using Entity.DTO;
using Entity.Model.Security;

namespace Business.Implements
{
    public class CountryBusiness : ICountrieBusiness
    {
        protected readonly ICountrieData data;

        public CountryBusiness(ICountrieData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<CountriesDto>> GetAll()
        {
            IEnumerable<Countrie> countries = await this.data.GetAll();
            var countriesDtos = countries.Select(countries => new CountriesDto
            {
                Id = countries.Id,
                Name = countries.Name,
            });

            return countriesDtos;
        }

        public async Task<CountriesDto> GetById(int id)
        {
            Countrie countries = await this.data.GetById(id);
            CountriesDto countriesDto = new CountriesDto
            {
                Id = countries.Id,
                Name = countries.Name,
            };
            return countriesDto;
        }

        public Countrie mapearDatos(Countrie countries, CountriesDto entity)
        {
            countries.Id = entity.Id;
            countries.Name = entity.Name;
            return countries;
        }

        public async Task<Countrie> Save(CountriesDto entity)
        {
            Countrie countries = new Countrie
            {
                CreateAt = DateTime.Now.AddHours(-5)
            };
            countries = this.mapearDatos(countries, entity);

            return await this.data.Save(countries);
        }

        public async Task Update(CountriesDto entity)
        {
            Countrie countries = await this.data.GetById(entity.Id);
            if (countries == null)
            {
                throw new Exception("Registro no encontrado");
            }

            countries = this.mapearDatos(countries, entity);
            await this.data.Update(countries);
        }
    }
}
