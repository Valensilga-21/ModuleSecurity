﻿
using Entity.Model.Security;

namespace Data.Interfaces
{
    public interface IViewData
    {
        public Task Delete(int id);
        public Task<View> GetById(int id);

        public Task<View> Save(View entity);

        public Task<View> Update(View entity);

        public Task<View> GetByName(string name);
    }
}
