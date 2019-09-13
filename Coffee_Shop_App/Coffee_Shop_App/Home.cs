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
            // int contactNumber = Convert.ToInt32(ContactNumberTextBox.Text);
            string contactNumber = ContactNumberTextBox.Text;
            string address = AddressTextBox.Text;
            string order =OrderComboBox.Text;
            int quantity = Convert.ToInt32(QuantityTextBox.Text);
            if (OrderComboBox.Text == "Hot-90")
            {
                int totalPrice = quantity * 90;


                // int order = int.Parse(OrderComboBox.SelectedItem.ToString());


                // MessageBox.Show("Name: " + customerName + "\nContact: " + contactNumber + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity);
                //PurchaserichTextBox.Text=MessageBox.Show
                // int totalPrice = quantity * order;

                PurchaserichTextBox.AppendText("\n\nName: " + customerName + "\nContact: " + contactNumber + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity + "\nTotal Price" + totalPrice);
            }
            else if (OrderComboBox.Text == "Regular-80")
            {
                int totalPrice = quantity * 80;
                PurchaserichTextBox.AppendText("\n\nName: " + customerName + "\nContact: " + contactNumber + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity + "\nTotal Price" + totalPrice);
            }
            else if (OrderComboBox.Text == "Black-120")
            {
                int totalPrice = quantity * 120;
                PurchaserichTextBox.AppendText("\n\nName: " + customerName + "\nContact: " + contactNumber + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity + "\nTotal Price" + totalPrice);
            }
            else if (OrderComboBox.Text == "Cold-100")
            {
                int totalPrice = quantity * 100;
                PurchaserichTextBox.AppendText("\n\nName: " + customerName + "\nContact: " + contactNumber + "\nAddress: " + address + "\nOrder: " + order + "\nQuantity: " + quantity + "\nTotal Price" + totalPrice);
            }
            CustomerNameTextBox.Text = "";
            ContactNumberTextBox.Text = "";
            AddressTextBox.Text = "";
            OrderComboBox.Text = "Select An Item";
            QuantityTextBox.Text = "";
        }
    }
}
