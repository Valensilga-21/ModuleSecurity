using Data.Interfaces;
using Entity.Context;
using Entity.DTO;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.Metrics;

namespace Data.Implements
{
    public class CountrieData : ICountrieData
    {
        private readonly ApplicationDBContext context;
        protected readonly IConfiguration configuration;

        public CountrieData(ApplicationDBContext context, IConfiguration configuration)
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
            object value = context.Countries.Update(entity);
            await context.SaveChangesAsync();
        }
         
        public async Task<Countrie> GetById(int id)
        {
            var sql = @"SELECT * FROM Country WHERE Id = @Id ORDER BY Id ASC";
            return await this.context.QueryFirstOrDefaultAsync<Countrie>(sql, new { Id = id });
        }

        public async Task<Countrie> Save(Countrie entity)
        {
            context.Countries.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(Countrie entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task<Countrie> GetByName(string name)
        {
            return await this.context.Countries.AsNoTracking().Where(item => item.Name == name).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            try
            {
                var sql = @"
                    SELECT Id, CONCAT(Name) AS TextoMostrar
                    FROM Country
                    WHERE Deleted_at IS NULL AND State = 1
                    ORDER BY Id ASC";

                return await this.context.QueryAsync<DataSelectDto>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de selección de Countries", ex);
            }
        }

        public async Task<IEnumerable<Countrie>> GetAll()
        {
            try
            {
                var sql = "SELECT * FROM Country ORDER BY Id ASC";
                return await this.context.QueryAsync<Countrie>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los Countries", ex);
            }
        }
    }
}
