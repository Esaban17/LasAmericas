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
    public partial class FrmRutas : Form
    {
        public FrmRutas()
        {
            this.BackColor = Color.FromArgb(70, 81, 196);
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
            this.Hide();
        }

        private void FrmRutas_Load(object sender, EventArgs e)
        {

        }
    }
}
