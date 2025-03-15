using System.Drawing;
using System.Windows.Forms;












namespace Soft_Caisse.Views.Operations
{
    partial class DocumentsDesVentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentsDesVentes));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            listBoxFiltre = new ListBox();
            buttonOuvrir = new Button();
            buttonNouveau = new Button();
            buttonSupprimer = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            txtBxBarreDeRecherche = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Etat = new DataGridViewTextBoxColumn();
            NPiece = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            NClient = new DataGridViewTextBoxColumn();
            IntituleClient = new DataGridViewTextBoxColumn();
            Souche = new DataGridViewTextBoxColumn();
            HorsTaxe = new DataGridViewTextBoxColumn();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBoxFiltre
            // 
            listBoxFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxFiltre.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxFiltre.FormattingEnabled = true;
            listBoxFiltre.ItemHeight = 35;
            listBoxFiltre.Location = new Point(11, 104);
            listBoxFiltre.Name = "listBoxFiltre";
            listBoxFiltre.Size = new Size(241, 529);
            listBoxFiltre.TabIndex = 27;
            listBoxFiltre.DrawItem += listBoxFiltre_DrawItem;
            // 
            // buttonOuvrir
            // 
            buttonOuvrir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOuvrir.BackColor = Color.FromArgb(129, 166, 181);
            buttonOuvrir.Cursor = Cursors.Hand;
            buttonOuvrir.FlatAppearance.BorderSize = 0;
            buttonOuvrir.FlatStyle = FlatStyle.Flat;
            buttonOuvrir.Font = new Font("Segoe UI", 11F);
            buttonOuvrir.ForeColor = Color.White;
            buttonOuvrir.Location = new Point(662, 683);
            buttonOuvrir.Margin = new Padding(144, 3, 144, 3);
            buttonOuvrir.Name = "buttonOuvrir";
            buttonOuvrir.Padding = new Padding(8, 0, 0, 0);
            buttonOuvrir.Size = new Size(190, 45);
            buttonOuvrir.TabIndex = 28;
            buttonOuvrir.Text = "Ouvrir";
            buttonOuvrir.UseVisualStyleBackColor = false;
            buttonOuvrir.Click += buttonOuvrir_Click;
            // 
            // buttonNouveau
            // 
            buttonNouveau.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNouveau.BackColor = Color.FromArgb(129, 166, 181);
            buttonNouveau.Cursor = Cursors.Hand;
            buttonNouveau.FlatAppearance.BorderSize = 0;
            buttonNouveau.FlatStyle = FlatStyle.Flat;
            buttonNouveau.Font = new Font("Segoe UI", 11F);
            buttonNouveau.ForeColor = Color.White;
            buttonNouveau.Location = new Point(863, 683);
            buttonNouveau.Margin = new Padding(144, 3, 144, 3);
            buttonNouveau.Name = "buttonNouveau";
            buttonNouveau.Padding = new Padding(8, 0, 0, 0);
            buttonNouveau.Size = new Size(190, 45);
            buttonNouveau.TabIndex = 29;
            buttonNouveau.Text = "Nouveau";
            buttonNouveau.UseVisualStyleBackColor = false;
            buttonNouveau.Click += buttonNouveau_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSupprimer.BackColor = Color.FromArgb(129, 166, 181);
            buttonSupprimer.Cursor = Cursors.Hand;
            buttonSupprimer.FlatAppearance.BorderSize = 0;
            buttonSupprimer.FlatStyle = FlatStyle.Flat;
            buttonSupprimer.Font = new Font("Segoe UI", 11F);
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(1064, 683);
            buttonSupprimer.Margin = new Padding(144, 3, 144, 3);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Padding = new Padding(8, 0, 0, 0);
            buttonSupprimer.Size = new Size(190, 45);
            buttonSupprimer.TabIndex = 30;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(29, 64, 102);
            panel1.Location = new Point(11, 660);
            panel1.Name = "panel1";
            panel1.Size = new Size(1243, 5);
            panel1.TabIndex = 32;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 427F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(button3, 1, 1);
            tableLayoutPanel2.Location = new Point(782, 35);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(472, 60);
            tableLayoutPanel2.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxBarreDeRecherche);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 10);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 11, 20, 10);
            panel2.Size = new Size(427, 40);
            panel2.TabIndex = 26;
            // 
            // txtBxBarreDeRecherche
            // 
            txtBxBarreDeRecherche.BorderStyle = BorderStyle.None;
            txtBxBarreDeRecherche.Dock = DockStyle.Fill;
            txtBxBarreDeRecherche.Location = new Point(20, 11);
            txtBxBarreDeRecherche.Name = "txtBxBarreDeRecherche";
            //txtBxBarreDeRecherche.PlaceholderText = "Nom ou référence d'article";
            txtBxBarreDeRecherche.Size = new Size(385, 16);
            txtBxBarreDeRecherche.TabIndex = 0;
            txtBxBarreDeRecherche.TextChanged += txtBxBarreDeRecherche_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(29, 64, 102);
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderColor = Color.AliceBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(427, 10);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(45, 40);
            button3.TabIndex = 25;
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Type, Etat, NPiece, Reference, Date, NClient, IntituleClient, Souche, HorsTaxe });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(270, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(984, 529);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Etat
            // 
            Etat.HeaderText = "Etat";
            Etat.Name = "Etat";
            // 
            // NPiece
            // 
            NPiece.HeaderText = "N° Pièce";
            NPiece.Name = "NPiece";
            // 
            // Reference
            // 
            Reference.HeaderText = "Référence";
            Reference.Name = "Reference";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // NClient
            // 
            NClient.HeaderText = "N° Client";
            NClient.Name = "NClient";
            // 
            // IntituleClient
            // 
            IntituleClient.HeaderText = "Intitulé client";
            IntituleClient.Name = "IntituleClient";
            // 
            // Souche
            // 
            Souche.HeaderText = "Souche";
            Souche.Name = "Souche";
            // 
            // HorsTaxe
            // 
            HorsTaxe.HeaderText = "Hors taxe";
            HorsTaxe.Name = "HorsTaxe";
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
            iconButtonFermer.Location = new Point(1256, 4);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 68;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // DocumentsDesVentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1304, 740);
            Controls.Add(iconButtonFermer);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonNouveau);
            Controls.Add(buttonOuvrir);
            Controls.Add(listBoxFiltre);
            Name = "DocumentsDesVentes";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Documents des ventes";
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBoxFiltre;
        private Button buttonOuvrir;
        private Button buttonNouveau;
        private Button buttonSupprimer;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private TextBox txtBxBarreDeRecherche;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Etat;
        private DataGridViewTextBoxColumn NPiece;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn NClient;
        private DataGridViewTextBoxColumn IntituleClient;
        private DataGridViewTextBoxColumn Souche;
        private DataGridViewTextBoxColumn HorsTaxe;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}