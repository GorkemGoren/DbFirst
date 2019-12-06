namespace DbFirst
{
    partial class ProductForm
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
            this.btnOrderDetailDelete = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.btnListOrderDetail = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReorderedLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxDiscontinued = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderDetailDelete
            // 
            this.btnOrderDetailDelete.Location = new System.Drawing.Point(510, 267);
            this.btnOrderDetailDelete.Name = "btnOrderDetailDelete";
            this.btnOrderDetailDelete.Size = new System.Drawing.Size(114, 53);
            this.btnOrderDetailDelete.TabIndex = 23;
            this.btnOrderDetailDelete.Text = "Product Sil";
            this.btnOrderDetailDelete.UseVisualStyleBackColor = true;
            this.btnOrderDetailDelete.Click += new System.EventHandler(this.BtnOrderDetailDelete_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(137, 48);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(189, 20);
            this.txtProductName.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Product Adı :";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(175, 369);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(104, 34);
            this.btnProductAdd.TabIndex = 18;
            this.btnProductAdd.Text = "Product Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.BtnProductAdd_Click);
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProduct.Location = new System.Drawing.Point(456, 38);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.Size = new System.Drawing.Size(483, 223);
            this.dgvListProduct.TabIndex = 17;
            // 
            // btnListOrderDetail
            // 
            this.btnListOrderDetail.Location = new System.Drawing.Point(811, 267);
            this.btnListOrderDetail.Name = "btnListOrderDetail";
            this.btnListOrderDetail.Size = new System.Drawing.Size(104, 53);
            this.btnListOrderDetail.TabIndex = 16;
            this.btnListOrderDetail.Text = "Product Listele";
            this.btnListOrderDetail.UseVisualStyleBackColor = true;
            this.btnListOrderDetail.Click += new System.EventHandler(this.BtnListOrderDetail_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(137, 144);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(189, 20);
            this.txtUnitPrice.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "UnitPrice :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(137, 95);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(189, 20);
            this.txtQuantity.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "QuantityPerUnit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Discontinued :";
            // 
            // txtReorderedLevel
            // 
            this.txtReorderedLevel.Location = new System.Drawing.Point(137, 260);
            this.txtReorderedLevel.Name = "txtReorderedLevel";
            this.txtReorderedLevel.Size = new System.Drawing.Size(189, 20);
            this.txtReorderedLevel.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Reordered Level :";
            // 
            // txtUnitsOnOrder
            // 
            this.txtUnitsOnOrder.Location = new System.Drawing.Point(137, 222);
            this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            this.txtUnitsOnOrder.Size = new System.Drawing.Size(189, 20);
            this.txtUnitsOnOrder.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "UnitsOnOrder :";
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(137, 180);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(189, 20);
            this.txtUnitsInStock.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "UnitsInStock";
            // 
            // checkBoxDiscontinued
            // 
            this.checkBoxDiscontinued.AutoSize = true;
            this.checkBoxDiscontinued.Location = new System.Drawing.Point(137, 312);
            this.checkBoxDiscontinued.Name = "checkBoxDiscontinued";
            this.checkBoxDiscontinued.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDiscontinued.TabIndex = 35;
            this.checkBoxDiscontinued.Text = "checkBox1";
            this.checkBoxDiscontinued.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 475);
            this.Controls.Add(this.checkBoxDiscontinued);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReorderedLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnitsOnOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrderDetailDelete);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.dgvListProduct);
            this.Controls.Add(this.btnListOrderDetail);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDetailDelete;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Button btnListOrderDetail;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReorderedLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitsOnOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxDiscontinued;
    }
}