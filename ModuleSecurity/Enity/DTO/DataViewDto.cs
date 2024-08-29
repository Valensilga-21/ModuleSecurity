using Entity.Model.Security;

namespace Entity.DTO
{
    public class DataViewDto
    {
    
        public Module IdModule;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool State {  get; set; }
    }
}
