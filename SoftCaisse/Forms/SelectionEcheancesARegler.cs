using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class SelectionEcheancesARegler : KryptonForm
    {
        public SelectionEcheancesARegler()
        {
            InitializeComponent();
            ApplyRoundedCorners(tableLayoutPanel3, 30);
            ApplyRoundedCorners(panel2, 30);
            ApplyRoundedCorners(panel1, 30);
        }



        // =============================== DESIGN ===============================
        private void ApplyRoundedCorners(Control control, int borderRadius)
        {
            control.Paint += (sender, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                    path.AddArc(new Rectangle(control.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                    path.AddArc(new Rectangle(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                    path.AddArc(new Rectangle(0, control.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                    path.CloseAllFigures();

                    control.Region = new Region(path);
                }
            };

            control.Invalidate();
        }

        private void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
