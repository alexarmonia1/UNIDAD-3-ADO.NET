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
    public partial class frmcategorias : Form
    {
        string connectionString = "Server=localhost;Database=primeraactividad;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;

        public frmcategorias()
        {
            InitializeComponent();
            CargarCategoria();
        }

        private void CargarCategoria()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM categorias";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvcategorias.DataSource = dt;
            }
        }



        private void frmcategorias_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("Por favor, complete el campo de nombre de categoría.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO categorias(nombrecategoria) VALUES (@Nombre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombreCategoria.Text);


                MessageBox.Show("Categoria insertada correctamente.");
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarCategoria();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreCategoria.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione una categoría para actualizar.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("Por favor, complete el campo de nombre de categoría.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE categorias SET nombrecategoria = @Nombre WHERE categoriaID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombreCategoria.Text);
                cmd.Parameters.AddWithValue("@Id", idSeleccionado);
                MessageBox.Show("Categoría actualizada correctamente.");
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarCategoria();
            LimpiarCampos();

        }

        private void dgvcategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvcategorias.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(row.Cells["categoriaID"].Value);
                txtNombreCategoria.Text = row.Cells["nombrecategoria"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Por favor, seleccione una categoría para eliminar.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM categorias WHERE categoriaID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idSeleccionado);
                MessageBox.Show("Categoría eliminada correctamente.");
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarCategoria();
            LimpiarCampos();
        }
    }
}
