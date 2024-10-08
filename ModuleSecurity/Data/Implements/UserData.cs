﻿using Data.Interfaces;
using Entity.Context;
using Entity.DTO;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Implements
{
    public class UserData : IUserData
        {
            private readonly ApplicationDBContext context;
            protected readonly IConfiguration configuration;

            public UserData(ApplicationDBContext context, IConfiguration configuration)
            {
                this.context = context;
                this.configuration = configuration;
            }

            public async Task Delete(int id)
            {
                var entity = await GetById(id);
                if (entity == null)
                    throw new Exception("Registro no encontrado");

                entity.DeleteAt = DateTime.Parse(DateTime.Today.ToString());
                entity.State = false;
                context.Users.Update(entity);
                await context.SaveChangesAsync();
            }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT * users AS u INNER JOIN persons AS p ON u.IdPerson = p.Id";
            return await context.QueryAsync<DataSelectDto>(sql);
        }

        public async Task<User> GetById(int id)
            {
                try
                {
                    var sql = @"SELECT * FROM Users WHERE Id = @Id ORDER BY Id ASC";
                    return await this.context.QueryFirstOrDefaultAsync<User>(sql, new { Id = id });
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public async Task<User> Save(User entity)
            {
                context.Users.Add(entity);
                await context.SaveChangesAsync();
                return entity;
            }

            public async Task Update(User entity)
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }

        public async Task<IEnumerable<User>> GetAll()
        {
            var sql = @"SELECT * FROM Users WHERE State=true ORDER BY Id ASC";
            return await this.context.QueryAsync<User>(sql);
        }
    }
}
