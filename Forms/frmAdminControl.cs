using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_Monkeys
{
    public partial class frmAdminControl : Form
    {
        public frmAdminControl()
        {
            InitializeComponent();
        }

        private void frmAdminControl_Load(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fdAdmin.ShowDialog(this);
            Properties.Settings.Default.Save();
        }

 
    }
}
