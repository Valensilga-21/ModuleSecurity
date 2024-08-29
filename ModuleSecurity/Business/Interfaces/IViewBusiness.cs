using Entity.DTO;

namespace Business.Interfaces
{
    public interface IViewBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<DataViewDto>> GetAll();
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<DataViewDto> GetById(int id);
        Task<DataViewDto> GetByName(string name);
        Task<DataViewDto> Save(DataViewDto entity);
        Task Update(DataViewDto entity);
    }
}
