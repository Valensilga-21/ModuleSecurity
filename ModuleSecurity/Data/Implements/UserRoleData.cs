﻿using Data.Interfaces;
using Entity.Context;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Implements
{
    public class UserRoleData : IUserRoleData
    {
        private readonly ApplicationDBContext context;
        protected readonly IConfiguration configuration;

        public UserRoleData(ApplicationDBContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                throw new Exception("Registro no encontrado");
            }
            entity.DeleteAt = DateTime.Parse(DateTime.Today.ToString());
            context.UserRoles.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task<UserRole> GetById(int id)
        {
            var sql = @"SELECT * FROM UserRole WHERE Id = @Id ORDER BY Id ASC";
            return await this.context.QueryFirstOrDefaultAsync<UserRole>(sql, new { Id = id });
        }
        public async Task<UserRole> Save(UserRole entity)
        {
            context.UserRoles.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        public async Task<UserRole> Update(UserRole entity)
        {
            context.UserRoles.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        public async Task<UserRole> GetByName(string createAt)
        {
            return await this.context.UserRoles.AsNoTracking().Where(item => item.CreateAt == createAt).FirstOrDefaultAsync();
        }
    }
}
