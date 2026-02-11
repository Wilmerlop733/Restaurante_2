using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Restaurante1.Services;

namespace Restaurante1
{
    public partial class frmRecetas : Form
    {
        public frmRecetas()
        {
            InitializeComponent();
            LoadPlates();
            LoadIngredients();

            this.cmbPlates.SelectedIndexChanged += (s, e) => LoadRecipe();
            this.btnAdd.Click += BtnAdd_Click;
            this.btnRemove.Click += BtnRemove_Click;
        }

        private void LoadPlates()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT idplato, nombreplato FROM platos");
                cmbPlates.DataSource = dt;
                cmbPlates.DisplayMember = "nombreplato";
                cmbPlates.ValueMember = "idplato";
                if (cmbPlates.Items.Count > 0) cmbPlates.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar platos: " + ex.Message);
            }
        }

        private void LoadIngredients()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT idingredientes, nombreingre FROM ingredientes");
                cmbIngredients.DataSource = dt;
                cmbIngredients.DisplayMember = "nombreingre";
                cmbIngredients.ValueMember = "idingredientes";
                if (cmbIngredients.Items.Count > 0) cmbIngredients.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ingredientes: " + ex.Message);
            }
        }

        private void LoadRecipe()
        {
            if (cmbPlates.SelectedValue == null || !(cmbPlates.SelectedValue is int)) return;

            int plateId = (int)cmbPlates.SelectedValue;
            try
            {
                string query = @"SELECT r.idingredientes, i.nombreingre, r.cantidad, r.unidad_medida 
                                 FROM receta r 
                                 INNER JOIN ingredientes i ON r.idingredientes = i.idingredientes 
                                 WHERE r.idplato = @id";
                
                MySqlParameter[] p = { new MySqlParameter("@id", plateId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, p);

                gridRecipe.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    gridRecipe.Rows.Add(row["idingredientes"], row["nombreingre"], row["cantidad"], row["unidad_medida"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la receta: " + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbPlates.SelectedValue == null || cmbIngredients.SelectedValue == null) return;

            int plateId = (int)cmbPlates.SelectedValue;
            int ingId = (int)cmbIngredients.SelectedValue;
            decimal qty = numQuantity.Value;
            string unit = txtUnit.Text.Trim();

            if (qty <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            try
            {
                // UPSERT logic: check if exists
                string check = "SELECT COUNT(*) FROM receta WHERE idplato = @p AND idingredientes = @i";
                MySqlParameter[] checkP = { 
                    new MySqlParameter("@p", plateId), 
                    new MySqlParameter("@i", ingId) 
                };

                int exists = Convert.ToInt32(DatabaseHelper.ExecuteScalar(check, checkP));

                string sql;
                if (exists > 0)
                {
                    sql = "UPDATE receta SET cantidad = @q, unidad_medida = @u WHERE idplato = @p AND idingredientes = @i";
                }
                else
                {
                    sql = "INSERT INTO receta (idplato, idingredientes, cantidad, unidad_medida) VALUES (@p, @i, @q, @u)";
                }

                MySqlParameter[] p = {
                    new MySqlParameter("@p", plateId),
                    new MySqlParameter("@i", ingId),
                    new MySqlParameter("@q", qty),
                    new MySqlParameter("@u", unit)
                };

                if (DatabaseHelper.ExecuteNonQuery(sql, p) > 0)
                {
                    LoadRecipe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el insumo en la receta: " + ex.Message);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (gridRecipe.SelectedRows.Count == 0 || cmbPlates.SelectedValue == null) return;

            int plateId = (int)cmbPlates.SelectedValue;
            int ingId = Convert.ToInt32(gridRecipe.SelectedRows[0].Cells["colIdIng"].Value);

            try
            {
                string sql = "DELETE FROM receta WHERE idplato = @p AND idingredientes = @i";
                MySqlParameter[] p = {
                    new MySqlParameter("@p", plateId),
                    new MySqlParameter("@i", ingId)
                };

                if (DatabaseHelper.ExecuteNonQuery(sql, p) > 0)
                {
                    LoadRecipe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al quitar el insumo: " + ex.Message);
            }
        }
    }
}
