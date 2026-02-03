using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuyos_Lambda
{
    public partial class frmCafeteria : Form
    {
        public frmCafeteria()
        {
            InitializeComponent();

            // Lambda expression for button click
            btnCheck.Click += (sender, e) =>
            {
                int quantity;
                string orderType = "";

                // Determine order type
                if (rdbDinein.Checked)
                    orderType = "Dine In";
                else if (rdbTakeout.Checked)
                    orderType = "Take Out";
                else
                    orderType = "No order type selected";

                if (int.TryParse(txtQuantity.Text, out quantity))
                {
                    if (quantity > 0)
                    {
                        MessageBox.Show(
                            $"Order Accepted\nOrder Type: {orderType}\nQuantity: {quantity}", "Order Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Order", "Order Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Order", "Order Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }

        private void frmCafeteria_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtQuantity.Clear();
           
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and backspace only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
