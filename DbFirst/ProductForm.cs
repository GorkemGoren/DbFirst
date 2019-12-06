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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        ProductController productController = new ProductController();
        private void BtnListOrderDetail_Click(object sender, EventArgs e)
        {
            dgvListProduct.DataSource = productController.GetListProducts();            
        }

        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductName = txtProductName.Text,
                QuantityPerUnit = txtQuantity.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text),
                UnitsOnOrder = Convert.ToInt16(txtUnitsOnOrder.Text),
                ReorderLevel = Convert.ToInt16(txtReorderedLevel.Text),
                Discontinued = checkBoxDiscontinued.Checked
                
            };
            bool isAdded = productController.AddProduct(product);
        }

        private void BtnOrderDetailDelete_Click(object sender, EventArgs e)
        {
            int index = 0;
            int DeletedRows = Convert.ToInt32(dgvListProduct.CurrentRow.Cells[index].Value);
            Product product = new Product { ProductID = DeletedRows };
            productController.DeletedProduct(product);
        }
    }
}
