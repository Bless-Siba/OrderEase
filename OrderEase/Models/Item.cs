using System.ComponentModel.DataAnnotations;

namespace OrderEase.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string? ItemName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        //One-to-Many Relationship with Order
        public List<Order>? Orders { get; set; }
    }
}
