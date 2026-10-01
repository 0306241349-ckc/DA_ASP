namespace MyProject.Models
{
    public class CartItems
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; } = 1;
        public float Amount { get; set; } = 1;

    }
}
