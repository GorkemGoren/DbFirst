using DbFirst.BLL;
using DbFirst.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFirst
{
    public partial class OrderDetailForm : Form
    {
        public OrderDetailForm()
        {
            InitializeComponent();
        }
        OrderDetailController orderdetailController = new OrderDetailController();
        private void BtnCategoryAdd_Click(object sender, EventArgs e)
        {
            Order_Detail order_Detail = new Order_Detail
            {
                Discount = (float)Convert.ToDouble(txtDiscount.Text),
                Quantity = (short)Convert.ToInt32(txtQuatity.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                ProductID = Convert.ToInt32(txtProductId.Text),
                OrderID=Convert.ToInt32(txtOrderId.Text)                
            };
            bool isAdded = orderdetailController.AddOrderDetails(order_Detail);
        }

        private void BtnListOrderDetail_Click(object sender, EventArgs e)
        {
            dgvListOrderDetail.DataSource = orderdetailController.GetListOrderDetails();
        }

        private void BtnOrderDetailDelete_Click(object sender, EventArgs e)
        {
            int index = 0;
            int isDeletedRows = Convert.ToInt32(dgvListOrderDetail.CurrentRow.Cells["OrderID"].Value);
            index++;
            int isDeletedRow = Convert.ToInt32(dgvListOrderDetail.CurrentRow.Cells["ProductID"].Value);
            Order_Detail order_Detail = new Order_Detail {
                OrderID = isDeletedRows,
                ProductID = isDeletedRow
            };
            //List<Order_Detail> orginalDetails = orderdetailController.GetListOrderDetails();
            //Order_Detail original = orginalDetails.FirstOrDefault(x => x.OrderID == order_Detail.OrderID);
            orderdetailController.DeleteOrderDetails(order_Detail);
        }
    }
}
