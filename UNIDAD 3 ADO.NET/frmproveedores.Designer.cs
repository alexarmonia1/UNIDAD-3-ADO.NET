namespace UNIDAD_3_ADO.NET
{
    partial class frmproveedores
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
            txtNombreProveedor = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            btnInsertar = new Button();
            txtEliminar = new Button();
            btnActualizar = new Button();
            dgvProveedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Proveedor";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(212, 39);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(150, 31);
            txtNombreProveedor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 152);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 0;
            label2.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(212, 152);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 1;
            txtDireccion.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 94);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 0;
            label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(212, 94);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 1;
            txtTelefono.TextChanged += textBox3_TextChanged;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(250, 189);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 34);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(250, 269);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(112, 34);
            txtEliminar.TabIndex = 2;
            txtEliminar.Text = "eliminar";
            txtEliminar.UseVisualStyleBackColor = true;
            txtEliminar.Click += txtEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(250, 229);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(403, 39);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(494, 264);
            dgvProveedores.TabIndex = 3;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            // 
            // frmproveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(dgvProveedores);
            Controls.Add(btnActualizar);
            Controls.Add(txtEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(txtNombreProveedor);
            Controls.Add(label1);
            Name = "frmproveedores";
            Text = "frmproveedores";
            Load += frmproveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreProveedor;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtTelefono;
        private Button btnInsertar;
        private Button txtEliminar;
        private Button btnActualizar;
        private DataGridView dgvProveedores;
    }
}