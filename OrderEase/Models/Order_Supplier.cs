using System.Security.Principal;

namespace OrderEase.Models
{
    //Joint/Junction Table (Many-to-Many Relationship Table)
    public class Order_Supplier
    {
        public int OrderID { get; set; }
        public Order? Order { get; set; }

        public int SupplierID { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
