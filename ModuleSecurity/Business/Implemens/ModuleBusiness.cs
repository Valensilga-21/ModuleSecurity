using Business.Interfaces;
using Data.Implements;
using Data.Interfaces;
using Entity.DTO;
using System.Reflection;

namespace Business.Implemens
{
    public class ModuleBusiness : IModuleBusiness
    {
        protected readonly IModuleData data;

        public ModuleBusiness(IModuleData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<DataModuleDto>> GetAll()
        {
            IEnumerable<Module> modules = await this.data.GetAll();
            var moduleDtos = modules.Select(module => new DataModuleDto
            {
                Id = module.Id,
                Description = module.Description,
                State = module.State,
            });
            return moduleDtos;
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        public async Task<DataModuleDto> GetById(int id)
        {

            Module module = await this.data.GetById(id);
            DataModuleDto moduleDto = new DataModuleDto();

            moduleDto.Id = module.Id;
            moduleDto.Description = module.Description;
            moduleDto.State = module.State;
            return moduleDto;
        }

        public async Task<Module> Save(DataModuleDto entity)
        {
            Module module = new Module();
            module.CreatedAt = DateTime.Now.AddHours(-5);
            module = this.mapData(module, entity);

            return await this.data.Save(module);
        }

        public async Task<Module> Save(DataModuleDto entity)
        {
            Module module = new Module();
            module.CreateAt = DateTime.Now.AddHours(-5);
            module = this.mapData(module, entity);
            module.Module = null;

            return await this.data.Save(module);
        }

        public async Task Update(DataModuleDto entity)
        {
            Module module = await this.data.GetById(entity.Id);
            if (module == null)
            {
                throw new Exception("Registro no encontrado");
            }
            module = this.mapData(module, entity);
            await this.data.Update(module);
        }

        Task<DataModuleDto> IModuleBusiness.Save(DataModuleDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
}
