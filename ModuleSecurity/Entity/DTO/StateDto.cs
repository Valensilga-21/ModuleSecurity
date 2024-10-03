namespace Entity.DTO
{
    public class StateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool state { get; set; }
        public int CountryId { get; set; }
        public string ? Country { get; set; }

    }
}
