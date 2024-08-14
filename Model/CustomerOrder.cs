namespace MyVegieStore.Model
{
    public class CustomerOrder
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public string DeliveryStatus { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
 
    }
}
