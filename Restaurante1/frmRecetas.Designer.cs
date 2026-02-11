
namespace Restaurante1
{
    partial class frmRecetas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlMain = new Panel();
            lblPlate = new Label();
            cmbPlates = new ComboBox();
            lblIngredient = new Label();
            cmbIngredients = new ComboBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            lblUnit = new Label();
            txtUnit = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            gridRecipe = new DataGridView();
            colIdIng = new DataGridViewTextBoxColumn();
            colNameIng = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridRecipe).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(33, 150, 243);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1029, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(282, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gestión de Recetas";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(lblPlate);
            pnlMain.Controls.Add(cmbPlates);
            pnlMain.Controls.Add(lblIngredient);
            pnlMain.Controls.Add(cmbIngredients);
            pnlMain.Controls.Add(lblQuantity);
            pnlMain.Controls.Add(numQuantity);
            pnlMain.Controls.Add(lblUnit);
            pnlMain.Controls.Add(txtUnit);
            pnlMain.Controls.Add(btnAdd);
            pnlMain.Controls.Add(btnRemove);
            pnlMain.Controls.Add(gridRecipe);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 80);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1029, 720);
            pnlMain.TabIndex = 1;
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlate.Location = new Point(23, 39);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(165, 28);
            lblPlate.TabIndex = 0;
            lblPlate.Text = "Seleccionar Plato:";
            // 
            // cmbPlates
            // 
            cmbPlates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlates.Font = new Font("Segoe UI", 10F);
            cmbPlates.Location = new Point(183, 36);
            cmbPlates.Margin = new Padding(3, 4, 3, 4);
            cmbPlates.Name = "cmbPlates";
            cmbPlates.Size = new Size(342, 31);
            cmbPlates.TabIndex = 1;
            // 
            // lblIngredient
            // 
            lblIngredient.AutoSize = true;
            lblIngredient.Font = new Font("Segoe UI", 10F);
            lblIngredient.Location = new Point(34, 107);
            lblIngredient.Name = "lblIngredient";
            lblIngredient.Size = new Size(102, 23);
            lblIngredient.TabIndex = 2;
            lblIngredient.Text = "Ingrediente:";
            // 
            // cmbIngredients
            // 
            cmbIngredients.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngredients.Font = new Font("Segoe UI", 10F);
            cmbIngredients.Location = new Point(183, 103);
            cmbIngredients.Margin = new Padding(3, 4, 3, 4);
            cmbIngredients.Name = "cmbIngredients";
            cmbIngredients.Size = new Size(342, 31);
            cmbIngredients.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10F);
            lblQuantity.Location = new Point(549, 107);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(83, 23);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Cantidad:";
            // 
            // numQuantity
            // 
            numQuantity.DecimalPlaces = 2;
            numQuantity.Font = new Font("Segoe UI", 10F);
            numQuantity.Location = new Point(640, 104);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(91, 30);
            numQuantity.TabIndex = 5;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 10F);
            lblUnit.Location = new Point(754, 107);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(69, 23);
            lblUnit.TabIndex = 6;
            lblUnit.Text = "Unidad:";
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("Segoe UI", 10F);
            txtUnit.Location = new Point(834, 103);
            txtUnit.Margin = new Padding(3, 4, 3, 4);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(114, 30);
            txtUnit.TabIndex = 7;
            txtUnit.Text = "gramos";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(183, 160);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 47);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Agregar Insumo";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(244, 67, 54);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(366, 160);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(171, 47);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Quitar Insumo";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // gridRecipe
            // 
            gridRecipe.AllowUserToAddRows = false;
            gridRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridRecipe.BackgroundColor = Color.WhiteSmoke;
            gridRecipe.BorderStyle = BorderStyle.None;
            gridRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRecipe.Columns.AddRange(new DataGridViewColumn[] { colIdIng, colNameIng, colQty, colUnit });
            gridRecipe.Location = new Point(34, 240);
            gridRecipe.Margin = new Padding(3, 4, 3, 4);
            gridRecipe.Name = "gridRecipe";
            gridRecipe.ReadOnly = true;
            gridRecipe.RowHeadersVisible = false;
            gridRecipe.RowHeadersWidth = 51;
            gridRecipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRecipe.Size = new Size(960, 440);
            gridRecipe.TabIndex = 10;
            // 
            // colIdIng
            // 
            colIdIng.HeaderText = "ID";
            colIdIng.MinimumWidth = 6;
            colIdIng.Name = "colIdIng";
            colIdIng.ReadOnly = true;
            colIdIng.Visible = false;
            // 
            // colNameIng
            // 
            colNameIng.HeaderText = "Ingrediente";
            colNameIng.MinimumWidth = 6;
            colNameIng.Name = "colNameIng";
            colNameIng.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "Cantidad";
            colQty.MinimumWidth = 6;
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.HeaderText = "Unidad";
            colUnit.MinimumWidth = 6;
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // frmRecetas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 800);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRecetas";
            Text = "Recetas de Cocina";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridRecipe).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.ComboBox cmbPlates;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.ComboBox cmbIngredients;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView gridRecipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
    }
}
