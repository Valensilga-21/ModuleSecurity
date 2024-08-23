using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreateAt { set; get; }
        public string UpdateAt { set; get; }
        public DateTime DeleteAt { set; get; }
        public bool State {  get; set; }

    }
}
