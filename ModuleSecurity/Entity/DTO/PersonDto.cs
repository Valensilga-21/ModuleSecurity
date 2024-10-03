namespace Entity.DTO
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Addres { get; set; }
        public string TypeDocument { get; set; }
        public string Document { get; set; }
        public DateTime Birth_of_date { get; set; }
        public string Phone { get; set; }
        public bool State { get; set; }
        public int CityId { get; set; }
        public string ? City { get; set; }
    }
}
