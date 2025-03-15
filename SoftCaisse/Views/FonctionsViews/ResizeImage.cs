using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.FonctionsViews
{
    internal class ResizeImage
    {
        public static void ResizeImagePictureBox(PictureBox pictureBox, int newWidth, int newHeight)
        {
            if (pictureBox.Image == null) return;

            // Redimensionner l'image
            Bitmap resizedImage = new Bitmap(pictureBox.Image, newWidth, newHeight);
            pictureBox.Image = resizedImage;
        }
    }
}
