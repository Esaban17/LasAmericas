using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LasAmericas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            this.BackColor = Color.FromArgb(70, 81, 196);
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmMenu = new FrmMenu();
            frmMenu.Closed += (s, args) => this.Close();
            frmMenu.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
