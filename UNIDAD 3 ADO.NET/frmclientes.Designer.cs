namespace UNIDAD_3_ADO.NET
{
    partial class frmclientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombreCompleto = new TextBox();
            txtCorreoElectronico = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 102);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 0;
            label2.Text = "Correo Electronico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 45);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 0;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 105);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 0;
            label4.Text = "Direccion";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(171, 39);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(150, 31);
            txtNombreCompleto.TabIndex = 1;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(171, 102);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(150, 31);
            txtCorreoElectronico.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(470, 45);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(470, 102);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 1;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(40, 156);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 34);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(171, 156);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(311, 156);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(17, 196);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(729, 251);
            dgvClientes.TabIndex = 3;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // frmclientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmclientes";
            Text = "frmclientes";
            Load += frmclientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreCompleto;
        private TextBox txtCorreoElectronico;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvClientes;
    }
}