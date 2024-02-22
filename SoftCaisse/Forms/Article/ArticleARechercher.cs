using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace SoftCaisse.Forms.Article
{
    public partial class ArticleARechercher : KryptonForm 
    {
        public ArticleARechercher()
        {
            InitializeComponent();
        }

        private void labelParametreFiltre_Click(object sender, EventArgs e)
        { 
            groupBoxFiltre.Visible = !groupBoxFiltre.Visible;
            if(groupBoxFiltre.Visible == true)
            {
                labelParametreFiltre.BackColor = Color.LightSkyBlue;
                dataGridViewArticle.Dock = DockStyle.Bottom;
                dataGridViewArticle.Width = 740;
                dataGridViewArticle.Height = 317;
            }
            else
            {
                labelParametreFiltre.BackColor = Color.Transparent;
                dataGridViewArticle.Dock = DockStyle.Fill;
            }


        }

        private void ButtonCloseArticle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        /*  private void labelTous_Click(object sender, EventArgs e)
          {
              dataGridViewArticle.Dock = DockStyle.Bottom;
              dataGridViewArticle.Width = 740;
              dataGridViewArticle.Height = 317;


          }*/
    }
}
