namespace Entity.DTO
{
    public class UserRoleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool State { get; set; }
    }
}
