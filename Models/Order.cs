namespace MyProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? User_Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Note { get; set; }
        public float Total_Amount { get; set; }
        public byte Status { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        public User? User { get; set; }
    }
}
