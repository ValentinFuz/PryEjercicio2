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
    public partial class frmEliminar : Form
    {

        conexionBD conexion = new conexionBD();
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(conexion.verificarUsuario(txtNom.Text, txtApe.Text))
            {
                dgvGrilla.Columns.Clear();

                DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas agregar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {


                    MessageBox.Show("Has seleccionado Sí.");
                    conexion.EliminarUsuario(txtNom.Text, txtApe.Text);
                    conexion.imprimirUsuarios(dgvGrilla);

                    txtNom.Text = "";
                    txtApe.Text = "";
                    btnEliminar.Enabled = false;
                }
                else if (result == DialogResult.No)
                {

                    MessageBox.Show("Has seleccionado No.");
                }
            }
            else
            {
                MessageBox.Show("Error. Verifique el nombre y apellido del usuario a eliminar.");
                txtNom.Text = "";
                txtApe.Text = "";
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text.Length > 0 && txtApe.Text.Length > 0)
            {
                btnEliminar.Enabled = true;

            }
            else
            {
               btnEliminar.Enabled = false;
            }
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text.Length > 0 && txtApe.Text.Length > 0)
            {
                btnEliminar.Enabled = true;

            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
