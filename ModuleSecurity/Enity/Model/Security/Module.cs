using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    internal class Module
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string CreatedAt { get; set; }
        public string UpdateAt { get; set; }
        public string DeleteAt { get; set; }
        public bool State {  get; set; }
    }
}
