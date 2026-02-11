using System;
using System.Drawing;
using System.Windows.Forms;
using Restaurante1.Services;

namespace Restaurante1
{
    public partial class frmBienvenido : Form
    {
        public frmBienvenido()
        {
            InitializeComponent();
            this.BackColor = StyleHelper.BackgroundColor;
            this.Resize += FrmBienvenido_Resize;
            CenterCard();
        }

        private void FrmBienvenido_Resize(object sender, EventArgs e)
        {
            CenterCard();
        }

        private void CenterCard()
        {
            if (pnlCentralCard != null)
            {
                pnlCentralCard.Left = (this.ClientSize.Width - pnlCentralCard.Width) / 2;
                pnlCentralCard.Top = (this.ClientSize.Height - pnlCentralCard.Height) / 2;
            }
        }

        private void frmBienvenido_Load(object sender, EventArgs e)
        {

        }
    }
}
