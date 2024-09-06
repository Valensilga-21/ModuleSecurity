using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class RoleViewDto
    {
        public int Id { get; set; }
        public Role IdRole { get; set; }
        public View IdView { get; set; }
        public bool State { get; set; }
    }
}
