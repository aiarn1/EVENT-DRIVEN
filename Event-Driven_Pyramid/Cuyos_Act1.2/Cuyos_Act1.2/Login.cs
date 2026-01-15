using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuyos_Act1._2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {



        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare Variables
            double length, width, height, baseArea, volume;

            // Check for blank inputs first
            if (string.IsNullOrWhiteSpace(txtLength.Text)
                || string.IsNullOrWhiteSpace(txtWidth.Text)
                || string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Please fill all the blanks.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse inputs
            if (!Double.TryParse(txtLength.Text, out length)
                || !Double.TryParse(txtWidth.Text, out width)
                || !Double.TryParse(txtHeight.Text, out height))
            {
                MessageBox.Show("Please enter valid numbers for Length, Width, and Height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate positivity
            if (length < 0 || width < 0 || height < 0)
            {
                MessageBox.Show("Please enter positive numbers for Length, Width, and Height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Process calculations
            baseArea = length * width;
            volume = (1.0 / 3.0) * baseArea * height;

            // Output results
            txtBase.Text = $"{baseArea:F2}";
            txtVolume.Text = $"{volume:F2}";
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtLength.Clear();
            txtBase.Clear();
            txtVolume.Clear();
            txtHeight.Clear();
            txtWidth.Clear();
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;// Suppress the beep sound
            }
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;// Suppress the beep sound
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;// Suppress the beep sound
            }
        }
    }
}
