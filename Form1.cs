using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedInventory = (string)shirtList.SelectedItem;

            string color = " ";
            string gift = " ";
            string shipping = " ";

            // which radio button is picked...
            if (blackRadioButton.Checked)
            {
                color = "Black";
            }

            if (whiteRadioButton.Checked)
            {
                color = "White";
            }
            if (brownRadioButton.Checked)
            {
                color = "Brown";
            }

            // see if any of the checkboxes have been chosen
            if (giftCheckBox.Checked)
            {
                gift = ", your item will be gift wrapped ";
            }
            if (shippingCheckBox.Checked)
            {
                shipping = ", and will be delivered in 3-5 days";
            }
            else
            {
                shipping = ", and will be delivered in 5-7 days";
            }

            // print out the information gathered.

            label3.Text = "You have chosen a " + color + "" + selectedInventory + gift + shipping;

            
            
        }
        

        
    }
}
