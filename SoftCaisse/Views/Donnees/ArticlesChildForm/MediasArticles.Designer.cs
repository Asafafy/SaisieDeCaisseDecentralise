using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    partial class MediasArticles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediasArticles));
            dataGridView1 = new DataGridView();
            Fichier = new DataGridViewTextBoxColumn();
            Intitule = new DataGridViewTextBoxColumn();
            groupBoxDocumentsAttaches = new GroupBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnOuvrir = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxDocumentsAttaches.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fichier, Intitule });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(60, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(472, 324);
            dataGridView1.TabIndex = 21;
            // 
            // Fichier
            // 
            Fichier.HeaderText = "Fichier";
            Fichier.Name = "Fichier";
            // 
            // Intitule
            // 
            Intitule.HeaderText = "Intitulé";
            Intitule.Name = "Intitule";
            // 
            // groupBoxDocumentsAttaches
            // 
            groupBoxDocumentsAttaches.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDocumentsAttaches.Controls.Add(dataGridView1);
            groupBoxDocumentsAttaches.Location = new Point(22, 53);
            groupBoxDocumentsAttaches.Name = "groupBoxDocumentsAttaches";
            groupBoxDocumentsAttaches.Padding = new Padding(60, 15, 60, 15);
            groupBoxDocumentsAttaches.Size = new Size(592, 370);
            groupBoxDocumentsAttaches.TabIndex = 22;
            groupBoxDocumentsAttaches.TabStop = false;
            groupBoxDocumentsAttaches.Text = "Documents attachés";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(82, 527);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(60, 10, 60, 10);
            groupBox1.Size = new Size(490, 276);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Photo de l'article";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 240);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnOuvrir
            // 
            btnOuvrir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOuvrir.BackColor = Color.FromArgb(129, 166, 181);
            btnOuvrir.Cursor = Cursors.Hand;
            btnOuvrir.FlatAppearance.BorderSize = 0;
            btnOuvrir.FlatStyle = FlatStyle.Flat;
            btnOuvrir.Font = new Font("Segoe UI", 11F);
            btnOuvrir.ForeColor = Color.White;
            btnOuvrir.Location = new Point(424, 434);
            btnOuvrir.Margin = new Padding(144, 3, 144, 3);
            btnOuvrir.Name = "btnOuvrir";
            btnOuvrir.Padding = new Padding(8, 0, 0, 0);
            btnOuvrir.Size = new Size(190, 45);
            btnOuvrir.TabIndex = 25;
            btnOuvrir.Text = "Ouvrir";
            btnOuvrir.UseVisualStyleBackColor = false;
            // 
            // iconButtonFermer
            // 
            iconButtonFermer.BackColor = Color.FromArgb(84, 138, 178);
            iconButtonFermer.Cursor = Cursors.Hand;
            iconButtonFermer.FlatAppearance.BorderColor = Color.FromArgb(29, 64, 102);
            iconButtonFermer.FlatAppearance.BorderSize = 0;
            iconButtonFermer.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButtonFermer.IconColor = Color.White;
            iconButtonFermer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonFermer.IconSize = 33;
            iconButtonFermer.Location = new Point(628, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 44;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // MediasArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(680, 827);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnOuvrir);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxDocumentsAttaches);
            Name = "MediasArticles";
            ShowIcon = false;
            ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxDocumentsAttaches.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fichier;
        private DataGridViewTextBoxColumn Intitule;
        private GroupBox groupBoxDocumentsAttaches;
        private GroupBox groupBox1;
        private Button btnOuvrir;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}