using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Soft_Caisse.Views.FonctionsViews
{
    public static class BorderRadius
    {
        public static void ApplyBorderRaduisOnButton(Button button, int borderRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(button.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(button.Width - borderRadius, button.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, button.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            button.Region = new Region(path);
        }


        public static void ApplyBorderRaduisOnPanel(Panel panel, int borderRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }
    }
}
