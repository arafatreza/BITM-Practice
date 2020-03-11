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
            show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //connection
            string connection = @"Server=DESKTOP-28DHLU6; Database=CoffeeShop; integrated security=true";
            SqlConnection sqlconnection = new SqlConnection(connection);

            //command
            //INSERT INTO Items(Name,Price) VALUES ('A',80);
            string command = "INSERT INTO Items(Name,Price) VALUES ('" + nameTextBox.Text + "','" + priceTextBox.Text + "')";
            SqlCommand con = new SqlCommand(command, sqlconnection);

            //Open
            sqlconnection.Open();

            //Execute
            int i = con.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Not Added");
            }
            //Close
            sqlconnection.Close();
            show();
            clear();
        }
        private void clear()
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            priceTextBox.Clear();
        }
        private void show()
        {
            //connection
            string connection = @"Server=DESKTOP-28DHLU6; Database=CoffeeShop; integrated security=true";
            SqlConnection sqlconnection = new SqlConnection(connection);

            //command
            //SELECT * FROM Items;
            string command = "SELECT * FROM Items";
            SqlCommand con = new SqlCommand(command, sqlconnection);

            //Open
            sqlconnection.Open();

            //Execute
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(con);
            DataTable datatable = new DataTable();
            sqldataadapter.Fill(datatable);
            showDataGridView.DataSource = datatable;
            //Close
            sqlconnection.Close();
            show();
        }

            private void showButton_Click(object sender, EventArgs e)
        {
            show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //connection
            string connection = @"Server=DESKTOP-28DHLU6; Database=CoffeeShop; integrated security=true";
            SqlConnection sqlconnection = new SqlConnection(connection);

            //command
            //DELETE FROM Items WHERE ID = 14;
            string command = "DELETE FROM Items WHERE ID = " + idTextBox.Text + "";
            SqlCommand con = new SqlCommand(command, sqlconnection);

            //Open
            sqlconnection.Open();

            //Execute
            int i = con.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
            //Close
            sqlconnection.Close();
            show();
            clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //connection
            string connection = @"Server=DESKTOP-28DHLU6; Database=CoffeeShop; integrated security=true";
            SqlConnection sqlconnection = new SqlConnection(connection);

            //command
            //UPDATE Items SET Price = 80 WHERE ID = 12;
            string command = "UPDATE Items SET Price = '" + priceTextBox.Text + "' WHERE ID = " + idTextBox.Text + "";
            SqlCommand con = new SqlCommand(command, sqlconnection);

            //Open
            sqlconnection.Open();

            //Execute
            int i = con.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
            //Close
            sqlconnection.Close();
            show();
            clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
