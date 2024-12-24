using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProject
{
    public partial class Form3 : Form
    {
        private List<string> cart = new List<string>();
        private Random rnd = new Random();
        private float balance;
        private float total;
           
        public Form3(List<string> cart)
        {
            this.cart = cart;

            InitializeComponent();
            totalLbl.Text = $"Total : {CalculatePrice(cart)}$";
            balance = rnd.Next(0, 200);
            label1.Text = $"Balance : {balance.ToString()}$";
        }

        private float CalculatePrice(List<string> cart)
        {
            float price = 0;
            foreach (var item in cart)
            {
                price += float.Parse(item.Split(":")[1]);
            }
            total = price;
            return total;
        }


        private void totalLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (balance >= total)
            {
                MessageBox.Show($"Checkout successfull\nRemaining Money: {balance - total}");
                Close();

            }
            else
            {
                MessageBox.Show("Not Enough Money.");
                Close();
            }
        }
    }
}
