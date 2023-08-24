using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderEase.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string? Supplier { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double TotalPrice { get; set; }

        //Man-to-Many Relationship with Supplier
        public List<Order_Supplier>? Orders_Suppliers { get; set; }

        //Existing Relationship with Item
        public int ItemID { get; set; }
        [ForeignKey("ItemID")]
        public Item? Item { get; set; }

    }
}
