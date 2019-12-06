using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.DAL
{
    public class OrderDetailManagement
    {
        NORTHWNDEntities nORTHWNDEntities = new NORTHWNDEntities();

        public List<Order_Detail> ListOrderDetail()
        {
            List<Order_Detail> order_Details = nORTHWNDEntities.Order_Details.ToList();
            nORTHWNDEntities.SaveChanges();
            return order_Details;
        }
        public bool AddOrderDetails(Order_Detail order_Detail)
        {
            nORTHWNDEntities.Set<Order_Detail>().Add(order_Detail);
            var isAdded = nORTHWNDEntities.SaveChanges();

            if (isAdded>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteOrderDetail(Order_Detail order_Detail)
        {
            var deletedOrderDetail = nORTHWNDEntities.Set<Order_Detail>()
                .Find(order_Detail.OrderID, order_Detail.ProductID);
            if (deletedOrderDetail != null)
            {
                nORTHWNDEntities.Set<Order_Detail>().Remove(deletedOrderDetail);
            }
            else
            {
                return false;
            }
            var isDeleted = nORTHWNDEntities.SaveChanges();
            if (isDeleted>0)
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
