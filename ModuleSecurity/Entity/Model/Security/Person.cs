﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class Person
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Addres { get; set; }
        public string TypeDocument { get; set; }
        public Int16 Document { get; set; }
        public DateTime Birth_of_date { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public Int16 Phone { get; set; }
        public bool State { get; set; }
    }
}
