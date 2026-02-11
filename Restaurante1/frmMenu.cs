using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurante1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            OpenFormInPanel(new frmBienvenido());
        }

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmBienvenido());
            lblTitle.Text = "Sistema de Gestión - Inicio";
        }

        private void OpenFormInPanel(Form childForm)
        {
            if (this.pnlContent.Controls.Count > 0)
                this.pnlContent.Controls.RemoveAt(0);

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.pnlContent.Controls.Add(childForm);
            this.pnlContent.Tag = childForm;
            childForm.Show();
        }

        private void btnNavInventory_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmInventario());
            lblTitle.Text = "Sistema de Gestión - Inventario";
        }

        private void btnNavCategories_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmCategoria());
            lblTitle.Text = "Sistema de Gestión - Categorías";
        }

        private void btnNavDishes_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmPlatos());
            lblTitle.Text = "Sistema de Gestión - Registro de Platos";
        }

        private void btnNavRecipes_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmRecetas());
            lblTitle.Text = "Sistema de Gestión - Recetas de Cocina";
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conn = conexionBD.GetConnection();

            if (conn != null && conexionBD.OpenConnection(conn))
            {
                MessageBox.Show("Se ha establecido correctamente la conexión con el servidor MySQL.", "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexionBD.CloseConnection(conn);
            }
            else
            {
                MessageBox.Show("No se pudo establecer comunicación con el servidor de base de datos. Por favor, asegúrese de que el servicio MySQL esté activo.", "Fallo de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
