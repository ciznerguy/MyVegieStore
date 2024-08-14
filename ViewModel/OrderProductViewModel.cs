namespace MyVegieStore.ViewModel
{
    public class OrderProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }

        public double TotalPrice => UnitPrice * Quantity;
    }
}
