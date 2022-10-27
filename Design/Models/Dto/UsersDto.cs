namespace Design.Models.Dto
{
    public class UsersDto
    {
        public string Id { get; set; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public DateTime DoB { set; get; }
        public bool isDelete { set; get; }
    }
}
