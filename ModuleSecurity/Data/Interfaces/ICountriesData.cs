using Entity.DTO;
using Entity.Model.Security;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface ICountriesData
    {
        public Task Delete(int id);
        public Task<Countries> GetByName(string name);
        public Task<Countries> Save(Countries entity);
        public Task Update(Countries entity);
        public Task<Countries> GetById(int id);
        public Task<IEnumerable<Countries>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        
    }
}
