
namespace Restaurante1
{
    partial class frmPlatos
    {
        private System.ComponentModel.IContainer components = null;


        private System.Windows.Forms.Label lblPageHeader;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label lblBasicInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblAddInfo;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.NumericUpDown numDiff;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadSuggested;

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
            lblPageHeader = new Label();
            leftPanel = new Panel();
            lblBasicInfo = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblName = new Label();
            txtName = new TextBox();
            lblDesc = new Label();
            txtDesc = new TextBox();
            rightPanel = new Panel();
            lblAddInfo = new Label();
            lblDiff = new Label();
            numDiff = new NumericUpDown();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            btnUpload = new Button();
            btnLoadSuggested = new Button();
            lblPreview = new Label();
            picPreview = new PictureBox();
            btnSave = new Button();
            btnClear = new Button();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // lblPageHeader
            // 
            lblPageHeader.AutoSize = true;
            lblPageHeader.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageHeader.ForeColor = Color.FromArgb(50, 50, 50);
            lblPageHeader.Location = new Point(39, 57);
            lblPageHeader.Name = "lblPageHeader";
            lblPageHeader.Size = new Size(253, 38);
            lblPageHeader.TabIndex = 0;
            lblPageHeader.Text = "Registro de Platos";
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(lblBasicInfo);
            leftPanel.Controls.Add(lblId);
            leftPanel.Controls.Add(txtId);
            leftPanel.Controls.Add(lblCategory);
            leftPanel.Controls.Add(cmbCategory);
            leftPanel.Controls.Add(lblName);
            leftPanel.Controls.Add(txtName);
            leftPanel.Controls.Add(lblDesc);
            leftPanel.Controls.Add(txtDesc);
            leftPanel.Location = new Point(39, 124);
            leftPanel.Margin = new Padding(3, 5, 3, 5);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(522, 600);
            leftPanel.TabIndex = 1;
            // 
            // lblBasicInfo
            // 
            lblBasicInfo.AutoSize = true;
            lblBasicInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBasicInfo.ForeColor = Color.FromArgb(50, 50, 50);
            lblBasicInfo.Location = new Point(26, 36);
            lblBasicInfo.Name = "lblBasicInfo";
            lblBasicInfo.Size = new Size(193, 28);
            lblBasicInfo.TabIndex = 0;
            lblBasicInfo.Text = "Información Básica";
            // 
            // lblId
            // 
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.ForeColor = Color.FromArgb(50, 50, 50);
            lblId.Location = new Point(26, 107);
            lblId.Name = "lblId";
            lblId.Size = new Size(130, 41);
            lblId.TabIndex = 1;
            lblId.Text = "ID Plato:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.WhiteSmoke;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(195, 107);
            txtId.Margin = new Padding(3, 5, 3, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(300, 30);
            txtId.TabIndex = 2;
            txtId.Text = "0000";
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.ForeColor = Color.FromArgb(50, 50, 50);
            lblCategory.Location = new Point(26, 177);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(130, 41);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Categoría:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(195, 177);
            cmbCategory.Margin = new Padding(3, 5, 3, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(299, 28);
            cmbCategory.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = Color.FromArgb(50, 50, 50);
            lblName.Location = new Point(26, 320);
            lblName.Name = "lblName";
            lblName.Size = new Size(130, 41);
            lblName.TabIndex = 5;
            lblName.Text = "Nombre del Plato:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(195, 320);
            txtName.Margin = new Padding(3, 5, 3, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 30);
            txtName.TabIndex = 6;
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 10F);
            lblDesc.ForeColor = Color.FromArgb(50, 50, 50);
            lblDesc.Location = new Point(26, 391);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(130, 41);
            lblDesc.TabIndex = 7;
            lblDesc.Text = "Descripción:";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.WhiteSmoke;
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Segoe UI", 10F);
            txtDesc.Location = new Point(195, 391);
            txtDesc.Margin = new Padding(3, 5, 3, 5);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(300, 133);
            txtDesc.TabIndex = 8;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.White;
            rightPanel.Controls.Add(lblAddInfo);
            rightPanel.Controls.Add(lblDiff);
            rightPanel.Controls.Add(numDiff);
            rightPanel.Controls.Add(lblPrice);
            rightPanel.Controls.Add(numPrice);
            rightPanel.Controls.Add(btnUpload);
            rightPanel.Controls.Add(btnLoadSuggested);
            rightPanel.Controls.Add(lblPreview);
            rightPanel.Controls.Add(picPreview);
            rightPanel.Location = new Point(601, 124);
            rightPanel.Margin = new Padding(3, 5, 3, 5);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(536, 600);
            rightPanel.TabIndex = 2;
            // 
            // lblAddInfo
            // 
            lblAddInfo.AutoSize = true;
            lblAddInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAddInfo.ForeColor = Color.Gray;
            lblAddInfo.Location = new Point(26, 36);
            lblAddInfo.Name = "lblAddInfo";
            lblAddInfo.Size = new Size(181, 28);
            lblAddInfo.TabIndex = 0;
            lblAddInfo.Text = "Adicional detalles";
            // 
            // lblDiff
            // 
            lblDiff.AutoSize = true;
            lblDiff.Location = new Point(26, 107);
            lblDiff.Name = "lblDiff";
            lblDiff.Size = new Size(172, 20);
            lblDiff.TabIndex = 1;
            lblDiff.Text = "Nivel de Dificultad (1-5):";
            // 
            // numDiff
            // 
            numDiff.Location = new Point(235, 107);
            numDiff.Margin = new Padding(3, 5, 3, 5);
            numDiff.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numDiff.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDiff.Name = "numDiff";
            numDiff.Size = new Size(65, 27);
            numDiff.TabIndex = 2;
            numDiff.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(26, 177);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(75, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Precio ($):";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(235, 177);
            numPrice.Margin = new Padding(3, 5, 3, 5);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(130, 27);
            numPrice.TabIndex = 4;
            numPrice.Value = new decimal(new int[] { 899, 0, 0, 131072 });
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(158, 158, 158);
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(26, 249);
            btnUpload.Margin = new Padding(3, 4, 3, 4);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(149, 53);
            btnUpload.TabIndex = 5;
            btnUpload.Text = "Subir Foto";
            btnUpload.UseVisualStyleBackColor = false;
            // 
            // btnLoadSuggested
            // 
            btnLoadSuggested.BackColor = Color.FromArgb(33, 150, 243);
            btnLoadSuggested.Cursor = Cursors.Hand;
            btnLoadSuggested.FlatAppearance.BorderSize = 0;
            btnLoadSuggested.FlatStyle = FlatStyle.Flat;
            btnLoadSuggested.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoadSuggested.ForeColor = Color.White;
            btnLoadSuggested.Location = new Point(183, 249);
            btnLoadSuggested.Margin = new Padding(3, 4, 3, 4);
            btnLoadSuggested.Name = "btnLoadSuggested";
            btnLoadSuggested.Size = new Size(149, 53);
            btnLoadSuggested.TabIndex = 6;
            btnLoadSuggested.Text = "Cargar Sugerencia";
            btnLoadSuggested.UseVisualStyleBackColor = false;
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPreview.ForeColor = Color.FromArgb(50, 50, 50);
            lblPreview.Location = new Point(26, 320);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(124, 28);
            lblPreview.TabIndex = 6;
            lblPreview.Text = "Vista Previa";
            // 
            // picPreview
            // 
            picPreview.BackColor = Color.WhiteSmoke;
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.Location = new Point(26, 367);
            picPreview.Margin = new Padding(3, 5, 3, 5);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(343, 213);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 7;
            picPreview.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(76, 175, 80);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(39, 747);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 53);
            btnSave.TabIndex = 3;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 193, 7);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(205, 747);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 53);
            btnClear.TabIndex = 4;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // frmPlatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 867);
            Controls.Add(lblPageHeader);
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmPlatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Platos";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiff).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
