using Entity.DTO;
using Entity.Model.Security;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface ICountrieData
    {
        public Task Delete(int id);
        public Task<Countrie> GetByName(string name);
        public Task<Countrie> Save(Countrie entity);
        public Task Update(Countrie entity);
        public Task<Countrie> GetById(int id);
        public Task<IEnumerable<Countrie>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        
    }
}
