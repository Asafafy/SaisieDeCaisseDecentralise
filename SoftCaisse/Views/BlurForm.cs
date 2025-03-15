using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Effects;

namespace Soft_Caisse.Forms
{
    public partial class BlurForm : Form
    {
        public BlurForm(Form home)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            BackColor = Color.White;
            Opacity = 0.90;
            ShowInTaskbar = false;
            Size = home.Size;
            Location = home.Location;
            Owner = home;
        }
    }
}

