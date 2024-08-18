namespace MyVegieStore.Model
{
    // יצירת enum לייצוג הסטטוסים השונים של ההזמנה
    public enum OrderStatus
    {
        Pending,    // הזמנה ממתינה
        Delivered,  // הזמנה נמסרה
        Cancelled   // הזמנה בוטלה
    }

    // מחלקת CustomerOrder
    public class CustomerOrder
    {
        public int? OrderID { get; set; }
        public int? CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public OrderStatus DeliveryStatus { get; set; }  // שימוש ב-ENUM לייצוג סטטוס ההזמנה

        // Navigation properties
        public Customer Customer { get; set; }
    }
}
