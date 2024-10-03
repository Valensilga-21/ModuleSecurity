﻿namespace Entity.Model.Security
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool state { get; set; }

        //Relacion tabla Country
        public int CountryId { get; set; }
        public Country Country { get; set; }

    }
}
