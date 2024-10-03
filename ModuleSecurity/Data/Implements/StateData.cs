using Data.Interfaces;
using Entity.Context;
using Entity.DTO;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Implements
{
    public class StateData : IStateData
    {
        private readonly ApplicationDBContext context;
        protected readonly IConfiguration configuration;

        public StateData(ApplicationDBContext context, IConfiguration configuration)
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
            entity.state = false;
            context.States.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT cy.Name, cr.Name FROM cities cy INNER JOIN
                states s ON cy.Id = s.IdCity countries cr ON s.IdCountries = cr.Id";
            return await context.QueryAsync<DataSelectDto>(sql);
        }

        public async Task<State> Save(State entity)
        {
            context.States.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(State entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task<State> GetByName(string name)
        {
            return await this.context.States.AsNoTracking().Where(item => item.Name == name).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<State>> GetAll()
        {
            try
            {
                var sql = "SELECT * FROM States WHERE state=true ORDER BY Id ASC";
                return await this.context.QueryAsync<State>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los states", ex);
            }
        }

        public Task<State> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
