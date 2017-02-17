using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salepricecalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //variables
            decimal originalPrice,
                    discountPercent,
                    discountAmount,
                    salePrice;

            //get original price convert to decimal
            originalPrice = decimal.Parse(originalPriceTextBox.Text);

            //get percent convert to decimal
            discountPercent = decimal.Parse(discountPercentageTextBox.Text);

            //convert percent to decimal form for calculation
            discountPercent = discountPercent / 100;

            //calculate the discount amount
            discountAmount = originalPrice * discountPercent;

            //calculate the sale price
            salePrice = originalPrice - discountAmount;

            //display the sale price in currency form
            salePriceLabel.Text = salePrice.ToString("c");
                   
        }
    }
}
