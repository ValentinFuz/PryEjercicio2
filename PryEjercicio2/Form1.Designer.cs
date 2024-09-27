namespace PryEjercicio2
{
    partial class frmAgregar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.mtxTel = new System.Windows.Forms.MaskedTextBox();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.grbCateg = new System.Windows.Forms.GroupBox();
            this.btnAgregarCateg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewCateg = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grbCateg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(29, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 71);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Usuario y Listar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(353, 43);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(314, 382);
            this.dgvGrilla.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNom.Location = new System.Drawing.Point(99, 20);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(222, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Correo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(175, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria Existente";
            // 
            // txtApe
            // 
            this.txtApe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtApe.Enabled = false;
            this.txtApe.Location = new System.Drawing.Point(99, 55);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(222, 20);
            this.txtApe.TabIndex = 1;
            this.txtApe.TextChanged += new System.EventHandler(this.txtApe_TextChanged);
            // 
            // mtxTel
            // 
            this.mtxTel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mtxTel.Enabled = false;
            this.mtxTel.Location = new System.Drawing.Point(99, 86);
            this.mtxTel.Mask = "(999)000-0000";
            this.mtxTel.Name = "mtxTel";
            this.mtxTel.Size = new System.Drawing.Size(222, 20);
            this.mtxTel.TabIndex = 2;
            this.mtxTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxTel_MaskInputRejected);
            this.mtxTel.Enter += new System.EventHandler(this.mtxTel_Enter);
            // 
            // cmbCateg
            // 
            this.cmbCateg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Items.AddRange(new object[] {
            "Familia",
            "Trabajo",
            "Amigos"});
            this.cmbCateg.Location = new System.Drawing.Point(156, 77);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(140, 22);
            this.cmbCateg.TabIndex = 4;
            this.cmbCateg.SelectedIndexChanged += new System.EventHandler(this.cmbCateg_SelectedIndexChanged);
            // 
            // grbCateg
            // 
            this.grbCateg.BackColor = System.Drawing.Color.DarkOrange;
            this.grbCateg.Controls.Add(this.btnAgregarCateg);
            this.grbCateg.Controls.Add(this.label6);
            this.grbCateg.Controls.Add(this.txtNewCateg);
            this.grbCateg.Controls.Add(this.cmbCateg);
            this.grbCateg.Controls.Add(this.label5);
            this.grbCateg.Enabled = false;
            this.grbCateg.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCateg.Location = new System.Drawing.Point(12, 166);
            this.grbCateg.Name = "grbCateg";
            this.grbCateg.Size = new System.Drawing.Size(316, 138);
            this.grbCateg.TabIndex = 10;
            this.grbCateg.TabStop = false;
            this.grbCateg.Text = "Categorias";
            this.grbCateg.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAgregarCateg
            // 
            this.btnAgregarCateg.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCateg.Location = new System.Drawing.Point(30, 85);
            this.btnAgregarCateg.Name = "btnAgregarCateg";
            this.btnAgregarCateg.Size = new System.Drawing.Size(84, 41);
            this.btnAgregarCateg.TabIndex = 12;
            this.btnAgregarCateg.Text = "Agregar Categoria";
            this.btnAgregarCateg.UseVisualStyleBackColor = false;
            this.btnAgregarCateg.Click += new System.EventHandler(this.btnAgregarCateg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nueva Categoria";
            // 
            // txtNewCateg
            // 
            this.txtNewCateg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNewCateg.Location = new System.Drawing.Point(17, 59);
            this.txtNewCateg.Name = "txtNewCateg";
            this.txtNewCateg.Size = new System.Drawing.Size(107, 21);
            this.txtNewCateg.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCorreo.Location = new System.Drawing.Point(99, 122);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(222, 20);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lista";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.Location = new System.Drawing.Point(190, 364);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 40);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(679, 437);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.grbCateg);
            this.Controls.Add(this.mtxTel);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.btnAgregar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grbCateg.ResumeLayout(false);
            this.grbCateg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.MaskedTextBox mtxTel;
        private System.Windows.Forms.ComboBox cmbCateg;
        private System.Windows.Forms.GroupBox grbCateg;
        private System.Windows.Forms.Button btnAgregarCateg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewCateg;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolver;
    }
}

