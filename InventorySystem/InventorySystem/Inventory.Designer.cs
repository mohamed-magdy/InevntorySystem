namespace InventorySystem
{
    partial class Inventory
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
            this.gbxProducts = new System.Windows.Forms.GroupBox();
            this.lblPriceValidation = new System.Windows.Forms.Label();
            this.lblQuantityValidation = new System.Windows.Forms.Label();
            this.lblNameValidation = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnOpenInventoryStatus = new System.Windows.Forms.Button();
            this.btnOpenInventoryTracking = new System.Windows.Forms.Button();
            this.gbxProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxProducts
            // 
            this.gbxProducts.Controls.Add(this.lblPriceValidation);
            this.gbxProducts.Controls.Add(this.lblQuantityValidation);
            this.gbxProducts.Controls.Add(this.lblNameValidation);
            this.gbxProducts.Controls.Add(this.txtPrice);
            this.gbxProducts.Controls.Add(this.lblPrice);
            this.gbxProducts.Controls.Add(this.btnRemoveProduct);
            this.gbxProducts.Controls.Add(this.btnAddProduct);
            this.gbxProducts.Controls.Add(this.txtQuantity);
            this.gbxProducts.Controls.Add(this.lblQuantity);
            this.gbxProducts.Controls.Add(this.txtProductName);
            this.gbxProducts.Controls.Add(this.lblProductName);
            this.gbxProducts.Location = new System.Drawing.Point(12, 12);
            this.gbxProducts.Name = "gbxProducts";
            this.gbxProducts.Size = new System.Drawing.Size(452, 277);
            this.gbxProducts.TabIndex = 0;
            this.gbxProducts.TabStop = false;
            this.gbxProducts.Text = "Products";
            // 
            // lblPriceValidation
            // 
            this.lblPriceValidation.AutoSize = true;
            this.lblPriceValidation.ForeColor = System.Drawing.Color.Red;
            this.lblPriceValidation.Location = new System.Drawing.Point(270, 134);
            this.lblPriceValidation.Name = "lblPriceValidation";
            this.lblPriceValidation.Size = new System.Drawing.Size(0, 17);
            this.lblPriceValidation.TabIndex = 10;
            // 
            // lblQuantityValidation
            // 
            this.lblQuantityValidation.AutoSize = true;
            this.lblQuantityValidation.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityValidation.Location = new System.Drawing.Point(267, 87);
            this.lblQuantityValidation.Name = "lblQuantityValidation";
            this.lblQuantityValidation.Size = new System.Drawing.Size(0, 17);
            this.lblQuantityValidation.TabIndex = 9;
            // 
            // lblNameValidation
            // 
            this.lblNameValidation.AutoSize = true;
            this.lblNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lblNameValidation.Location = new System.Drawing.Point(264, 45);
            this.lblNameValidation.Name = "lblNameValidation";
            this.lblNameValidation.Size = new System.Drawing.Size(0, 17);
            this.lblNameValidation.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(116, 130);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(131, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(37, 135);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(247, 209);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(163, 32);
            this.btnRemoveProduct.TabIndex = 7;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(115, 209);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(107, 32);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(115, 87);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(131, 22);
            this.txtQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(36, 92);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(115, 41);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(131, 22);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(35, 41);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(45, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Name";
            // 
            // btnOpenInventoryStatus
            // 
            this.btnOpenInventoryStatus.Location = new System.Drawing.Point(12, 330);
            this.btnOpenInventoryStatus.Name = "btnOpenInventoryStatus";
            this.btnOpenInventoryStatus.Size = new System.Drawing.Size(162, 30);
            this.btnOpenInventoryStatus.TabIndex = 1;
            this.btnOpenInventoryStatus.Text = "Open Inventory Status";
            this.btnOpenInventoryStatus.UseVisualStyleBackColor = true;
            this.btnOpenInventoryStatus.Click += new System.EventHandler(this.btnOpenInventoryStatus_Click);
            // 
            // btnOpenInventoryTracking
            // 
            this.btnOpenInventoryTracking.Location = new System.Drawing.Point(221, 330);
            this.btnOpenInventoryTracking.Name = "btnOpenInventoryTracking";
            this.btnOpenInventoryTracking.Size = new System.Drawing.Size(211, 30);
            this.btnOpenInventoryTracking.TabIndex = 2;
            this.btnOpenInventoryTracking.Text = "Open Inventory Tracking";
            this.btnOpenInventoryTracking.UseVisualStyleBackColor = true;
            this.btnOpenInventoryTracking.Click += new System.EventHandler(this.btnOpenInventoryTracking_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 496);
            this.Controls.Add(this.btnOpenInventoryTracking);
            this.Controls.Add(this.btnOpenInventoryStatus);
            this.Controls.Add(this.gbxProducts);
            this.Name = "Inventory";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.gbxProducts.ResumeLayout(false);
            this.gbxProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnOpenInventoryStatus;
        private System.Windows.Forms.Button btnOpenInventoryTracking;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceValidation;
        private System.Windows.Forms.Label lblQuantityValidation;
        private System.Windows.Forms.Label lblNameValidation;
    }
}

