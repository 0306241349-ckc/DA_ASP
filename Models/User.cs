namespace MyProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; }
        public string FullName { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; } = "Client";
        public DateTime CreateAt {  get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
        
    }
}
