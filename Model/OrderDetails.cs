namespace MyVegieStore.Model
{
    public class OrderDetails
    {
        public int OrderDetailsID { get; set; }  // Primary key
        public int OrderID { get; set; }  // Foreign key to Order
        public int ProductID { get; set; }  // Foreign key to Product

        

        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }

        

        // Navigation properties
        public CustomerOrder Order { get; set; }
        public Product Product { get; set; }
    }
}
