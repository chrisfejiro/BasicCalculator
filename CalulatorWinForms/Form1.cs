using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalulatorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //this.lblEntry.Text = string.Empty;
            this.lblEntry.ResetText();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.lblOperator.Text = "+";
            if (this.lblEntry.Text != string.Empty)
            {
                this.lblMiniEntry.Text = this.lblEntry.Text;
            }
            this.lblEntry.ResetText();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.lblOperator.Text = "-";
            if (this.lblEntry.Text != string.Empty)
                this.lblMiniEntry.Text = this.lblEntry.Text;
            this.lblEntry.ResetText();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.lblOperator.Text = "x";
            if (this.lblEntry.Text != string.Empty)
                this.lblMiniEntry.Text = this.lblEntry.Text;
            this.lblEntry.ResetText();
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            this.lblOperator.Text = "%";
            if (this.lblEntry.Text != string.Empty)
                this.lblMiniEntry.Text = this.lblEntry.Text;
            this.lblEntry.ResetText();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double fn, sn;
            double ?result = null;
            //This converys the text to double and assign it to fn
            double.TryParse(this.lblEntry.Text, out fn);
            double.TryParse(this.lblMiniEntry.Text, out sn);

            if (this.lblOperator.Text == "+")
            {
                result = fn + sn;
            }
            if (this.lblOperator.Text == "-")
            {
                result = fn - sn;
            }
            if (this.lblOperator.Text == "x")
            {
                result = fn * sn;
            }
            if (this.lblOperator.Text == "%")
            {
                result = fn / sn;
            }
            this.lblEntry.Text = result.ToString();
            this.lblMiniEntry.Text = string.Empty;
            this.lblOperator.Text = string.Empty;
           
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            this.lblEntry.Text += ".";
        }
    }
}
