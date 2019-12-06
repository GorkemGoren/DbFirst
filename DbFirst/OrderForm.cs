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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        OrderController orderController = new OrderController();
        private void BtnListOrder_Click(object sender, EventArgs e)
        {
            dgvListOrder.DataSource = orderController.GetListOrders();
        }

        private void BtnOrderAdd_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                //OrderDate = Convert.ToDateTime(txtOrderDate.Text),
                //RequiredDate = Convert.ToDateTime(txtRequiredDate.Text),
                //ShippedDate = Convert.ToDateTime(txtShippedDate.Text),
                //Freight = Convert.ToDecimal(txtFreight.Text),
                ShipName = txtShipName.Text,
                ShipAddress = txtShipAddress.Text,
                ShipCity = txtShipCity.Text,
                ShipRegion = txtShipRegion.Text,
                ShipPostalCode = txtShipPostalCode.Text,
                ShipCountry = txtShipCountry.Text
            };

            bool isAdded = orderController.AddOrders(order);
        }
    }
}
