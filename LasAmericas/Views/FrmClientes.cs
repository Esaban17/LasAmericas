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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            this.BackColor = Color.FromArgb(70, 81, 196);
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            dsLasAmericasTableAdapters.ClienteTableAdapter tableAdapter =
                new dsLasAmericasTableAdapters.ClienteTableAdapter();

            dsLasAmericas.ClienteDataTable dataTable = tableAdapter.GetData();
            dgvClientes.DataSource = dataTable;
        }

        private void ClearText()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dsLasAmericasTableAdapters.ClienteTableAdapter tableAdapter =
                new dsLasAmericasTableAdapters.ClienteTableAdapter();
            tableAdapter.Add(txtNombre.Text.Trim(), txtDireccion.Text.Trim());

            GetData();
            ClearText();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch 
            {
                return null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                dsLasAmericasTableAdapters.ClienteTableAdapter tableAdapter =
                    new dsLasAmericasTableAdapters.ClienteTableAdapter();

                tableAdapter.Edit(txtNombre.Text.Trim(), txtDireccion.Text.Trim(), (int)Id);
                ClearText();
                GetData();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                dsLasAmericasTableAdapters.ClienteTableAdapter tableAdapter =
                    new dsLasAmericasTableAdapters.ClienteTableAdapter();

                dsLasAmericas.ClienteDataTable dt = tableAdapter.GetDataById((int)Id);
                dsLasAmericas.ClienteRow row = (dsLasAmericas.ClienteRow)dt.Rows[0];

                txtNombre.Text = row.nombre;
                txtDireccion.Text = row.direccion;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                dsLasAmericasTableAdapters.ClienteTableAdapter tableAdapter =
                    new dsLasAmericasTableAdapters.ClienteTableAdapter();

                tableAdapter.Remove((int)Id);
                ClearText();
                GetData();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
            this.Hide();
        }
    }
}
