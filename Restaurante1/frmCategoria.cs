using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using Restaurante1.Services;
using Restaurante1.Models;

namespace Restaurante1
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
            ApplyStyles();
            LoadData();

            this.btnSave.Click += BtnSave_Click;
            this.gridCategories.CellClick += GridCategories_CellClick;
        }

        private void ApplyStyles()
        {
            this.BackColor = StyleHelper.BackgroundColor;

            StyleHelper.StyleButton(btnSave, StyleHelper.SecondaryColor);
            StyleHelper.StyleButton(btnDelete, StyleHelper.DangerColor);

            StyleHelper.StyleTextBox(txtName);
            StyleHelper.StyleTextBox(txtDesc);

            btnSave.Text = "GUARDAR";
            btnDelete.Visible = false;
        }

        private void LoadData()
        {
            try
            {
                gridCategories.Rows.Clear();
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT * FROM categoria");
                foreach (DataRow row in dt.Rows)
                {
                    gridCategories.Rows.Add(
                        Convert.ToInt32(row["idcategoria"]).ToString("D4"),
                        row["nombrecat"].ToString(),
                        row["descripcioncat"].ToString(),
                        row["encargadocat"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las categorías desde la base de datos:\n" + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = gridCategories.Rows[e.RowIndex];

                txtId.Text = fila.Cells[0].Value.ToString();
                txtName.Text = fila.Cells[1].Value.ToString();
                txtDesc.Text = fila.Cells[2].Value.ToString();

                string encargado = fila.Cells[3].Value?.ToString();
                if (cmbManager.Items.Contains(encargado))
                {
                    cmbManager.SelectedItem = encargado;
                }

                btnSave.Text = "ACTUALIZAR";
                btnDelete.Visible = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || txtId.Text == "AUTO") return;

            if (MessageBox.Show("¿Está realmente seguro de que desea eliminar esta categoría? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM categoria WHERE idcategoria=@id";
                MySqlParameter[] parameters = { new MySqlParameter("@id", txtId.Text) };

                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("La categoría ha sido eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre para la categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtName.Text.Length > 50)
            {
                MessageBox.Show("El nombre de la categoría es demasiado largo (máximo 50 caracteres).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool tieneNumeros = false;
            foreach (char c in txtName.Text)
            {
                if (char.IsDigit(c))
                {
                    tieneNumeros = true;
                    break;
                }
            }

            if (tieneNumeros)
            {
                MessageBox.Show("El nombre de la categoría no puede contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombreLimpio = txtName.Text.Trim();
                string queryVerificar = "SELECT COUNT(*) FROM categoria WHERE nombrecat = @nom";

                if (btnSave.Text.ToUpper() == "ACTUALIZAR")
                {
                    queryVerificar += " AND idcategoria != @id";
                }

                MySqlParameter[] parametrosVerificar = {
                    new MySqlParameter("@nom", nombreLimpio),
                    new MySqlParameter("@id", txtId.Text)
                };

                object resultado = DatabaseHelper.ExecuteScalar(queryVerificar, parametrosVerificar);
                if (Convert.ToInt32(resultado) > 0)
                {
                    MessageBox.Show($"La categoría '{nombreLimpio}' ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar duplicados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string consultaFinal;
            MySqlParameter[] parametrosFinales;

            if (btnSave.Text.ToUpper() == "GUARDAR")
            {
                consultaFinal = "INSERT INTO categoria (nombrecat, descripcioncat, encargadocat) VALUES (@nom, @desc, @enc)";
                parametrosFinales = new MySqlParameter[] {
                    new MySqlParameter("@nom", txtName.Text.Trim()),
                    new MySqlParameter("@desc", txtDesc.Text.Trim()),
                    new MySqlParameter("@enc", cmbManager.SelectedItem?.ToString() ?? "N/A")
                };
            }
            else
            {
                consultaFinal = "UPDATE categoria SET nombrecat=@nom, descripcioncat=@desc, encargadocat=@enc WHERE idcategoria=@id";
                parametrosFinales = new MySqlParameter[] {
                    new MySqlParameter("@nom", txtName.Text.Trim()),
                    new MySqlParameter("@desc", txtDesc.Text.Trim()),
                    new MySqlParameter("@enc", cmbManager.SelectedItem?.ToString() ?? "N/A"),
                    new MySqlParameter("@id", txtId.Text)
                };
            }

            try
            {
                if (DatabaseHelper.ExecuteNonQuery(consultaFinal, parametrosFinales) > 0)
                {
                    MessageBox.Show("Categoría guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("No se realizaron cambios en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtId.Text = "0000";
            txtName.Text = "";
            txtDesc.Text = "";
            if (cmbManager.Items.Count > 0) cmbManager.SelectedIndex = 0;
            btnSave.Text = "GUARDAR";
            btnDelete.Visible = false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
