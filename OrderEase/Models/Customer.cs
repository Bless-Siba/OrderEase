namespace OrderEase.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        //One-to-Many Relationship with Order
        public List<Order>? Orders { get; set; }
    }
}
