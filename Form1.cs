using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingCartApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblDiscription_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantity1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQuantity2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQuantity3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblTotal_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float total = 0.00F;
            if (txtQuantity1.Text == "")
                txtQuantity1.Text = "0";
            if (txtQuantity2.Text == "")
                txtQuantity2.Text = "0";
            if (txtQuantity3.Text == "")
                txtQuantity3.Text = "0";
            total = float.Parse(lblTotal1.Text) + float.Parse(lblTotal2.Text) + float.Parse(lblTotal3.Text);
            lblTotal.Text = total.ToString() + " Rs.";
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            txtQuantity1.Text = "";
            txtQuantity2.Text = "";
            txtQuantity3.Text = "";
            lblTotal1.Text = "0.00 Rs.";
            lblTotal2.Text = "0.00 Rs.";
            lblTotal3.Text = "0.00 Rs.";
            lblTotal.Text = "0.00 Rs.";
        }

        private void lblProduct1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtQuantity1_TextChanged_1(object sender, EventArgs e)
        {
            float total = 0.00F;
            if (txtQuantity1.Text != "")
            {
                total = float.Parse(txtQuantity1.Text) * 1300;
            }
            lblTotal1.Text = total.ToString();
        }

        private void txtQuantity2_TextChanged_1(object sender, EventArgs e)
        {
            float total = 0.00F;
            if (txtQuantity2.Text != "")
            {
                total = float.Parse(txtQuantity2.Text) * 4000;
            }
            lblTotal2.Text = total.ToString();
        }

        private void txtQuantity3_TextChanged_1(object sender, EventArgs e)
        {
            float total = 0.00F;
            if (txtQuantity3.Text != "")
            {
                total = float.Parse(txtQuantity3.Text) * 1700;
            }
            lblTotal3.Text = total.ToString();
        }
    }
}
