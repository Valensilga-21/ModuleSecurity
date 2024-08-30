using Entity.DTO;

namespace Business.Interfaces
{
    public interface IModuleBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<DataModuleDto>> GetAll();
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<DataModuleDto> GetById(int id);
        Task<DataModuleDto> GetByName(string name);
        Task<DataModuleDto> Save(DataModuleDto entity);
    }
}
