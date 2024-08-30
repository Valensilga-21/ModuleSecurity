using Business.Interfaces;
using Data.Interfaces;
using Entity.DTO;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implemens
{
    public class RoleBusiness : IRoleBusiness
    {
        protected readonly IRoleData data;

        public RoleBusiness(IRoleData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<DataRoleDto>> GetAll()
        {
            IEnumerable<Role> roles = await this.data.GetAll();
            var roleDtos = roles.Select(role => new DataRoleDto
            {
                Id = role.Id,
                Name = role.Name,
            });
            return roleDtos;
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        public async Task<DataRoleDto> GetById(int id)
        {

            Role role = await this.data.GetById(id);
            DataRoleDto roleDto = new DataRoleDto();

            roleDto.Id = role.Id;
            roleDto.Name = role.Name;
            return roleDto;
        }

        public Task<DataRoleDto> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Role mapData(Role role, DataRoleDto entity)
        {
            role.Id = entity.Id;
            role.Name = entity.Name;
            return role;
        }

        public async Task<Role> Save(DataRoleDto entity)
        {
            Role role = new Role();
            role.CreateAt = DateTime.Now.AddHours(-5);
            role = this.mapData(role, entity);

            return await this.data.Save(role);
        }

        public async Task Update(DataRoleDto entity)
        {
            Role role = await this.data.GetById(entity.Id);
            if (role == null)
            {
                throw new Exception("Registro no encontrado");
            }
            role = this.mapData(role, entity);
            await this.data.Update(role);
        }

        Task<DataRoleDto> IRoleBusiness.Save(DataRoleDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
