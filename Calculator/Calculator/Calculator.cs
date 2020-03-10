using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            resultTextBox.ReadOnly = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var s = Convert.ToInt32(firstTextBox.Text) + Convert.ToInt32(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(s);/*s.ToString()*/
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            var s = Convert.ToInt32(firstTextBox.Text) - Convert.ToInt32(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(s);/*s.ToString()*/
        }

        private void multipicationButton_Click(object sender, EventArgs e)
        {
            var s = Convert.ToInt32(firstTextBox.Text) * Convert.ToInt32(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(s);/*s.ToString()*/
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            var s = Convert.ToInt32(firstTextBox.Text) / Convert.ToInt32(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(s);/*s.ToString()*/
        }
    }
}
