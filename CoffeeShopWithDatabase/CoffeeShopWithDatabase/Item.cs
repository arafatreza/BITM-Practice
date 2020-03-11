using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWithDatabase
{
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string connection = @"Server=DESKTOP-28DHLU6; Database=CoffeeShop; integrated security=true";
            SqlConnection sqlconnection = new SqlConnection(connection);

            string command = "insert into Items(Name,Price) values ('" + nameTextBox.Text + "','" + priceTextBox.Text + "')";
            SqlCommand con = new SqlCommand(command, sqlconnection);

            sqlconnection.Open();

            int i = con.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Not Added");
            }

            sqlconnection.Close();

            clear();
        }
        private void clear()
        {
            nameTextBox.Clear();
            priceTextBox.Clear();
        }
    }
}
