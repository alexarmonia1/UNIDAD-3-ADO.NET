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
    public partial class frmproveedores : Form
    {

        string connectionString = "Server=localhost;Database=primeraactividad;Trusted_Connection=True;TrustServerCertificate=True;";
        int idseleccionado = 0;
        public frmproveedores()
        {
            InitializeComponent();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM proveedores";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvProveedores.DataSource = dt;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmproveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO proveedores (nombreproveedor, telefono, direccion) VALUES (@Nombre, @Telefono, @Direccion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombreProveedor.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor insertado correctamente.");

            }
            CargarProveedores();
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombreProveedor.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (idseleccionado <= 0)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE proveedores SET nombreproveedor =@Nombre, telefono= @Telefono, direccion =@Direccion WHERE proveedorID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombreProveedor.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Id", idseleccionado);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor actualizado correctamente.");
            }
            CargarProveedores();
            LimpiarCampos();

        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedores.Rows[e.RowIndex];
                idseleccionado = Convert.ToInt32(row.Cells["proveedorID"].Value);
                txtNombreProveedor.Text = row.Cells["nombreproveedor"].Value.ToString();
                txtTelefono.Text = row.Cells["telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["direccion"].Value.ToString();
            }
        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }   
            if (MessageBox.Show("¿Está seguro de que desea eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (idseleccionado <= 0)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM proveedores WHERE proveedorID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idseleccionado);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente.");
                
            }
            CargarProveedores();
            LimpiarCampos();
        }
    }
}
