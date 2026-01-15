using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eventdrive
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudID.Text) ||
       string.IsNullOrWhiteSpace(txtname.Text) ||
       string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Validation for Numbers in Name
            if (txtname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Student name must not contain numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }

            // 3. DUPLICATE CHECK: Look for existing Student ID
            bool isDuplicate = false;
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                // Assuming Student ID is in the first column (index 0)
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtStudID.Text)
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                MessageBox.Show("This Student ID already exists in the list!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudID.Focus();
                return;
            }

            // 4. Add the data if no duplicate is found
            dgv1.Rows.Add(txtStudID.Text, txtname.Text, txtCourse.Text);

            // Add to ListView as well
            ListViewItem item = new ListViewItem(txtStudID.Text);
            item.SubItems.Add(txtname.Text);
            item.SubItems.Add(txtCourse.Text);
            lv1.Items.Add(item);

            MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Check if all textboxes are empty or null
            if (string.IsNullOrWhiteSpace(txtStudID.Text) &&
                string.IsNullOrWhiteSpace(txtCourse.Text) &&
                string.IsNullOrWhiteSpace(txtname.Text))
            {
                // Show a warning message if there is nothing to clear
                MessageBox.Show("The fields are already empty!", "Nothing to Clear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Proceed with clearing if at least one field has data
                txtStudID.Clear();
                txtCourse.Clear();
                txtname.Clear();

                lv1.Items.Clear();
                dgv1.Rows.Clear();

                txtStudID.Focus();
            }
        }

        private void txtStudName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtStudID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the character
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Display a message box with Yes and No buttons
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked 'Yes'
            if (result == DialogResult.Yes)
            {
                // Hide the current form
                this.Hide();

                // Show the login form (Form1)
                Form1 loginForm = new Form1();
                loginForm.ShowDialog();

                // Close the current form after the login form is closed
                this.Close();
            }

        }
    }
}
