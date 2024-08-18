﻿using System.Collections.Generic;
using System.Linq;
using MyVegieStore.Model;
using System.Threading.Tasks;

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
                          .Where(o => o.CustomerID == customerId)
                           .ToList();
        }

        public List<CustomerOrder> GetOrdersByStatus(OrderStatus status)
        {
            return _context.Orders
                           .Where(o => o.DeliveryStatus == status)
                           .ToList();
        }

        public List<CustomerOrder> GetOrdersForCustomerByStatus(int customerId, OrderStatus status)
        {
            return _context.Orders
                           .Where(o => o.CustomerID == customerId && o.DeliveryStatus == status)
                           .ToList();
        }

        public async Task UpdateOrderStatus(int orderId, OrderStatus newStatus)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order != null)
            {
                order.DeliveryStatus = newStatus;
                await _context.SaveChangesAsync();
            }
        }
    }
}
