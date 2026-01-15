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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

   

      

        private void btnStart_Click(object sender, EventArgs e)
        {
          Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
