using Business.Interfaces;
using Entity.DTO;
using Entity.Model.Security;

namespace Business.Implemens
{
    public class ViewBusiness : IViewBusiness
    {
        protected readonly IViewBusiness data;

        public ViewBusiness(IViewBusiness data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<DataViewDto>> GetAll()
        {
            IEnumerable<View> views = await this.data.GetAll()
            var viewsDtos = views.Select(view => new ViewDto
            {
                Id = view.Id,
                Name = view.Name,
                Description = view.Description,
                Route = view.Route,
                ModuloId = view.ModuloId,
                State = view.State = view.ModuloId,
            });
            return viewsDtos;
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        public async Task<ViewDto> GetById(int id)
        {
            View view = await this.data.GetById(id);
            ViewDto viewDto = new ViewDto();
            {
                viewDto.Id = view.Id;
                viewDto.Name = view.Name;
                viewDto.Description = view.Description;
                viewDto.Route = view.Route;
                viewDto.ModuloId = view.ModuloId;
                viewDto.State = view.State;
                return viewDto;
            }
        public View mapearDatos(View view, ViewDto entity)
        {
            view.Id = entity.Id;
            view.Name = entity.Name;
            view.Description = entity.Description;
            view.Route = entity.Route;
            view.ModuloId = entity.ModuloId;
            view.State = entity.State;
            return view;
        }

        public async Task<View> Save(ViewDto entity)
        {
            View view = await this.data.GetById(entity.Id);
            if (view == null)
            {
                throw new Exception("Registro no encontrado");
            }
            view = this.mapearDatos(view, entity);

            await this.data.Update(view);
        }
    }
}
