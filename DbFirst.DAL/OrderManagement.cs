using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.DAL
{
    public class OrderManagement
    {
        NORTHWNDEntities nORTHWNDEntities = new NORTHWNDEntities();

        public List<Order> GetListOrders()
        {
            List<Order> orders = nORTHWNDEntities.Orders.ToList();
            nORTHWNDEntities.SaveChanges();
            return orders;
        }
        public bool AddOrders(Order order)
        {
            nORTHWNDEntities.Set<Order>().Add(order);
            int isAdded = nORTHWNDEntities.SaveChanges();
            if (isAdded>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
