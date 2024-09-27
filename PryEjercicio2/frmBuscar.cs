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

    public partial class frmBuscar : Form
    {
        conexionBD conexion = new conexionBD();
        int numCat;
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cate = cmbCateg.SelectedItem.ToString();
            numCat = conexion.DevolverId(cate);
            if (cmbCateg.SelectedItem != null)
            {
                btnBuscCat.Enabled = true;
            }
            else
            {
                btnBuscCat.Enabled = false;
            }
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            List<string> categorias = conexion.ImprimirCateg(cmbCateg);
            cmbCateg.Items.Clear();
            cmbCateg.Items.AddRange(categorias.ToArray());
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
       
       {
            if (txtNom.Text.Length > 0)
            {
                btnBuscNom.Enabled = true;

            }
            else
            {
                btnBuscNom.Enabled = false;
            }
        }

        private void btnBuscNom_Click(object sender, EventArgs e)
        {
            
                dgvGrilla.Columns.Clear();

                DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas Buscar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("Has seleccionado Sí.");
                    conexion.ImprimirPorNom(dgvGrilla, txtNom.Text);
                    txtNom.Text = "";
                    btnBuscNom.Enabled = false;
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Has seleccionado No.");
                }
            
        }

        private void btnBuscCat_Click(object sender, EventArgs e)
        {
            dgvGrilla.Rows.Clear();

            DialogResult result = MessageBox.Show(" Cuidado! Estás seguro de que deseas Buscar?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Has seleccionado Sí.");
                conexion.ImprimirPorCat(dgvGrilla, cmbCateg.SelectedItem.ToString());
                cmbCateg.SelectedItem = null;
                btnBuscCat.Enabled = false;
            }
            else if (result == DialogResult.No)
            {

                MessageBox.Show("Has seleccionado No.");
            }
        }
    }
}
