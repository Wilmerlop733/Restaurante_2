
namespace Restaurante1
{
    partial class frmCategoria
    {
        private System.ComponentModel.IContainer components = null;


        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label lblHeaderLeft;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.ComboBox cmbManager;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHeaderRight;
        private System.Windows.Forms.DataGridView gridCategories;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            leftPanel = new Panel();
            lblHeaderLeft = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblDesc = new Label();
            txtDesc = new TextBox();
            lblManager = new Label();
            cmbManager = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            rightPanel = new Panel();
            lblHeaderRight = new Label();
            gridCategories = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colMan = new DataGridViewTextBoxColumn();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategories).BeginInit();
            SuspendLayout();
         
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(lblHeaderLeft);
            leftPanel.Controls.Add(lblId);
            leftPanel.Controls.Add(txtId);
            leftPanel.Controls.Add(lblName);
            leftPanel.Controls.Add(txtName);
            leftPanel.Controls.Add(lblDesc);
            leftPanel.Controls.Add(txtDesc);
            leftPanel.Controls.Add(lblManager);
            leftPanel.Controls.Add(cmbManager);
            leftPanel.Controls.Add(btnSave);
            leftPanel.Controls.Add(btnDelete);
            leftPanel.Location = new Point(34, 40);
            leftPanel.Margin = new Padding(3, 4, 3, 4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(457, 667);
            leftPanel.TabIndex = 0;
           
            lblHeaderLeft.AutoSize = true;
            lblHeaderLeft.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderLeft.ForeColor = Color.FromArgb(50, 50, 50);
            lblHeaderLeft.Location = new Point(171, 24);
            lblHeaderLeft.Name = "lblHeaderLeft";
            lblHeaderLeft.Size = new Size(123, 31);
            lblHeaderLeft.TabIndex = 0;
            lblHeaderLeft.Text = "Categoría ";
           
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.ForeColor = Color.FromArgb(50, 50, 50);
            lblId.Location = new Point(23, 80);
            lblId.Name = "lblId";
            lblId.Size = new Size(114, 31);
            lblId.TabIndex = 1;
            lblId.Text = "ID Categoría:";
           
            txtId.BackColor = Color.WhiteSmoke;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(171, 80);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(263, 30);
            txtId.TabIndex = 2;
            txtId.Text = "0000";
            
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = Color.FromArgb(50, 50, 50);
            lblName.Location = new Point(23, 133);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 31);
            lblName.TabIndex = 3;
            lblName.Text = "Nombre:";
            
            txtName.BackColor = Color.WhiteSmoke;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(171, 133);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(263, 30);
            txtName.TabIndex = 4;
             
            lblDesc.Font = new Font("Segoe UI", 10F);
            lblDesc.ForeColor = Color.FromArgb(50, 50, 50);
            lblDesc.Location = new Point(23, 187);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(114, 31);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "Descripción:";
             
            txtDesc.BackColor = Color.WhiteSmoke;
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Segoe UI", 10F);
            txtDesc.Location = new Point(171, 187);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(263, 133);
            txtDesc.TabIndex = 6;
            
            lblManager.Font = new Font("Segoe UI", 10F);
            lblManager.ForeColor = Color.FromArgb(50, 50, 50);
            lblManager.Location = new Point(23, 347);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(114, 31);
            lblManager.TabIndex = 7;
            lblManager.Text = "Encargado:";
            
            cmbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbManager.Items.AddRange(new object[] { "María González", "Ana López", "Carlos Ruiz" });
            cmbManager.Location = new Point(171, 347);
            cmbManager.Margin = new Padding(3, 4, 3, 4);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(262, 28);
            cmbManager.TabIndex = 8;
           
            btnSave.BackColor = Color.FromArgb(76, 175, 80);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(23, 427);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 53);
            btnSave.TabIndex = 9;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(183, 427);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 53);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
             
            rightPanel.BackColor = Color.White;
            rightPanel.Controls.Add(lblHeaderRight);
            rightPanel.Controls.Add(gridCategories);
            rightPanel.Location = new Point(526, 40);
            rightPanel.Margin = new Padding(3, 4, 3, 4);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(513, 667);
            rightPanel.TabIndex = 1;
          
            lblHeaderRight.AutoSize = true;
            lblHeaderRight.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHeaderRight.ForeColor = Color.FromArgb(50, 50, 50);
            lblHeaderRight.Location = new Point(23, 27);
            lblHeaderRight.Name = "lblHeaderRight";
            lblHeaderRight.Size = new Size(228, 28);
            lblHeaderRight.TabIndex = 0;
            lblHeaderRight.Text = "Categorías Registradas";
           
            gridCategories.AllowUserToAddRows = false;
            gridCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCategories.BackgroundColor = Color.White;
            gridCategories.BorderStyle = BorderStyle.None;
            gridCategories.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridCategories.ColumnHeadersHeight = 40;
            gridCategories.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colDesc, colMan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridCategories.DefaultCellStyle = dataGridViewCellStyle2;
            gridCategories.EnableHeadersVisualStyles = false;
            gridCategories.Location = new Point(23, 80);
            gridCategories.Margin = new Padding(3, 4, 3, 4);
            gridCategories.Name = "gridCategories";
            gridCategories.ReadOnly = true;
            gridCategories.RowHeadersVisible = false;
            gridCategories.RowHeadersWidth = 51;
            gridCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCategories.Size = new Size(467, 560);
            gridCategories.TabIndex = 1;
           
            colId.FillWeight = 15F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
         
            colName.FillWeight = 25F;
            colName.HeaderText = "Nombre";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
        
            colDesc.FillWeight = 40F;
            colDesc.HeaderText = "Descripción";
            colDesc.MinimumWidth = 6;
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            
            colMan.FillWeight = 25F;
            colMan.HeaderText = "Encargado";
            colMan.MinimumWidth = 6;
            colMan.Name = "colMan";
            colMan.ReadOnly = true;
             
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 800);
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Categorías";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategories).EndInit();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colMan;
    }
}
