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

            clear();
        }
        private void clear()
        {
            nameTextBox.Clear();
            priceTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
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
        }
    }
}
