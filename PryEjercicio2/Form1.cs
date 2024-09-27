using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEjercicio2
{
    public partial class frmAgregar : Form
    {

        // variables globales
        string soloNumTel;
        string categoria;
        int numCat;
        
        public int numCategoria
        {
            get { return numCat; } 
            set {  numCat = value; }
        }

        conexionBD conexion = new conexionBD();
        public frmAgregar()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!conexion.verificarUsuario(txtNom.Text, txtApe.Text))
            {
                dgvGrilla.Columns.Clear();

                DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas agregar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string texto = mtxTel.Text;
                    foreach (char c in texto)
                    {
                        if (char.IsDigit(c))
                        {
                            soloNumTel += c;
                        }
                    }

                    MessageBox.Show("Has seleccionado Sí.");
                    conexion.agregarUsuario(txtNom.Text, txtApe.Text, soloNumTel, txtCorreo.Text, numCat);
                    conexion.imprimirUsuarios(dgvGrilla);

                    txtNom.Text = "";
                    txtApe.Text = "";
                    mtxTel.Text = "";
                    txtCorreo.Text = "";
                    cmbCateg.SelectedItem = "";

                    txtApe.Enabled = false;
                    mtxTel.Enabled = false;
                    txtCorreo.Enabled = false;
                    grbCateg.Enabled = false;
                    btnAgregar.Enabled = false;
                }
                else if (result == DialogResult.No)
                {

                    MessageBox.Show("Has seleccionado No.");
                }
            }
            else
            {
                MessageBox.Show("Error. El nombre y apellido ya existen.");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvGrilla.Columns.Clear();

            List<string> categorias = conexion.ImprimirCateg(cmbCateg);
            cmbCateg.Items.Clear();
            cmbCateg.Items.AddRange(categorias.ToArray());
            
        }

        private void btnAgregarCateg_Click(object sender, EventArgs e)
        {
            if(!conexion.verificarCateg(txtNewCateg.Text))
            {
                if (txtNewCateg.Text.Length > 0)
                {
                    categoria = txtNewCateg.Text;
                    conexion.AgregarCategoria(categoria);
                    cmbCateg.Items.Clear();
                    List<string> categorias = conexion.ImprimirCateg(cmbCateg);
                    cmbCateg.Items.AddRange(categorias.ToArray());
                }
                else
                {
                    MessageBox.Show("Error. No ha escrito nada en el nombre de la categoría.");
                }
            }
            else
            {
                MessageBox.Show("Error. La categoría ya existe.");
            }
        }

        private void cmbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cate = cmbCateg.SelectedItem.ToString();
            numCat = conexion.DevolverId(cate);
            btnAgregar.Enabled = true;

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if(txtNom.Text.Length > 0)
            {
                txtApe.Enabled = true;
                
            }
            else 
            {
                txtApe.Enabled = false; 
            }
            


        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {
            if (txtApe.Text.Length > 0) 
            {
                mtxTel.Enabled = true;
            }
            else
            {
                mtxTel.Enabled = false;
            }
        }

        private void mtxTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void mtxTel_Enter(object sender, EventArgs e)
        {

            if (mtxTel.Text != null)
            {
                txtCorreo.Enabled = true; 
            }
            else
            {
                txtCorreo.Enabled = false;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Length >= 0)
            {
                grbCateg.Enabled = true;
            }
            else
            {
                grbCateg.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
