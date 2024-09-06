using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class UserRole
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool State { get; set; }

        //Relacion entre tablas
        public User IdUser { get; set; }
        public User User { get; set; }
        public Role IdRole { get; set; }
        public Role Role { get; set; }
    }
}
