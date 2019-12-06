namespace DbFirst
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListCategory = new System.Windows.Forms.Button();
            this.dgvListCategory = new System.Windows.Forms.DataGridView();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListCategory
            // 
            this.btnListCategory.Location = new System.Drawing.Point(834, 258);
            this.btnListCategory.Name = "btnListCategory";
            this.btnListCategory.Size = new System.Drawing.Size(104, 53);
            this.btnListCategory.TabIndex = 0;
            this.btnListCategory.Text = "Kategori Listele";
            this.btnListCategory.UseVisualStyleBackColor = true;
            this.btnListCategory.Click += new System.EventHandler(this.BtnListCategory_Click);
            // 
            // dgvListCategory
            // 
            this.dgvListCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCategory.Location = new System.Drawing.Point(479, 29);
            this.dgvListCategory.Name = "dgvListCategory";
            this.dgvListCategory.Size = new System.Drawing.Size(483, 223);
            this.dgvListCategory.TabIndex = 1;
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(185, 138);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(104, 34);
            this.btnCategoryAdd.TabIndex = 2;
            this.btnCategoryAdd.Text = "Kategori Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Kategori Adı :";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(146, 39);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(189, 20);
            this.txtCategoryName.TabIndex = 4;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(146, 88);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(189, 20);
            this.txtCategoryDescription.TabIndex = 6;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(35, 91);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(105, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Kategori Açıklaması :";
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(533, 258);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(114, 53);
            this.btnCategoryDelete.TabIndex = 7;
            this.btnCategoryDelete.Text = "Kategori Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 531);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCategoryAdd);
            this.Controls.Add(this.dgvListCategory);
            this.Controls.Add(this.btnListCategory);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListCategory;
        private System.Windows.Forms.DataGridView dgvListCategory;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnCategoryDelete;
    }
}

