using DbFirst.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.BLL
{
    public class OrderController
    {
        OrderManagement orderManagement = new OrderManagement();
        public List<Order> GetListOrders()
        {
            List<Order> orders = orderManagement.GetListOrders();
            return orders;
        }
        public bool AddOrders(Order order)
        {
            bool isAdded = orderManagement.AddOrders(order);
            return isAdded;
        }
    }
}
