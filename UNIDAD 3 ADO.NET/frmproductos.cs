using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using UNIDAD_3_ADO.NET.Models;

namespace UNIDAD_3_ADO.NET
{
    public partial class frmproductos : Form
    {
        int productoSeleccionado;
        string connectionString = "Server=localhost;Database=primeraactividad;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;
        int categoriaIDSeleccionada = 0;
        int ProductoId = 0;
        public frmproductos()
        {
            InitializeComponent();
            CargarProductos();
        }



        private void CargarProductos()
        {
            using (var db = new PrimeraactividadContext())
            {
                dgvProductos.DataSource = db.Productos.ToList();

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtStock.Text) ||
                cmbCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (var db = new PrimeraactividadContext())
            {
                Producto p = new Producto();

                p.Nombreproducto = txtNombreProducto.Text;
                p.Descripcion = txtDescripcion.Text;
                p.Precio = Convert.ToDecimal(txtPrecio.Text);
                p.Stock = Convert.ToInt32(txtStock.Text);
                p.CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue);

                db.Productos.Add(p);
                db.SaveChanges();
            }

            MessageBox.Show("Producto insertado correctamente.");
            CargarProductos();
            LimpiarCampos();
        }
        private void CargarCategoriasCombo()
        {
            using (var db = new PrimeraactividadContext())
            {
                cmbCategorias.DataSource = db.Categorias.ToList();
                cmbCategorias.DisplayMember = "Nombrecategoria";
                cmbCategorias.ValueMember = "CategoriaId";
            }
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbCategorias.SelectedIndex = -1;
        }

        private void frmproductos_Load(object sender, EventArgs e)
        {
            CargarCategoriasCombo();
            CargarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                ProductoId = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ProductoId"].Value);

                txtNombreProducto.Text = dgvProductos.CurrentRow.Cells["Nombreproducto"].Value.ToString();
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();

                cmbCategorias.SelectedValue = dgvProductos.CurrentRow.Cells["CategoriaId"].Value;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            

            using (var db = new PrimeraactividadContext())
            {
                var producto = db.Productos.Find(ProductoId);

                producto.Nombreproducto = txtNombreProducto.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);
                producto.CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue);

                db.SaveChanges();
            }

            MessageBox.Show("Producto actualizado");
            CargarProductos();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            using (var db = new PrimeraactividadContext())
            {
                var producto = db.Productos.Find(ProductoId);

                db.Productos.Remove(producto);
                db.SaveChanges();
            }

            MessageBox.Show("Producto eliminado");
            CargarProductos();
            LimpiarCampos();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

        }
    }


}
