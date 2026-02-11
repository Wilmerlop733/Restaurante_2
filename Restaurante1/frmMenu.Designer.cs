
namespace Restaurante1
{
    partial class frmMenu
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
            pnlSidebar = new Panel();
            lblAppName = new Label();
            btnNavHome = new Button();
            btnNavInventory = new Button();
            btnNavCategories = new Button();
            btnNavDishes = new Button();
            btnNavRecipes = new Button();
            pnlContent = new Panel();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblUser = new Label();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            pnlSidebar.BackColor = Color.FromArgb(40, 50, 60);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Controls.Add(btnNavHome);
            pnlSidebar.Controls.Add(btnNavInventory);
            pnlSidebar.Controls.Add(btnNavCategories);
            pnlSidebar.Controls.Add(btnNavDishes);
            pnlSidebar.Controls.Add(btnNavRecipes);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(320, 960);
            pnlSidebar.TabIndex = 2;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(23, 40);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(276, 37);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "🍽 Restaurante App";
            btnNavHome.ForeColor = SystemColors.ControlLightLight;
            btnNavHome.Location = new Point(0, 133);
            btnNavHome.Margin = new Padding(3, 4, 3, 4);
            btnNavHome.Name = "btnNavHome";
            btnNavHome.Padding = new Padding(23, 0, 0, 0);
            btnNavHome.Size = new Size(320, 67);
            btnNavHome.TabIndex = 1;
            btnNavHome.Text = "🏠 Inicio";
            btnNavHome.TextAlign = ContentAlignment.MiddleLeft;
            btnNavHome.Click += btnNavHome_Click;
            btnNavInventory.ForeColor = SystemColors.ControlLightLight;
            btnNavInventory.Location = new Point(0, 200);
            btnNavInventory.Margin = new Padding(3, 4, 3, 4);
            btnNavInventory.Name = "btnNavInventory";
            btnNavInventory.Padding = new Padding(23, 0, 0, 0);
            btnNavInventory.Size = new Size(320, 67);
            btnNavInventory.TabIndex = 2;
            btnNavInventory.Text = "📦 Inventario";
            btnNavInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnNavInventory.Click += btnNavInventory_Click;
            btnNavCategories.ForeColor = SystemColors.ControlLightLight;
            btnNavCategories.Location = new Point(0, 267);
            btnNavCategories.Margin = new Padding(3, 4, 3, 4);
            btnNavCategories.Name = "btnNavCategories";
            btnNavCategories.Padding = new Padding(23, 0, 0, 0);
            btnNavCategories.Size = new Size(320, 67);
            btnNavCategories.TabIndex = 3;
            btnNavCategories.Text = "📂 Categorías";
            btnNavCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnNavCategories.Click += btnNavCategories_Click;
            btnNavDishes.ForeColor = SystemColors.ControlLightLight;
            btnNavDishes.Location = new Point(0, 333);
            btnNavDishes.Margin = new Padding(3, 4, 3, 4);
            btnNavDishes.Name = "btnNavDishes";
            btnNavDishes.Padding = new Padding(23, 0, 0, 0);
            btnNavDishes.Size = new Size(320, 67);
            btnNavDishes.TabIndex = 4;
            btnNavDishes.Text = "🍲 Platos";
            btnNavDishes.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDishes.Click += btnNavDishes_Click;

            // Recipe Button
            btnNavRecipes.ForeColor = SystemColors.ControlLightLight;
            btnNavRecipes.Location = new Point(0, 400);
            btnNavRecipes.Margin = new Padding(3, 4, 3, 4);
            btnNavRecipes.Name = "btnNavRecipes";
            btnNavRecipes.Padding = new Padding(23, 0, 0, 0);
            btnNavRecipes.Size = new Size(320, 67);
            btnNavRecipes.TabIndex = 5;
            btnNavRecipes.Text = "📝 Recetas";
            btnNavRecipes.TextAlign = ContentAlignment.MiddleLeft;
            btnNavRecipes.Click += btnNavRecipes_Click;
            pnlContent.BackColor = Color.FromArgb(245, 247, 251);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(320, 80);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(23, 27, 23, 27);
            pnlContent.Size = new Size(1143, 880);
            pnlContent.TabIndex = 0;
            pnlContent.Paint += pnlContent_Paint;
            pnlHeader.BackColor = Color.FromArgb(33, 150, 243);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblUser);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(320, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1143, 80);
            pnlHeader.TabIndex = 1;
            pnlHeader.Paint += this.pnlHeader_Paint;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(179, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema de Gestión";
            lblUser.Dock = DockStyle.Right;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(1029, 0);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(0, 27, 23, 0);
            lblUser.Size = new Size(114, 80);
            lblUser.TabIndex = 1;
            lblUser.Text = "👤 Admin";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1463, 960);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Restaurante";
            Load += Form1_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Button btnNavInventory;
        private System.Windows.Forms.Button btnNavCategories;
        private System.Windows.Forms.Button btnNavDishes;
        private System.Windows.Forms.Button btnNavRecipes;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
    }
}
