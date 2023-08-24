using System.ComponentModel.DataAnnotations.Schema;

namespace OrderEase.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string? SupplierName { get; set; }

        //Many-to-Many Relationship with Order
        public List<Order_Supplier>? Orders_Suppliers { get; set; }
    }
}
