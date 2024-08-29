using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class RoleView
    {
        public int Id { get; set; }
        public string CreateAt { get; set; }
        public string UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool State {  get; set; }

        public Role IdRole { get; set; }
        public Role Role { get; set; }
        public View IdView { get; set; }
        public View View { get; set; }
    }
}
