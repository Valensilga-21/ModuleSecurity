﻿using Entity.Model.Security;

namespace Data.Interfaces
{
    public interface IUserRoleData
    {
        public Task Delete(int id);
        public Task<UserRole> GetById(int id);

        public Task<UserRole> Save(UserRole entity);

        public Task<UserRole> Update(UserRole entity);

        public Task<UserRole> GetByName(string createAt);
    }
}
