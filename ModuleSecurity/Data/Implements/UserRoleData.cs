﻿using Data.Interfaces;
using Entity.Context;
using Entity.DTO;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Linq.Expressions;

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
                    throw new Exception("Registro no encontrado");

                entity.DeletedAt = DateTime.Parse(DateTime.Today.ToString());
                context.UserRoles.Update(entity);
                await context.SaveChangesAsync();
            }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT Id AS TextoMostrar
                        FROM UserRole
                        WHERE Deleted_at IS NULL AND State = 1
                        ORDER BY Id ASC";
            return await context.QueryAsync<DataSelectDto>(sql);
        }

        public async Task<UserRole> GetById(int id)
            {
                try
                {
                    var sql = @"SELECT * FROM UserRole WHERE Id = @Id ORDER BY Id ASC";
                    return await this.context.QueryFirstOrDefaultAsync<UserRole>(sql, new { Id = id });
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public async Task<UserRole> Save(UserRole entity)
            {
                context.UserRoles.Add(entity);
                await context.SaveChangesAsync();
                return entity;
            }

            public async Task Update(UserRole entity)
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }

            //public async Task<UserRole> GetByName(string name)
            //{
            //    return await this.context.Roles.AsNoTracking().Where(item => item.Name == name).FirstOrDefaultAsync();
            //}

        public async Task<IEnumerable<UserRole>> GetAll()
        {
            var sql = @"SELECT * FROM UserRole ORDER BY Id ASC";
            return await this.context.QueryAsync<UserRole>(sql);
        }
    }
}
