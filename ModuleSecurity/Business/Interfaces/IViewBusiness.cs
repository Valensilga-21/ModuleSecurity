using Entity.DTO;
using Entity.Model.Security;

namespace Business.Interfaces
{
    public interface IViewBusiness
    {
        Task Delete(int id);

        Task<IEnumerable<DataSelectDto>> GetAll();
        Task<ViewDto> GetById(int id);
        Task<View> Save(ViewDto entity);
        Task Update(int id, ViewDto entity);
    }
}
