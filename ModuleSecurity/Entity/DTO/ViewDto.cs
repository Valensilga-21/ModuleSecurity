﻿namespace Entity.DTO
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public int ModuleId { get; set; }
        public string ? Module { get; set; }
    }
}
