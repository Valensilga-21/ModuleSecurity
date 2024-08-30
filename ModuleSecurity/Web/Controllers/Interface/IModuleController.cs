using Entity.DTO;

namespace Web.Controllers.Interface
{
    public interface IModuleController
    {
        public Task Delete(int id);
        public Task<IEnumerable<DataModuleDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<DataModuleDto> GetById(int id);
        public Task<DataModuleDto> Save(DataModuleDto entity);
        public Task Update(DataModuleDto entity);
    }
}
