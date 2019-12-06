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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        CategoryController categoryController = new CategoryController();

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                
                CategoryName = txtCategoryName.Text,
                Description = txtCategoryDescription.Text
            };
            bool isAdded = categoryController.AddCategory(category);

        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            
            int index = 0;
            int isDeletedRows = Convert.ToInt32(dgvListCategory.CurrentRow.Cells[index].Value);
            Category category = new Category { CategoryID = isDeletedRows };
            categoryController.DeleteCategory(category);
            
            
        }

        private void BtnListCategory_Click(object sender, EventArgs e)
        {
            dgvListCategory.DataSource = categoryController.GetListCategories();
        }
    }
}
