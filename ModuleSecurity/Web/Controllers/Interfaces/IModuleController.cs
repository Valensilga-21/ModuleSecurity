using Entity.DTO;

namespace Web.Controllers.Interfaces
{
    public interface IModuleController
    {
        public Task Delete(int id);
        public Task<IEnumerable<ModuleDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<ModuleDto> GetById(int id);
        public Task<ModuleDto> Save(ModuleDto moduleDto);
        public Task Update(ModuleDto moduleDto);
    }
}
