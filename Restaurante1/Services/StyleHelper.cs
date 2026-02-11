using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurante1.Services
{
    public static class StyleHelper
    {
        public static readonly Color PrimaryColor = Color.FromArgb(33, 150, 243);
        public static readonly Color SecondaryColor = Color.FromArgb(76, 175, 80);
        public static readonly Color TextColor = Color.FromArgb(50, 50, 50);
        public static readonly Color BackgroundColor = Color.FromArgb(245, 247, 251);
        public static readonly Color CardBackgroundColor = Color.White;
        public static readonly Color WarningColor = Color.FromArgb(255, 193, 7);
        public static readonly Color DangerColor = Color.FromArgb(244, 67, 54);

        public static readonly Font HeaderFont = new Font("Segoe UI", 18, FontStyle.Bold);
        public static readonly Font SubHeaderFont = new Font("Segoe UI", 12, FontStyle.Bold);
        public static readonly Font TitleFont = new Font("Segoe UI", 14, FontStyle.Bold);
        public static readonly Font RegularFont = new Font("Segoe UI", 10, FontStyle.Regular);
        public static readonly Font SmallFont = new Font("Segoe UI", 9, FontStyle.Regular);
        public static readonly Font LabelFont = new Font("Segoe UI", 10, FontStyle.Regular);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10, FontStyle.Bold);

        public static void StyleButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(130, 40);
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = RegularFont;
            txt.BackColor = Color.WhiteSmoke;
        }

        public static void StyleLabel(Label lbl, Font font, Color color)
        {
            lbl.Font = font;
            lbl.ForeColor = color;
        }

        public static void ApplyStandardFonts(Form form)
        {
            // Apply standard fonts to all controls recursively
            foreach (Control control in form.Controls)
            {
                ApplyFontsToControl(control);
            }
        }

        private static void ApplyFontsToControl(Control control)
        {
            if (control is Label lbl)
            {
                // Title labels (in headers)
                if (lbl.Parent is Panel panel && panel.Dock == DockStyle.Top)
                {
                    lbl.Font = HeaderFont;
                }
                // Regular labels
                else if (lbl.Font.Size < 12)
                {
                    lbl.Font = LabelFont;
                }
            }
            else if (control is Button btn)
            {
                btn.Font = ButtonFont;
            }
            else if (control is TextBox txt)
            {
                txt.Font = RegularFont;
            }
            else if (control is ComboBox cmb)
            {
                cmb.Font = RegularFont;
            }
            else if (control is NumericUpDown num)
            {
                num.Font = RegularFont;
            }
            else if (control is DataGridView grid)
            {
                grid.Font = RegularFont;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }

            // Recursively apply to child controls
            foreach (Control child in control.Controls)
            {
                ApplyFontsToControl(child);
            }
        }
    }
}
