using Business.Interfaces;
using Data.Interfaces;
using Entity.DTO;
using Entity.Model.Security;

namespace Business.Implemens
{
    public class ViewBusiness : IViewBusiness
    {
        protected readonly IViewData data;

        public ViewBusiness(IViewData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<DataViewDto>> GetAll()
        {
            IEnumerable<View> views = await this.data.GetAll();
            var viewDtos = views.Select(view => new DataViewDto
            {
                Id = view.Id,
                Name = view.Name,
                Description = view.Description,
                IdModule = view.IdModule,
                State = view.State,
            });
            return viewDtos;
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        public async Task<DataViewDto> GetById(int id)
        {

            View view = await this.data.GetById(id);
            DataViewDto viewDto = new DataViewDto();

            viewDto.Id = view.Id;
            viewDto.Name = view.Name;
            viewDto.Description = view.Description;
            viewDto.IdModule = view.IdModule;
            viewDto.State = view.State;
            return viewDto;
        }

        public Task<DataViewDto> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public View mapData(View view, DataViewDto entity)
        {
            view.Id = entity.Id;
            view.Name = entity.Name;
            view.Description = entity.Description;
            view.IdModule = entity.IdModule;
            view.State = entity.State;
            return view;
        }

        public async Task<View> Save(DataViewDto entity)
        {
            View view = new View();
            view.CreateAt = DateTime.Now.AddHours(-5);
            view = this.mapData(view, entity);
            view.Module = null;

            return await this.data.Save(view);
        }

        public async Task Update(DataViewDto entity)
        {
            View view = await this.data.GetById(entity.Id);
            if (view == null)
            {
                throw new Exception("Registro no encontrado");
            }
            view = this.mapData(view, entity);
            await this.data.Update(view);
        }

        Task<DataViewDto> IViewBusiness.Save(DataViewDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
