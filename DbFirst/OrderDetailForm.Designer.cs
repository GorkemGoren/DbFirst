namespace DbFirst
{
    partial class OrderDetailForm
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
            this.txtQuatity = new System.Windows.Forms.TextBox();
            this.lblQuatity = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.dgvListOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnListOrderDetail = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderDetailDelete
            // 
            this.btnOrderDetailDelete.Location = new System.Drawing.Point(512, 265);
            this.btnOrderDetailDelete.Name = "btnOrderDetailDelete";
            this.btnOrderDetailDelete.Size = new System.Drawing.Size(114, 53);
            this.btnOrderDetailDelete.TabIndex = 15;
            this.btnOrderDetailDelete.Text = "OrderDetail Sil";
            this.btnOrderDetailDelete.UseVisualStyleBackColor = true;
            this.btnOrderDetailDelete.Click += new System.EventHandler(this.BtnOrderDetailDelete_Click);
            // 
            // txtQuatity
            // 
            this.txtQuatity.Location = new System.Drawing.Point(139, 95);
            this.txtQuatity.Name = "txtQuatity";
            this.txtQuatity.Size = new System.Drawing.Size(189, 20);
            this.txtQuatity.TabIndex = 14;
            // 
            // lblQuatity
            // 
            this.lblQuatity.AutoSize = true;
            this.lblQuatity.Location = new System.Drawing.Point(14, 98);
            this.lblQuatity.Name = "lblQuatity";
            this.lblQuatity.Size = new System.Drawing.Size(49, 13);
            this.lblQuatity.TabIndex = 13;
            this.lblQuatity.Text = "Quantity:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(139, 46);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(189, 20);
            this.txtUnitPrice.TabIndex = 12;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(14, 53);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(59, 13);
            this.lblUnitPrice.TabIndex = 11;
            this.lblUnitPrice.Text = "Unit Price :";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(159, 274);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(104, 34);
            this.btnCategoryAdd.TabIndex = 10;
            this.btnCategoryAdd.Text = "OrderDetail Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.BtnCategoryAdd_Click);
            // 
            // dgvListOrderDetail
            // 
            this.dgvListOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOrderDetail.Location = new System.Drawing.Point(458, 36);
            this.dgvListOrderDetail.Name = "dgvListOrderDetail";
            this.dgvListOrderDetail.Size = new System.Drawing.Size(483, 223);
            this.dgvListOrderDetail.TabIndex = 9;
            // 
            // btnListOrderDetail
            // 
            this.btnListOrderDetail.Location = new System.Drawing.Point(813, 265);
            this.btnListOrderDetail.Name = "btnListOrderDetail";
            this.btnListOrderDetail.Size = new System.Drawing.Size(104, 53);
            this.btnListOrderDetail.TabIndex = 8;
            this.btnListOrderDetail.Text = "OrderDetail Listele";
            this.btnListOrderDetail.UseVisualStyleBackColor = true;
            this.btnListOrderDetail.Click += new System.EventHandler(this.BtnListOrderDetail_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(139, 144);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(189, 20);
            this.txtDiscount.TabIndex = 17;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(14, 151);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 16;
            this.lblDiscount.Text = "Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(139, 236);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(189, 20);
            this.txtOrderId.TabIndex = 23;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(139, 187);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(189, 20);
            this.txtProductId.TabIndex = 22;
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 489);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnOrderDetailDelete);
            this.Controls.Add(this.txtQuatity);
            this.Controls.Add(this.lblQuatity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.btnCategoryAdd);
            this.Controls.Add(this.dgvListOrderDetail);
            this.Controls.Add(this.btnListOrderDetail);
            this.Name = "OrderDetailForm";
            this.Text = "OrderDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDetailDelete;
        private System.Windows.Forms.TextBox txtQuatity;
        private System.Windows.Forms.Label lblQuatity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.DataGridView dgvListOrderDetail;
        private System.Windows.Forms.Button btnListOrderDetail;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtProductId;
    }
}