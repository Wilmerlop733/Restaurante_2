
namespace Restaurante1
{
    partial class frmBienvenido
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlCentralCard;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblDescription;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenido));
            pnlCentralCard = new Panel();
            lblDescription = new Label();
            pnlDivider = new Panel();
            lblSystemName = new Label();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            pnlCentralCard.SuspendLayout();
            SuspendLayout();
           
            pnlCentralCard.BackColor = Color.White;
            pnlCentralCard.Controls.Add(lblDescription);
            pnlCentralCard.Controls.Add(pnlDivider);
            pnlCentralCard.Controls.Add(lblSystemName);
            pnlCentralCard.Controls.Add(lblSubtitle);
            pnlCentralCard.Controls.Add(lblWelcome);
            pnlCentralCard.Location = new Point(200, 200);
            pnlCentralCard.Name = "pnlCentralCard";
            pnlCentralCard.Padding = new Padding(40);
            pnlCentralCard.Size = new Size(776, 500);
            pnlCentralCard.TabIndex = 0;
          
            lblDescription.Font = new Font("Segoe UI", 11F);
            lblDescription.ForeColor = Color.FromArgb(100, 100, 100);
            lblDescription.Location = new Point(45, 260);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(686, 120);
            lblDescription.TabIndex = 4;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            
            pnlDivider.BackColor = Color.FromArgb(230, 230, 230);
            pnlDivider.Location = new Point(45, 175);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(686, 2);
            pnlDivider.TabIndex = 2;
           
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblSystemName.ForeColor = Color.FromArgb(50, 50, 50);
            lblSystemName.Location = new Point(40, 200);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(312, 41);
            lblSystemName.TabIndex = 3;
            lblSystemName.Text = "Restaurante Software";
           
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(45, 122);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(313, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sistema de Gestión de Restaurante";
           
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(33, 150, 243);
            lblWelcome.Location = new Point(40, 60);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(272, 62);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bienvenido";
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1176, 1067);
            Controls.Add(pnlCentralCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBienvenido";
            Text = "Bienvenida";
            Load += frmBienvenido_Load;
            pnlCentralCard.ResumeLayout(false);
            pnlCentralCard.PerformLayout();
            ResumeLayout(false);
        }
    }
}
