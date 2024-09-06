﻿using Bussines.Interfaces;
using Data.Interfaces;
using Entity.DTO;
using Entity.Model.Security;

namespace Bussines.Implements
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

        public async Task<IEnumerable<ViewDto>> GetAll()
        {
            IEnumerable<View> views = await this.data.GetAll();
            var viewDtos = views.Select(view => new ViewDto
            {
                Id = view.Id,
                Name = view.Name,
                Description = view.Description,
                //Route = view.Route,
                IdModule = view.IdModule,
                State = view.State,
            });
            return viewDtos;
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        public async Task<ViewDto> GetById(int id)
        {

            View view = await this.data.GetById(id);
            ViewDto viewDto = new ViewDto();

            viewDto.Id = view.Id;
            viewDto.Name = view.Name;
            viewDto.Description = view.Description;
            viewDto.IdModule = view.IdModule;
            viewDto.State = view.State;
            return viewDto;
        }

        public Task<ViewDto> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public View mapData(View view, ViewDto entity)
        {
            view.Id = entity.Id;
            view.Name = entity.Name;
            view.Description = entity.Description;
            view.IdModule = entity.IdModule;
            view.State = entity.State;
            return view;
        }

        public async Task<View> Save(ViewDto entity)
        {
            View view = new View();
            view.CreatedAt = DateTime.Now.AddHours(-5);
            view = this.mapData(view, entity);
            view.Module = null;

            return await this.data.Save(view);
        }

        public async Task Update(ViewDto entity)
        {
            View view = await this.data.GetById(entity.Id);
            if (view == null)
            {
                throw new Exception("Registro NO encontrado");
            }
            view = this.mapData(view, entity);
            await this.data.Update(view);
        }
    }
}
