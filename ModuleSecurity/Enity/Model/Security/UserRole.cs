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
        public string CreateAt { get; set; }
        public string UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool State { get; set; }

        public User idUser { get; set; }
        public User User { get; set; }
        public Role idRole { get; set; }

        public Role Role { get; set; }

    }
}
