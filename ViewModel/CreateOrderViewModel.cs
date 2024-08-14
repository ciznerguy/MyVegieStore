using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVegieStore.ViewModel
{
    public class CreateOrderViewModel
    {
        public int CustomerID { get; set; }

        [Required]
        public List<OrderProductViewModel> Products { get; set; } = new List<OrderProductViewModel>();

        public double TotalAmount => CalculateTotalAmount();

        private double CalculateTotalAmount()
        {
            double total = 0;
            foreach (var product in Products)
            {
                total += product.TotalPrice;
            }
            return total;
        }
    }
}
