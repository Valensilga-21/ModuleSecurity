﻿

using Entity.Model.Security;

namespace Data.Interfaces
{
    public interface IRoleViewData
    {
        public Task Delete(int id);
        public Task<RoleView> GetById(int id);

        public Task<RoleView> Save(RoleView entity);

        public Task<RoleView> Update(RoleView entity);

        public Task<RoleView> GetByName(string createAt);
    }
}
