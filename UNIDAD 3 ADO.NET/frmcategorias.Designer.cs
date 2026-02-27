namespace UNIDAD_3_ADO.NET
{
    partial class frmcategorias
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
            txtNombreCategoria = new TextBox();
            dgvcategorias = new DataGridView();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvcategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 66);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Categoria";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(109, 94);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(150, 31);
            txtNombreCategoria.TabIndex = 1;
            // 
            // dgvcategorias
            // 
            dgvcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcategorias.Location = new Point(109, 131);
            dgvcategorias.Name = "dgvcategorias";
            dgvcategorias.ReadOnly = true;
            dgvcategorias.RowHeadersWidth = 62;
            dgvcategorias.Size = new Size(517, 225);
            dgvcategorias.TabIndex = 2;
            dgvcategorias.CellClick += dgvcategorias_CellClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(265, 91);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 34);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(383, 91);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(514, 91);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmcategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(dgvcategorias);
            Controls.Add(txtNombreCategoria);
            Controls.Add(label1);
            Name = "frmcategorias";
            Text = "frmcategorias";
            Load += frmcategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvcategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreCategoria;
        private DataGridView dgvcategorias;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}