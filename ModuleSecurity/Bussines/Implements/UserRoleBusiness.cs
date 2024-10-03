using Bussines.Interfaces;
using Data.Interfaces;
using Entity.DTO;
using Entity.Model.Security;

namespace Bussines.Implements
{
    public class UserRoleBusiness : IUserRoleBusiness
    {
        protected readonly IUserRoleData data;

        public UserRoleBusiness(IUserRoleData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        public async Task<IEnumerable<UserRoleDto>> GetAll()
        {
            IEnumerable<UserRole> userroles = await this.data.GetAll();
            var userroleDtos = userroles.Select(userrole => new UserRoleDto
            {
                Id = userrole.Id,
                UserId = userrole.UserId,
                RoleId = userrole.RoleId,
                State = userrole.State,
                Name = userrole.Name,
            });
            return userroleDtos;
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        public async Task<UserRoleDto> GetById(int id)
        {

            UserRole userrole = await this.data.GetById(id);
            UserRoleDto userroleDto = new UserRoleDto();

            userroleDto.Id = userrole.Id;
            userroleDto.UserId = userrole.UserId;
            userroleDto.RoleId = userrole.RoleId;
            userroleDto.State = userrole.State;
            userroleDto.Name = userrole.Name;
            return userroleDto;
        }

        public UserRole mapData(UserRole userRole, UserRoleDto entity)
        {
            userRole.Id = entity.Id;
            userRole.UserId = entity.UserId;
            userRole.RoleId = entity.RoleId;
            userRole.State = entity.State;
            userRole.Name = entity.Name;
            return userRole;
        }

        public async Task<UserRole> Save(UserRoleDto entity)
        {
            UserRole userrole = new UserRole 
            {
                CreateAt = DateTime.Now.AddHours(-5)
            };
            userrole = this.mapData(userrole, entity);
            userrole.User = null;
            userrole.Role = null;

            return await this.data.Save(userrole);
        }

        public async Task Update(UserRoleDto entity)
        {
            UserRole userrole = await this.data.GetById(entity.Id);
            if (userrole == null)
            {
                throw new Exception("Registro no encontrado");
            }
            userrole = this.mapData(userrole, entity);
            await this.data.Update(userrole);
        }

    }
}
