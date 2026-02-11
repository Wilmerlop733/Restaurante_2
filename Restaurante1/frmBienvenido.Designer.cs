
namespace Restaurante1
{
    partial class frmBienvenido
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
            lblWelcome = new Label();
            lblSubtitle = new Label();
            SuspendLayout();
 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(40, 50, 60);
            lblWelcome.Location = new Point(245, 341);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(649, 54);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bienvenido al Sistema de Gestión";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 14F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(266, 402);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(600, 32);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Seleccione una opción del menú lateral para comenzar";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 1067);
            Controls.Add(lblSubtitle);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmBienvenido";
            Text = "Bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
    }
}
