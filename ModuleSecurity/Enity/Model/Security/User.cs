namespace Entity.Model.Security
{
    public class User
    {
        public int Id { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public string CreateAt {  get; set; }
        public string UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool State {  get; set; }

        //Relacion con person

        private int PersonId { get; set; }
        private Person Person { get; set; }
    }
}
