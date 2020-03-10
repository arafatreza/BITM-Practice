using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class CoffeeShop : Form
    {
        int black = 120;
        int cold = 100;
        int hot = 90;
        int regular = 80;
        int price;

        string s;
        List<string> show = new List<string>();

        public CoffeeShop()
        {
            InitializeComponent();
            orderComboBox.Text = "Select";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text == "")
            {
                MessageBox.Show("Customer Name can't be empty");
            }
            if (contactNoTextBox.Text == "")
            {
                MessageBox.Show("Contact No can't be empty");
            }
            if (addressTextBox.Text == "")
            {
                MessageBox.Show("Address can't be empty");
            }
            if (orderComboBox.Text == "Select")
            {
                MessageBox.Show("You have to select a order");
            }
            if (quantityTextBox.Text == "")
            {
                MessageBox.Show("Quantity can't be empty");
            }
            

            if (orderComboBox.Text == "Black")
            {
                price = black * Convert.ToInt32(quantityTextBox.Text);
            }
            if (orderComboBox.Text == "Cold")
            {
                price = cold * Convert.ToInt32(quantityTextBox.Text);
            }
            if (orderComboBox.Text == "Hot")
            {
                price = hot * Convert.ToInt32(quantityTextBox.Text);
            }
            if (orderComboBox.Text == "Regular")
            {
                price = regular * Convert.ToInt32(quantityTextBox.Text);
            }

            s = "Customer Information :" + '\n' + "Customer Name :" + customerNameTextBox.Text + '\n' + "Contact No :" + contactNoTextBox.Text + '\n' + "Address :" + addressTextBox.Text + '\n' + "Order :" + orderComboBox.Text + '\n' + "Quantity :" + quantityTextBox.Text + '\n' + "Price :" + Convert.ToString(price) + '\n' + '\n' + '\n';
            show.Add(s);
            Clear();

            string m = " ";

            foreach (var item in show)
            {
                m += item;
            }
            showRichTextBox.Text = m;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.Text = "Select";
            quantityTextBox.Clear();
            showRichTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string m = " ";

            foreach (var item in show)
            {
                m += item;
            }
            showRichTextBox.Text = m;
        }
        public void Clear()
        {
            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.Text = "Select";
            quantityTextBox.Clear();
        }
    }
}
