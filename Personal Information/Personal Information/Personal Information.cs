using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class Form1 : Form
    {
        //List<string> firstName = new List<string>();

        //List<string> lastName = new List<string>();

        //List<string> fatherName = new List<string>();

        //List<string> motherName = new List<string>();

        //List<string> address = new List<string>();

        string show;
        string name;
        string parentName;
        string address;
        List<string> All = new List<string>();
        List<string> Name = new List<string>();
        List<string> ParentName = new List<string>();
        List<string> Address = new List<string>();




        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (firstTextBox.Text == "")
            {
                MessageBox.Show("First Name can't be empty");
            }
            if (lastTextBox.Text == "")
            {
                MessageBox.Show("Last Name can't be empty");
            }
            if (fatherTextBox.Text == "")
            {
                MessageBox.Show("Father Name can't be empty");
            }
            if (motherTextBox.Text == "")
            {
                MessageBox.Show("Mother Name can't be empty");
            }
            if (addressTextBox.Text == "")
            {
                MessageBox.Show("Address Name can't be empty");
            }
            //firstName.Add(firstTextBox.Text);
            //lastName.Add(lastTextBox.Text);
            //fatherName.Add(fatherTextBox.Text);
            //motherName.Add(motherTextBox.Text);
            //address.Add(addressTextBox.Text);
            show = "Name :" + firstTextBox.Text + ' ' + lastTextBox.Text + '\n' + "Father's Name :" + fatherTextBox.Text + '\n' + "Mother's Name :" + motherTextBox.Text + '\n' + "Address :" + addressTextBox.Text + '\n';
            name = "Name :" + firstTextBox.Text + ' ' + lastTextBox.Text + '\n';
            parentName = "Father's Name :" + fatherTextBox.Text + '\n' + "Mother's Name :" + motherTextBox.Text + '\n';
            address = "Address :" + addressTextBox.Text + '\n';
            Address.Add(address);
            ParentName.Add(parentName);
            Name.Add(name); 
            All.Add(show);
             clear();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string m = " ";

            foreach (var item in All)
            {
                m += item;
            }
            MessageBox.Show(m);

        }

        public void clear()
        {
            firstTextBox.Clear();
            lastTextBox.Clear();
            fatherTextBox.Clear();
            motherTextBox.Clear();
            addressTextBox.Clear();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            string m = " ";

            foreach (var item in Name)
            {
                m += item;
            }
            MessageBox.Show(m);
        }

        private void parentButton_Click(object sender, EventArgs e)
        {
            string m = " ";

            foreach (var item in ParentName)
            {
                m += item;
            }
            MessageBox.Show(m);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            string m = " ";

            foreach (var item in Address)
            {
                m += item;
            }
            MessageBox.Show(m);
        }
    }
}
