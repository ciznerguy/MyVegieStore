using System.Collections.Generic;
using System.Linq;
using MyVegieStore.Model;

namespace MyVegieStore.ViewModel
{
    public class OrderViewModel
    {
        private readonly MyVegieStoreContext _context;

        public OrderViewModel(MyVegieStoreContext context)
        {
            _context = context;
        }

        public List<CustomerOrder> GetOrdersForCustomer(int customerId)
        {
            return _context.Orders
                          .Where(o => o.CustomerID == customerId)  // Correctly using CustomerID
                           .ToList();
        }
    }
}