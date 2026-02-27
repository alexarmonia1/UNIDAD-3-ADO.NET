using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace UNIDAD_3_ADO.NET
{
    public partial class frmclientes : Form
    {

        string connectionString = "Server=localhost;Database=primeraactividad;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;
        public frmclientes()
        {
            InitializeComponent();
            CargarDatos();
        }



        private void CargarDatos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM clientes";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvClientes.DataSource = dt;

            }
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO clientes (nombrecompleto, correoelectronico, telefono, direccion) VALUES (@Nombre, @Correo, @telefono, @direccion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombreCompleto.Text);
                cmd.Parameters.AddWithValue("@Correo", txtCorreoElectronico.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);

                MessageBox.Show("Cliente insertado correctamente.");
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreCompleto.Clear();
            txtCorreoElectronico.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            idSeleccionado = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
                return;



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE clientes SET nombrecompleto=@Nombre, correoelectronico=@Correo, telefono=@telefono, direccion=@direccion WHERE clienteID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombreCompleto.Text);
                cmd.Parameters.AddWithValue("@Correo", txtCorreoElectronico.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);

                MessageBox.Show("Cliente actualizado correctamente.");
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["clienteID"].Value);
                txtNombreCompleto.Text = fila.Cells["nombrecompleto"].Value.ToString();
                txtCorreoElectronico.Text = fila.Cells["correoelectronico"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
                return;



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM clientes WHERE clienteID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);

                MessageBox.Show("Cliente eliminado correctamente.");
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
        }
    }
}
