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

namespace UNIDAD_3_ADO.NET
{
    public partial class frmproductos : Form
    {
        int productoSeleccionado;
        string connectionString = "Server=localhost;Database=primeraactividad;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;
        int categoriaIDSeleccionada = 0;
        public frmproductos()
        {
            InitializeComponent();
            CargarProductos();
        }



        private void CargarProductos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM productos";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvProductos.DataSource = dt;
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

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                int categoriaIDSeleccionada = Convert.ToInt32(cmbCategorias.SelectedValue);

                string query = @"INSERT INTO Productos
                        (nombreproducto, descripcion, precio, stock, categoriaID)
                        VALUES (@Nombre, @Descripcion, @Precio, @Stock, @Id)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@Id", categoriaIDSeleccionada);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Producto insertado correctamente.");
            CargarProductos();
            LimpiarCampos();
        }
        private void CargarCategoriasCombo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT categoriaID, nombrecategoria FROM categorias";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbCategorias.DataSource = dt;
                cmbCategorias.DisplayMember = "nombrecategoria";
                cmbCategorias.ValueMember = "categoriaID";
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
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvProductos.CurrentRow != null)
            {
                productoSeleccionado = Convert.ToInt32(
                    dgvProductos.CurrentRow.Cells["productoID"].Value);

                txtNombreProducto.Text =
                    dgvProductos.CurrentRow.Cells["nombreproducto"].Value.ToString();

                txtDescripcion.Text =
                    dgvProductos.CurrentRow.Cells["descripcion"].Value.ToString();

                txtPrecio.Text =
                    dgvProductos.CurrentRow.Cells["precio"].Value.ToString();

                txtStock.Text =
                    dgvProductos.CurrentRow.Cells["stock"].Value.ToString();

                cmbCategorias.SelectedValue =
                    dgvProductos.CurrentRow.Cells["categoriaID"].Value;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado <= 0)
                {
                    MessageBox.Show("Por favor, seleccione un producto para actualizar.", "aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE productos
                         SET nombreproducto = @Nombre,
                             descripcion = @Descripcion,
                             precio = @Precio,
                             stock = @Stock,
                             categoriaID = @CategoriaID
                         WHERE productoID = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                cmd.Parameters.AddWithValue("@CategoriaID",
                                            Convert.ToInt32(cmbCategorias.SelectedValue));
                cmd.Parameters.AddWithValue("@Id", productoSeleccionado);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Producto actualizado correctamente.");
            CargarProductos();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado <= 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM productos WHERE productoID = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", productoSeleccionado);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Producto eliminado correctamente.");
            CargarProductos();
            LimpiarCampos();
        }
    }


}
