using Entity.DTO;
using Entity.Model.Security;

namespace Business.Interface
{
    public interface ICountrieBusiness
    {
        Task<IEnumerable<CountriesDto>> GetAll();
        Task<CountriesDto> GetById(int id);
        Task<Countrie> Save(CountriesDto entity);
        Task Update(CountriesDto entity);
        Task Delete(int id);
    }
}
