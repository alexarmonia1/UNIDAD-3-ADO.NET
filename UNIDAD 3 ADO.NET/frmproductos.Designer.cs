namespace UNIDAD_3_ADO.NET
{
    partial class frmproductos
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
            txtNombreProducto = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            cmbCategorias = new ComboBox();
            dgvProductos = new DataGridView();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(199, 35);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(150, 31);
            txtNombreProducto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 87);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 0;
            label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(199, 81);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 35);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 0;
            label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(457, 35);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 87);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 0;
            label4.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(457, 81);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 135);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 0;
            label5.Text = "Categoria";
            label5.Click += label5_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Items.AddRange(new object[] { "electronica", "salud y belleza", "ropa", "cocina" });
            cmbCategorias.Location = new Point(425, 132);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(182, 33);
            cmbCategorias.TabIndex = 2;
            cmbCategorias.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(29, 171);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(759, 275);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(654, 35);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 34);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(654, 79);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(654, 126);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmproductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(dgvProductos);
            Controls.Add(cmbCategorias);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtNombreProducto);
            Controls.Add(label1);
            Name = "frmproductos";
            Text = "frmproductos";
            Load += frmproductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreProducto;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private ComboBox cmbCategorias;
        private DataGridView dgvProductos;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}