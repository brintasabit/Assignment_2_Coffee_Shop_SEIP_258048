namespace Coffee_Shop_App
{
    partial class CoffeeShop
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
            this.CustomerInformationGroupbox = new System.Windows.Forms.GroupBox();
            this.OrderComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.PurchaserichTextBox = new System.Windows.Forms.RichTextBox();
            this.CustomerInformationGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerInformationGroupbox
            // 
            this.CustomerInformationGroupbox.Controls.Add(this.OrderComboBox);
            this.CustomerInformationGroupbox.Controls.Add(this.QuantityTextBox);
            this.CustomerInformationGroupbox.Controls.Add(this.AddressTextBox);
            this.CustomerInformationGroupbox.Controls.Add(this.ContactNumberTextBox);
            this.CustomerInformationGroupbox.Controls.Add(this.CustomerNameTextBox);
            this.CustomerInformationGroupbox.Controls.Add(this.SaveButton);
            this.CustomerInformationGroupbox.Controls.Add(this.Quantity);
            this.CustomerInformationGroupbox.Controls.Add(this.Order);
            this.CustomerInformationGroupbox.Controls.Add(this.Address);
            this.CustomerInformationGroupbox.Controls.Add(this.ContactNumber);
            this.CustomerInformationGroupbox.Controls.Add(this.CustomerName);
            this.CustomerInformationGroupbox.Location = new System.Drawing.Point(60, 99);
            this.CustomerInformationGroupbox.Name = "CustomerInformationGroupbox";
            this.CustomerInformationGroupbox.Size = new System.Drawing.Size(562, 452);
            this.CustomerInformationGroupbox.TabIndex = 0;
            this.CustomerInformationGroupbox.TabStop = false;
            this.CustomerInformationGroupbox.Text = "Customer Information";
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Items.AddRange(new object[] {
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Regular-80"});
            this.OrderComboBox.Location = new System.Drawing.Point(198, 221);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(279, 28);
            this.OrderComboBox.TabIndex = 3;
            this.OrderComboBox.Text = "Select An Item";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(199, 303);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(278, 26);
            this.QuantityTextBox.TabIndex = 2;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(199, 158);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(278, 26);
            this.AddressTextBox.TabIndex = 2;
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.Location = new System.Drawing.Point(199, 94);
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(278, 26);
            this.ContactNumberTextBox.TabIndex = 2;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(199, 30);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(278, 26);
            this.CustomerNameTextBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(199, 365);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 32);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(17, 309);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(68, 20);
            this.Quantity.TabIndex = 0;
            this.Quantity.Text = "Quantity";
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Location = new System.Drawing.Point(17, 229);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(49, 20);
            this.Order.TabIndex = 0;
            this.Order.Text = "Order";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(17, 164);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(68, 20);
            this.Address.TabIndex = 0;
            this.Address.Text = "Address";
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSize = true;
            this.ContactNumber.Location = new System.Drawing.Point(16, 100);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(125, 20);
            this.ContactNumber.TabIndex = 0;
            this.ContactNumber.Text = "Contact Number";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(17, 37);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(124, 20);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.Text = "Customer Name";
            // 
            // PurchaserichTextBox
            // 
            this.PurchaserichTextBox.Location = new System.Drawing.Point(655, 112);
            this.PurchaserichTextBox.Name = "PurchaserichTextBox";
            this.PurchaserichTextBox.Size = new System.Drawing.Size(241, 439);
            this.PurchaserichTextBox.TabIndex = 1;
            this.PurchaserichTextBox.Text = "Purchase Info";
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 672);
            this.Controls.Add(this.PurchaserichTextBox);
            this.Controls.Add(this.CustomerInformationGroupbox);
            this.Name = "CoffeeShop";
            this.Text = "Coffee Shop";
            this.CustomerInformationGroupbox.ResumeLayout(false);
            this.CustomerInformationGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerInformationGroupbox;
        private System.Windows.Forms.ComboBox OrderComboBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.RichTextBox PurchaserichTextBox;
    }
}

