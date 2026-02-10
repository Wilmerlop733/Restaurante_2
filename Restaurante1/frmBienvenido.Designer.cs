
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
            lblWelcome.Location = new Point(171, 267);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(649, 54);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bienvenido al Sistema de Gestión";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 14F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(229, 347);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(600, 32);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Seleccione una opción del menú lateral para comenzar";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;


            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 800);
            Controls.Add(lblSubtitle);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WelcomeForm";
            Text = "Bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
    }
}
