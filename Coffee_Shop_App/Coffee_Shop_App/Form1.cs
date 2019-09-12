using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_App
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string customerName = CustomerNameTextBox.Text;
            int contactNumber = Convert.ToInt32(ContactNumberTextBox.Text);
            string address = AddressTextBox.Text;
            string order = OrderComboBox.Text;
            int quantity = Convert.ToInt32(QuantityTextBox.Text);
            MessageBox.Show("Name: " + customerName + "\nContact: " + contactNumber + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity);
            //PurchaserichTextBox.Text=MessageBox.Show
            PurchaserichTextBox.AppendText("\nName: " + customerName + "\nContact: " + contactNumber + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity);
        }
    }
}
