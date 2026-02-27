namespace UNIDAD_3_ADO.NET
{
    public partial class Form1 : Form
    {
        frmclientes frmclientes = new frmclientes();
        frmcategorias frmcategorias = new frmcategorias();
        frmproveedores frmproveedores = new frmproveedores();
        frmproductos frmproductos = new frmproductos();



        public Form1()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmclientes.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategorias.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproveedores.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproductos.ShowDialog();
        }
    }
}
