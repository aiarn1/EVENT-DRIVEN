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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }

        }
    }
}
