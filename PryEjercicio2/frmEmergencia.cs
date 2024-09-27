using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEjercicio2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmAgregar frm = new frmAgregar();
            frm.ShowDialog();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            frmModificarUsuario frm = new frmModificarUsuario();
            frm.ShowDialog();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmBuscar frm = new frmBuscar();
            frm.ShowDialog();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar();
            frm.ShowDialog();
        }
    }
}
