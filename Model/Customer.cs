namespace MyVegieStore.Model
{
    public class Customer : Person
    {

        public DateTime LastOrderDate { get; set; }
        public string CustomerType { get; set; }
    }
}
