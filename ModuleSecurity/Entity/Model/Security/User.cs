using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public string CreateAt {  get; set; }
        public string UpdateAt { get; set; }
        public string DeleteAt { get; set; }
        public bool State {  get; set; }
    }
}
