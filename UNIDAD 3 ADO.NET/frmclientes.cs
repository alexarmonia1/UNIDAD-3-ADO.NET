using UNIDAD_3_ADO.NET.Models;
using System.Linq;
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
            using (var db = new PrimeraactividadContext())
            {
                dgvClientes.DataSource = db.Clientes.ToList();
            }
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           

            using (var db = new PrimeraactividadContext())
            {
                Cliente nuevo = new Cliente()
                {
                    Nombrecompleto = txtNombreCompleto.Text,
                    CorreoElectronico = txtCorreoElectronico.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text,

                };

                db.Clientes.Add(nuevo);
                db.SaveChanges();
            }

            CargarDatos();
            MessageBox.Show("Cliente guardado correctamente");
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
            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);

            using (var db = new PrimeraactividadContext())
            {
                var cliente = db.Clientes.Find(id);

                if (cliente != null)
                {
                    cliente.Nombrecompleto = txtNombreCompleto.Text;
                    cliente.CorreoElectronico = txtCorreoElectronico.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Direccion = txtDireccion.Text;

                    db.SaveChanges();
                }
            }
            CargarDatos();
            MessageBox.Show("cliente actualizado correctamente");
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
            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);

            using (var db = new PrimeraactividadContext())
            {
                var cliente = db.Clientes.Find(id);

                if (cliente != null)
                {
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                }
            }

            CargarDatos();
            MessageBox.Show("cliente eliminado correctamente");
            CargarDatos();
            LimpiarCampos();
        }
    }
}
