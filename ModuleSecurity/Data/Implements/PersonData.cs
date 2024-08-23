﻿using Data.Interfaces;
using Entity.Context;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implements
{
    public class PersonData : IPersonData
    {
        private readonly ApplicationDBContext context;
        protected readonly IConfiguration configuration;

        public PersonData(ApplicationDBContext context, IConfiguration configuration)
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
            context.Persons.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task<Person> GetById(int id)
        {
            var sql = @"SELECT * FROM Person WHERE Id = @Id ORDER BY Id ASC";
            return await this.context.QueryFirstOrDefaultAsync<Person>(sql, new { Id = id });
        }
        public async Task<Person> Save(Person entity)
        {
            context.Persons.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        public async Task<Person> Update(Person entity)
        {
            context.Persons.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        public async Task<Person> GetByName(string first_name)
        {
            return await this.context.Persons.AsNoTracking().Where(item => item.First_name == first_name).FirstOrDefaultAsync();
        }
    }
}
