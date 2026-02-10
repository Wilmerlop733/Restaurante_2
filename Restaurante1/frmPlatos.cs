using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using Restaurante1.Services;
using Restaurante1.Models;

namespace Restaurante1
{
    public partial class frmPlatos : Form
    {
        private string _currentImagePath;

        public frmPlatos()
        {
            InitializeComponent();
            ApplyStyles();
            
            LoadCategories();
            
            this.btnSave.Click += BtnSave_Click;
            this.btnUpload.Click += BtnUpload_Click;
            this.btnClear.Click += BtnClear_Click;
            this.btnLoadSuggested.Click += BtnLoadSuggested_Click;
        }
        
        private void ApplyStyles()
        {
            this.BackColor = StyleHelper.BackgroundColor;
        }

        private void LoadCategories()
        {
            try
            {
                cmbCategory.Items.Clear();
                cmbCategory.Items.Add("-- Seleccionar --");
                
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT idcategoria, nombrecat FROM categoria");
                foreach (DataRow row in dt.Rows)
                {
                    cmbCategory.Items.Add(new { Text = row["nombrecat"].ToString(), Value = row["idcategoria"] });
                }
                
                cmbCategory.DisplayMember = "Text";
                cmbCategory.ValueMember = "Value";
                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar las categorías para los platos:\n" + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Seleccionar Imagen del Plato";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadImageSafe(ofd.FileName);
                }
            }
        }

        private void LoadImageSafe(string fullPath)
        {
            try 
            {
                if (picPreview.Image != null) 
                {
                    var oldImage = picPreview.Image;
                    picPreview.Image = null;
                    oldImage.Dispose();
                }
                
                using (var temp = new Bitmap(fullPath))
                {
                    picPreview.Image = new Bitmap(temp);
                }
                
                _currentImagePath = fullPath;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error cargando imagen ({fullPath}): {ex.Message}");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del plato.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool tieneNumeros = false;
            foreach (char caracter in txtName.Text)
            {
                if (char.IsDigit(caracter))
                {
                    tieneNumeros = true;
                    break;
                }
            }

            if (tieneNumeros)
            {
                MessageBox.Show("El nombre del plato no puede contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategory.SelectedIndex <= 0)
            {
                MessageBox.Show("Por favor seleccione una categoría para el plato.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numPrice.Value <= 0)
            {
                MessageBox.Show("El precio del plato debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM platos WHERE nombreplato = @nom";
                MySqlParameter[] checkParams = { new MySqlParameter("@nom", txtName.Text.Trim()) };
                object result = DatabaseHelper.ExecuteScalar(checkQuery, checkParams);
                if (Convert.ToInt32(result) > 0)
                {
                    MessageBox.Show($"El plato '{txtName.Text}' ya está registrado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch { }

            try
            {
                dynamic selectedCat = cmbCategory.SelectedItem;
                int categoryId = (int)selectedCat.Value;

                string query = "INSERT INTO platos (nombreplato, descripcionplato, idcategoria, precio, niveldicultad, foto) " +
                               "VALUES (@nom, @desc, @cat, @pre, @dif, @foto)";
                
                MySqlParameter[] parameters = {
                    new MySqlParameter("@nom", txtName.Text),
                    new MySqlParameter("@desc", txtDesc.Text),
                    new MySqlParameter("@cat", categoryId),
                    new MySqlParameter("@pre", numPrice.Value),
                    new MySqlParameter("@dif", numDiff.Value.ToString()),
                    new MySqlParameter("@foto", _currentImagePath ?? "")
                };

                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show($"El plato '{txtName.Text}' ha sido registrado exitosamente en el menú.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el plato en la base de datos:\n" + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        
        private void BtnLoadSuggested_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex <= 0)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para poder cargar una imagen sugerida.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dynamic selectedCat = cmbCategory.SelectedItem;
                string catName = selectedCat.Text.ToLower();
                
                string fileName = "";
                if (catName.Contains("bebida")) fileName = "bebidas.jpg";
                else if (catName.Contains("fuente") || catName.Contains("plato")) fileName = "platos fuertes.jpg";
                else if (catName.Contains("postre")) fileName = "postre.jpg";

                if (!string.IsNullOrEmpty(fileName))
                {
                    string fullPath = System.IO.Path.Combine(Application.StartupPath, "Imag", fileName);
                    
                    if (!System.IO.File.Exists(fullPath))
                    {
                        fullPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Imag", fileName);
                    }

                    if (System.IO.File.Exists(fullPath))
                    {
                        LoadImageSafe(fullPath);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la imagen sugerida predefinida en la carpeta de recursos ('Imag').", "Imagen no Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Esta categoría no dispone de una imagen sugerida predeterminada.", "Sin Sugerencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar procesar la imagen sugerida:\n" + ex.Message, "Error de Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtDesc.Text = "";
            numPrice.Value = 8.99m;
            numDiff.Value = 3;
            picPreview.Image = null;
            _currentImagePath = null;
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
            txtId.Text = "0000";
        }
    }
}
