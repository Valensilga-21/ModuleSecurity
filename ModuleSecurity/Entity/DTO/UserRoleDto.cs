using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class UserRoleDto
    {
        public int Id { get; set; }
        public User IdUser { get; set; }
        public Role IdRole { get; set; }
        public bool State { get; set; }
    }
}
