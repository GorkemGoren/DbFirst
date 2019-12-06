using DbFirst.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.BLL
{
    public class OrderDetailController
    {
        OrderDetailManagement orderDetailManagement = new OrderDetailManagement();

        public List<Order_Detail> GetListOrderDetails()
        {
            List<Order_Detail> order_Details = orderDetailManagement.ListOrderDetail();
            return order_Details;
        }

        public bool AddOrderDetails(Order_Detail order_Detail)
        {
            bool isAdded = orderDetailManagement.AddOrderDetails(order_Detail);
            return isAdded;
        }
        public bool DeleteOrderDetails(Order_Detail order_Detail)
        {
            bool isDeleted = orderDetailManagement.DeleteOrderDetail(order_Detail);
            return isDeleted;
        }
    }
}
