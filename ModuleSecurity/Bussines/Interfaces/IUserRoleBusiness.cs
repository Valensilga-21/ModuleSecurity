﻿using Entity.DTO;
using Entity.Model.Security;

namespace Bussines.Interfaces
{
    public interface IUserRoleBusiness
    {
        public Task Delete(int id);
        public Task<IEnumerable<UserRoleDto>> GetAll();
        public Task<IEnumerable<DataSelectDto>> GetAllSelect();
        public Task<UserRoleDto> GetById(int id);
        public Task<UserRole> Save(UserRoleDto entity);
        public Task Update(UserRoleDto entity);
    }
}
