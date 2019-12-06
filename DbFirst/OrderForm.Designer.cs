namespace DbFirst
{
    partial class OrderForm
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
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.txtOrderDescription = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.Label();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.Label();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.dgvListOrder = new System.Windows.Forms.DataGridView();
            this.btnListOrder = new System.Windows.Forms.Button();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.lblShipCity = new System.Windows.Forms.Label();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.lblShipName = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lblFreight = new System.Windows.Forms.Label();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.lblShipCountry = new System.Windows.Forms.Label();
            this.txtShipRegion = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Location = new System.Drawing.Point(510, 289);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(114, 53);
            this.btnOrderDelete.TabIndex = 23;
            this.btnOrderDelete.Text = "Order Sil";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            // 
            // txtOrderDescription
            // 
            this.txtOrderDescription.Location = new System.Drawing.Point(146, 69);
            this.txtOrderDescription.Name = "txtOrderDescription";
            this.txtOrderDescription.Size = new System.Drawing.Size(189, 20);
            this.txtOrderDescription.TabIndex = 22;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.AutoSize = true;
            this.txtRequiredDate.Location = new System.Drawing.Point(21, 72);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(73, 13);
            this.txtRequiredDate.TabIndex = 21;
            this.txtRequiredDate.Text = "RequiredDate";
            // 
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(146, 29);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(189, 20);
            this.txtOrderName.TabIndex = 20;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.AutoSize = true;
            this.txtOrderDate.Location = new System.Drawing.Point(21, 36);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(56, 13);
            this.txtOrderDate.TabIndex = 19;
            this.txtOrderDate.Text = "OrderDate";
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Location = new System.Drawing.Point(182, 412);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(104, 34);
            this.btnOrderAdd.TabIndex = 18;
            this.btnOrderAdd.Text = "Order Ekle";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.BtnOrderAdd_Click);
            // 
            // dgvListOrder
            // 
            this.dgvListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOrder.Location = new System.Drawing.Point(456, 60);
            this.dgvListOrder.Name = "dgvListOrder";
            this.dgvListOrder.Size = new System.Drawing.Size(483, 223);
            this.dgvListOrder.TabIndex = 17;
            // 
            // btnListOrder
            // 
            this.btnListOrder.Location = new System.Drawing.Point(811, 289);
            this.btnListOrder.Name = "btnListOrder";
            this.btnListOrder.Size = new System.Drawing.Size(104, 53);
            this.btnListOrder.TabIndex = 16;
            this.btnListOrder.Text = "Order Listele";
            this.btnListOrder.UseVisualStyleBackColor = true;
            this.btnListOrder.Click += new System.EventHandler(this.BtnListOrder_Click);
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(146, 105);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(189, 20);
            this.txtShippedDate.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ShippedDate";
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(146, 256);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(189, 20);
            this.txtShipCity.TabIndex = 35;
            // 
            // lblShipCity
            // 
            this.lblShipCity.AutoSize = true;
            this.lblShipCity.Location = new System.Drawing.Point(21, 259);
            this.lblShipCity.Name = "lblShipCity";
            this.lblShipCity.Size = new System.Drawing.Size(45, 13);
            this.lblShipCity.TabIndex = 34;
            this.lblShipCity.Text = "ShipCity";
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(146, 219);
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(189, 20);
            this.txtShipAddress.TabIndex = 33;
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.Location = new System.Drawing.Point(21, 222);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(66, 13);
            this.lblShipAddress.TabIndex = 32;
            this.lblShipAddress.Text = "ShipAddress";
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(146, 184);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(189, 20);
            this.txtShipName.TabIndex = 31;
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Location = new System.Drawing.Point(21, 187);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(56, 13);
            this.lblShipName.TabIndex = 30;
            this.lblShipName.Text = "ShipName";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(146, 141);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(189, 20);
            this.txtFreight.TabIndex = 29;
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(21, 148);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(39, 13);
            this.lblFreight.TabIndex = 28;
            this.lblFreight.Text = "Freight";
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(146, 374);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(189, 20);
            this.txtShipCountry.TabIndex = 39;
            // 
            // lblShipCountry
            // 
            this.lblShipCountry.AutoSize = true;
            this.lblShipCountry.Location = new System.Drawing.Point(21, 377);
            this.lblShipCountry.Name = "lblShipCountry";
            this.lblShipCountry.Size = new System.Drawing.Size(92, 13);
            this.lblShipCountry.TabIndex = 38;
            this.lblShipCountry.Text = "Order Açıklaması :";
            // 
            // txtShipRegion
            // 
            this.txtShipRegion.Location = new System.Drawing.Point(146, 293);
            this.txtShipRegion.Name = "txtShipRegion";
            this.txtShipRegion.Size = new System.Drawing.Size(189, 20);
            this.txtShipRegion.TabIndex = 37;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(21, 296);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 13);
            this.lbl.TabIndex = 36;
            this.lbl.Text = "ShipRegion";
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(146, 335);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(189, 20);
            this.txtShipPostalCode.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "ShipPostalCode";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 471);
            this.Controls.Add(this.txtShipPostalCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShipCountry);
            this.Controls.Add(this.lblShipCountry);
            this.Controls.Add(this.txtShipRegion);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.lblShipCity);
            this.Controls.Add(this.txtShipAddress);
            this.Controls.Add(this.lblShipAddress);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.lblShipName);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.lblFreight);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrderDelete);
            this.Controls.Add(this.txtOrderDescription);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderName);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.btnOrderAdd);
            this.Controls.Add(this.dgvListOrder);
            this.Controls.Add(this.btnListOrder);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.TextBox txtOrderDescription;
        private System.Windows.Forms.Label txtRequiredDate;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.Label txtOrderDate;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.DataGridView dgvListOrder;
        private System.Windows.Forms.Button btnListOrder;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.Label lblShipCity;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.Label lblShipAddress;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.Label lblShipCountry;
        private System.Windows.Forms.TextBox txtShipRegion;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtShipPostalCode;
        private System.Windows.Forms.Label label1;
    }
}