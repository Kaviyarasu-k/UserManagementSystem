namespace UserManagementSystem.Models
{
    public class UserListViewModel
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        
        public string UserName { get; set; }
        public string Email { get; set; }

        public DateTime DOB { get; set; }

        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
    }
}
