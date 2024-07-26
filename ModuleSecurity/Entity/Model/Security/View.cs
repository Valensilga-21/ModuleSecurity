using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    internal class View
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreateAt { get; set; }
        public string UpdateAt { get; set; }
        public string DeleteAt { get; set; }
    }
}
