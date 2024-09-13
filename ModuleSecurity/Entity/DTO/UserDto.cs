using Entity.Model.Security;

namespace Entity.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public Person IdPerson { get; set; }
        public string Password { get; set; }
        public bool State { get; set; }
    }
}
