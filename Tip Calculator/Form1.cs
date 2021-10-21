using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                decimal tot_bill = Convert.ToDecimal(bill.Text); //Bill amount entered
                decimal Tip = tot_bill * (tip_percent.Value / 100); //Total tip 
                decimal tip_share, tot_share; 
                tip_share = Tip / (num_of_people.Value); //Tip per person
                tot_share = (tot_bill / num_of_people.Value) + tip_share; //total share per person
                tip.Text = "$ " + tip_share.ToString(); //printing amount to tip
                total.Text = "$ " + tot_share.ToString(); //printing total share per person 
            }
            catch(Exception ex)
            {
                tip.Text = "$ 0";
                total.Text = "$ 0";
            }
            
        }

        private void num_of_people_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }

        private void bill_TextChanged(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }
    }
}
