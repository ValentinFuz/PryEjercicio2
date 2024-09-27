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
    public partial class frmModificarUsuario : Form
    {
        conexionBD conexion = new conexionBD();
       
        string soloNumTel;
        int numCat;

        public frmModificarUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text.Length > 0 && txtApe.Text.Length > 0)
            {
                mtxTel.Enabled = true; 
                txtCorreo.Enabled = true;
                cmbCateg.Enabled = true;

            }
            else
            {
                mtxTel.Enabled = false;
                txtCorreo.Enabled = false;
                cmbCateg.Enabled = false;
            }
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text.Length > 0 && txtApe.Text.Length > 0)
            {
                mtxTel.Enabled = true; 
                txtCorreo.Enabled = true;
                cmbCateg.Enabled = true;

            }
            else
            {
                mtxTel.Enabled = false;
                txtCorreo.Enabled = false;
                cmbCateg.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(conexion.verificarUsuario(txtNom.Text, txtApe.Text))
            {
                DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas agregar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Has seleccionado Sí.");
                    string texto = mtxTel.Text;
                    foreach (char c in texto)
                    {
                        if (char.IsDigit(c))
                        {
                            soloNumTel += c;
                        }
                    }

                    lblTel.Text = soloNumTel;
                    lblCateg.Text = cmbCateg.SelectedItem.ToString();
                    lblCorreo.Text = txtCorreo.Text;

                    conexion.ModificarTodo(txtNom.Text, txtApe.Text, soloNumTel, txtCorreo.Text, numCat);

                    mtxTel.Enabled = false;
                    txtCorreo.Enabled = false;
                    cmbCateg.Enabled = false;
                    btnModificar.Enabled = false;

                    mtxTel.Text = "";
                    txtCorreo.Text = "";
                    cmbCateg.SelectedItem = "";

                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Has seleccionado No.");
                }
            }
            else
            {
                MessageBox.Show("Error. Revise el nombre y apellido.");
                btnModificar.Enabled = false;
                txtApe.Text = null;
                txtNom.Text = null;
            }
        }

        private void cmbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cate = cmbCateg.SelectedItem.ToString();
            numCat = conexion.DevolverId(cate);
            if (cmbCateg.SelectedItem != null && mtxTel.Text != null  && txtCorreo.Text != null)
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }

        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            List<string> categorias = conexion.ImprimirCateg(cmbCateg);
            cmbCateg.Items.Clear();
            cmbCateg.Items.AddRange(categorias.ToArray());
        }

        private void mtxTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (cmbCateg.SelectedItem != null && mtxTel.Text != null && txtCorreo.Text != null)
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }
    }
}
