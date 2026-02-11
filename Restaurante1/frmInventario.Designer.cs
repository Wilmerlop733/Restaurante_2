
namespace Restaurante1
{
    partial class frmInventario
    {
        private System.ComponentModel.IContainer components = null;


        private System.Windows.Forms.Panel mainCard;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label lblHeaderGrid;
        private System.Windows.Forms.DataGridView gridInventory;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblLastUpdate;

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
            mainCard = new Panel();
            lblHeader = new Label();
            lblSubHeader = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblStock = new Label();
            numStock = new NumericUpDown();
            lblUnit = new Label();
            progressBar = new ProgressBar();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExport = new Button();
            rightPanel = new Panel();
            lblHeaderGrid = new Label();
            gridInventory = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            statsPanel = new Panel();
            lblTotalItems = new Label();
            lblLowStock = new Label();
            lblLastUpdate = new Label();
            mainCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridInventory).BeginInit();
            statsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainCard
            // 
            mainCard.BackColor = Color.White;
            mainCard.Controls.Add(lblHeader);
            mainCard.Controls.Add(lblSubHeader);
            mainCard.Controls.Add(lblId);
            mainCard.Controls.Add(txtId);
            mainCard.Controls.Add(lblName);
            mainCard.Controls.Add(txtName);
            mainCard.Controls.Add(lblStock);
            mainCard.Controls.Add(numStock);
            mainCard.Controls.Add(lblUnit);
            mainCard.Controls.Add(progressBar);
            mainCard.Controls.Add(btnSave);
            mainCard.Controls.Add(btnUpdate);
            mainCard.Controls.Add(btnDelete);
            mainCard.Controls.Add(btnExport);
            mainCard.Location = new Point(39, 53);
            mainCard.Margin = new Padding(3, 5, 3, 5);
            mainCard.Name = "mainCard";
            mainCard.Size = new Size(569, 853);
            mainCard.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(50, 50, 50);
            lblHeader.Location = new Point(26, 36);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(399, 31);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Gestión de Inventario - Ingredientes";
            // 
            // lblSubHeader
            // 
            lblSubHeader.AutoSize = true;
            lblSubHeader.Font = new Font("Segoe UI", 10F);
            lblSubHeader.ForeColor = Color.Gray;
            lblSubHeader.Location = new Point(26, 89);
            lblSubHeader.Name = "lblSubHeader";
            lblSubHeader.Size = new Size(296, 23);
            lblSubHeader.TabIndex = 1;
            lblSubHeader.Text = "Registro y control de insumos básicos";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.ForeColor = Color.FromArgb(50, 50, 50);
            lblId.Location = new Point(26, 143);
            lblId.Name = "lblId";
            lblId.Size = new Size(113, 23);
            lblId.TabIndex = 2;
            lblId.Text = "ID Inventario:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.WhiteSmoke;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(195, 143);
            txtId.Margin = new Padding(3, 5, 3, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(325, 30);
            txtId.TabIndex = 3;
            txtId.Text = "0000";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = Color.FromArgb(50, 50, 50);
            lblName.Location = new Point(26, 213);
            lblName.Name = "lblName";
            lblName.Size = new Size(77, 23);
            lblName.TabIndex = 4;
            lblName.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(195, 213);
            txtName.Margin = new Padding(3, 5, 3, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(325, 30);
            txtName.TabIndex = 5;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F);
            lblStock.ForeColor = Color.FromArgb(50, 50, 50);
            lblStock.Location = new Point(26, 489);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(189, 23);
            lblStock.TabIndex = 11;
            lblStock.Text = "Cantidad en Inventario:";
            // 
            // numStock
            // 
            numStock.DecimalPlaces = 1;
            numStock.Location = new Point(287, 489);
            numStock.Margin = new Padding(3, 5, 3, 5);
            numStock.Name = "numStock";
            numStock.Size = new Size(104, 27);
            numStock.TabIndex = 12;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(405, 489);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(47, 20);
            lblUnit.TabIndex = 13;
            lblUnit.Text = "kg / u";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(26, 551);
            progressBar.Margin = new Padding(3, 5, 3, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(496, 27);
            progressBar.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(76, 175, 80);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(26, 613);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 15;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(33, 150, 243);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(162, 613);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 40);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(298, 613);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(158, 158, 158);
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(434, 613);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(130, 40);
            btnExport.TabIndex = 18;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += BtnExport_Click;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.White;
            rightPanel.Controls.Add(lblHeaderGrid);
            rightPanel.Controls.Add(gridInventory);
            rightPanel.Location = new Point(614, 53);
            rightPanel.Margin = new Padding(3, 5, 3, 5);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(522, 853);
            rightPanel.TabIndex = 1;
            // 
            // lblHeaderGrid
            // 
            lblHeaderGrid.AutoSize = true;
            lblHeaderGrid.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHeaderGrid.ForeColor = Color.FromArgb(50, 50, 50);
            lblHeaderGrid.Location = new Point(26, 36);
            lblHeaderGrid.Name = "lblHeaderGrid";
            lblHeaderGrid.Size = new Size(247, 28);
            lblHeaderGrid.TabIndex = 0;
            lblHeaderGrid.Text = "Ingredientes Registrados";
            // 
            // gridInventory
            // 
            gridInventory.AllowUserToAddRows = false;
            gridInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridInventory.BackgroundColor = Color.White;
            gridInventory.BorderStyle = BorderStyle.None;
            gridInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridInventory.ColumnHeadersHeight = 29;
            gridInventory.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colStock });
            gridInventory.EnableHeadersVisualStyles = false;
            gridInventory.Location = new Point(26, 107);
            gridInventory.Margin = new Padding(3, 5, 3, 5);
            gridInventory.Name = "gridInventory";
            gridInventory.ReadOnly = true;
            gridInventory.RowHeadersVisible = false;
            gridInventory.RowHeadersWidth = 51;
            gridInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridInventory.Size = new Size(470, 711);
            gridInventory.TabIndex = 1;
            gridInventory.CellClick += GridInventory_CellClick;
            // 
            // colId
            // 
            colId.FillWeight = 25F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 50F;
            colName.HeaderText = "Nombre";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.FillWeight = 20F;
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // statsPanel
            // 
            statsPanel.BackColor = Color.White;
            statsPanel.Controls.Add(lblTotalItems);
            statsPanel.Controls.Add(lblLowStock);
            statsPanel.Controls.Add(lblLastUpdate);
            statsPanel.Location = new Point(39, 924);
            statsPanel.Margin = new Padding(3, 5, 3, 5);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(1097, 107);
            statsPanel.TabIndex = 2;
            // 
            // lblTotalItems
            // 
            lblTotalItems.AutoSize = true;
            lblTotalItems.Font = new Font("Segoe UI", 9F);
            lblTotalItems.ForeColor = Color.FromArgb(50, 50, 50);
            lblTotalItems.Location = new Point(26, 36);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(143, 20);
            lblTotalItems.TabIndex = 0;
            lblTotalItems.Text = "Total Ingredientes: 0";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 9F);
            lblLowStock.ForeColor = Color.FromArgb(255, 193, 7);
            lblLowStock.Location = new Point(313, 36);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(211, 20);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "⚠ Bajo Stock (<10%): 0 items";
            // 
            // lblLastUpdate
            // 
            lblLastUpdate.AutoSize = true;
            lblLastUpdate.Font = new Font("Segoe UI", 9F);
            lblLastUpdate.ForeColor = Color.Gray;
            lblLastUpdate.Location = new Point(719, 36);
            lblLastUpdate.Name = "lblLastUpdate";
            lblLastUpdate.Size = new Size(196, 20);
            lblLastUpdate.TabIndex = 2;
            lblLastUpdate.Text = "🕒 Último Actualizado: Hoy";
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 1055);
            Controls.Add(mainCard);
            Controls.Add(rightPanel);
            Controls.Add(statsPanel);
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Inventario";
            mainCard.ResumeLayout(false);
            mainCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridInventory).EndInit();
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colStock;
    }
}
