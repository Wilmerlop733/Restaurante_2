using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using Restaurante1.Services;

namespace Restaurante1
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            try 
            {
                InitializeComponent();
                ApplyStyles();
                LoadInventoryData();

                if (this.cmbManager.Items.Count > 0) this.cmbManager.SelectedIndex = 0;

                this.btnSave.Click += BtnSave_Click;
                this.btnUpdate.Click += BtnUpdate_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar correctamente el módulo de inventario.\n\nDetalles del error:\n" + ex.Message, "Error Crítico de Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyStyles()
        {
            this.BackColor = StyleHelper.BackgroundColor;
        }

        private void LoadInventoryData()
        {
            try
            {
                if (gridInventory == null) return;
                gridInventory.Rows.Clear();
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT * FROM ingredientes");
                if (dt == null) return;

                int lowStockCount = 0;

                foreach (DataRow row in dt.Rows)
                {
                    decimal stock = 0;
                    if (dt.Columns.Contains("stock"))
                    {
                        var stockVal = row["stock"];
                        stock = (stockVal == DBNull.Value) ? 0 : Convert.ToDecimal(stockVal);
                    }

                    if (stock < 10) lowStockCount++;

                    string id = "0000";
                    if (dt.Columns.Contains("idingredientes"))
                        id = Convert.ToInt32(row["idingredientes"]).ToString("D4");

                    string nombre = row.Table.Columns.Contains("nombreingre") ? row["nombreingre"].ToString() : "N/A";
                    string encargado = row.Table.Columns.Contains("encargadoingre") ? row["encargadoingre"].ToString() : "Admin";

                    gridInventory.Rows.Add(id, nombre, stock.ToString("N1"), encargado);
                }

                if (lblTotalItems != null) lblTotalItems.Text = $"Total Ingredientes: {dt.Rows.Count}";
                if (lblLowStock != null) lblLowStock.Text = $"⚠ Bajo Stock (<10): {lowStockCount} items";
                
                if (progressBar != null) progressBar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron obtener los datos de los ingredientes:\n" + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gridInventory.Rows[e.RowIndex];
                string idStr = selectedRow.Cells["colId"].Value.ToString();
                
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT * FROM ingredientes WHERE idingredientes = @id", 
                    new MySqlParameter[] { new MySqlParameter("@id", int.Parse(idStr)) });

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtId.Text = "ING-" + idStr;
                    txtName.Text = row["nombreingre"].ToString();
                    txtDesc.Text = row["descipcioningre"].ToString();
                    cmbManager.SelectedItem = row["encargadoingre"].ToString();
                    
                    decimal stock = 0;
                    if (dt.Columns.Contains("stock"))
                    {
                        stock = Convert.ToDecimal(row["stock"] == DBNull.Value ? 0 : row["stock"]);
                    }
                    numStock.Value = stock;
                    
                    if (stock < 10)
                        progressBar.ForeColor = Color.Red;
                    else
                        progressBar.ForeColor = StyleHelper.SecondaryColor;
                        
                    progressBar.Value = (int)Math.Min(100, stock);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del ingrediente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtName.Text.Length > 100)
            {
                MessageBox.Show("El nombre del ingrediente es demasiado largo (máximo 100 caracteres).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("El nombre del ingrediente no puede contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM ingredientes WHERE nombreingre = @nom";
                MySqlParameter[] checkParams = { new MySqlParameter("@nom", txtName.Text.Trim()) };
                object result = DatabaseHelper.ExecuteScalar(checkQuery, checkParams);
                if (Convert.ToInt32(result) > 0)
                {
                    MessageBox.Show($"Ya existe un ingrediente con el nombre '{txtName.Text}'.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch { }

            bool hasStockColumn = false;
            try {
                DataTable schema = DatabaseHelper.ExecuteQuery("SHOW COLUMNS FROM ingredientes LIKE 'stock'");
                hasStockColumn = schema.Rows.Count > 0;
            } catch { }

            string query;
            if (hasStockColumn)
            {
                query = "INSERT INTO ingredientes (nombreingre, descipcioningre, encargadoingre, stock) VALUES (@nom, @desc, @enc, @stock)";
            }
            else
            {
                query = "INSERT INTO ingredientes (nombreingre, descipcioningre, encargadoingre) VALUES (@nom, @desc, @enc)";
            }

            MySqlParameter[] parameters = {
                new MySqlParameter("@nom", txtName.Text),
                new MySqlParameter("@desc", txtDesc.Text),
                new MySqlParameter("@enc", cmbManager.SelectedItem?.ToString() ?? "Admin"),
                new MySqlParameter("@stock", numStock.Value)
            };

            if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
            {
                MessageBox.Show("El ingrediente se ha registrado exitosamente en el inventario.", "Ingrediente Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadInventoryData();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || txtId.Text == "0000") return;
            
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("El nombre del ingrediente no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool tieneNumeros = false;
            foreach (char letra in txtName.Text)
            {
                if (char.IsDigit(letra))
                {
                    tieneNumeros = true;
                    break;
                }
            }

            if (tieneNumeros)
            {
                MessageBox.Show("El nombre del ingrediente no puede contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string idStr = txtId.Text.Replace("ING-", "");
                string checkQuery = "SELECT COUNT(*) FROM ingredientes WHERE nombreingre = @nom AND idingredientes != @id";
                MySqlParameter[] checkParams = { 
                    new MySqlParameter("@nom", txtName.Text.Trim()),
                    new MySqlParameter("@id", int.Parse(idStr))
                };
                object result = DatabaseHelper.ExecuteScalar(checkQuery, checkParams);
                if (Convert.ToInt32(result) > 0)
                {
                    MessageBox.Show($"Ya existe otro ingrediente llamado '{txtName.Text}'.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch { }

            string idPart = txtId.Text.Replace("ING-", "");

            bool hasStockColumn = false;
            try {
                DataTable schema = DatabaseHelper.ExecuteQuery("SHOW COLUMNS FROM ingredientes LIKE 'stock'");
                hasStockColumn = schema.Rows.Count > 0;
            } catch { }

            string query;
            if (hasStockColumn)
            {
                query = "UPDATE ingredientes SET nombreingre=@nom, descipcioningre=@desc, encargadoingre=@enc, stock=@stock WHERE idingredientes=@id";
            }
            else
            {
                query = "UPDATE ingredientes SET nombreingre=@nom, descipcioningre=@desc, encargadoingre=@enc WHERE idingredientes=@id";
            }

            MySqlParameter[] parameters = {
                new MySqlParameter("@nom", txtName.Text),
                new MySqlParameter("@desc", txtDesc.Text),
                new MySqlParameter("@enc", cmbManager.SelectedItem?.ToString() ?? "Admin"),
                new MySqlParameter("@stock", numStock.Value),
                new MySqlParameter("@id", int.Parse(idPart))
            };

            if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
            {
                MessageBox.Show("Los datos del ingrediente han sido actualizados correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadInventoryData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || txtId.Text == "0000") return;

            if (MessageBox.Show("¿Está seguro de que desea eliminar este ingrediente del inventario? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string idPart = txtId.Text.Replace("ING-", "");
                string query = "DELETE FROM ingredientes WHERE idingredientes=@id";
                MySqlParameter[] parameters = { new MySqlParameter("@id", idPart) };

                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    ClearForm();
                    LoadInventoryData();
                }
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (gridInventory.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos disponibles en la tabla para realizar la exportación.", "Aviso de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo de Excel (*.xls)|*.xls";
                sfd.FileName = "Reporte_Inventario_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xls";
                sfd.Title = "Exportar Inventario Profesional";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var html = new System.Text.StringBuilder();

                        html.AppendLine("<html><head><meta charset='utf-8'>");
                        html.AppendLine("<style>");
                        html.AppendLine("table { border-collapse: collapse; width: 100%; font-family: 'Segoe UI', Arial, sans-serif; }");
                        html.AppendLine("th { background-color: #2196F3; color: white; padding: 12px; text-align: left; border: 1px solid #ddd; }");
                        html.AppendLine("td { padding: 10px; border: 1px solid #ddd; }");
                        html.AppendLine("tr:nth-child(even) { background-color: #f2f2f2; }");
                        html.AppendLine(".header-title { font-size: 24px; color: #333; margin-bottom: 20px; font-weight: bold; }");
                        html.AppendLine("</style></head><body>");

                        html.AppendLine("<div class='header-title'>Reporte de Inventario - Restaurante App</div>");
                        html.AppendLine("<p>Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "</p>");
                        
                        html.AppendLine("<table>");
                        
                        // Encabezados
                        html.AppendLine("<thead><tr><th>ID</th><th>Nombre</th><th>Stock (U/kg)</th><th>Encargado</th></tr></thead>");

                        // Datos
                        html.AppendLine("<tbody>");
                        foreach (DataGridViewRow row in gridInventory.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                html.AppendLine("<tr>");
                                html.AppendLine("  <td>" + (row.Cells["colId"].Value?.ToString() ?? "") + "</td>");
                                html.AppendLine("  <td>" + (row.Cells["colName"].Value?.ToString() ?? "") + "</td>");
                                html.AppendLine("  <td>" + (row.Cells["colStock"].Value?.ToString() ?? "0") + "</td>");
                                html.AppendLine("  <td>" + (row.Cells["colManager"].Value?.ToString() ?? "") + "</td>");
                                html.AppendLine("</tr>");
                            }
                        }
                        html.AppendLine("</tbody></table></body></html>");

                        System.IO.File.WriteAllText(sfd.FileName, html.ToString(), System.Text.Encoding.UTF8);
                        
                        MessageBox.Show("¡Reporte generado con éxito!\n\nEl archivo se ha guardado en:\n" + sfd.FileName, 
                            "Exportación Profesional", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error inesperado al intentar generar el archivo Excel:\n" + ex.Message, "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtId.Text = "0000";
            txtName.Clear();
            txtDesc.Clear();
            if (cmbManager.Items.Count > 0) cmbManager.SelectedIndex = 0;
            numStock.Value = 0;
            progressBar.Value = 0;
        }
    }
}
