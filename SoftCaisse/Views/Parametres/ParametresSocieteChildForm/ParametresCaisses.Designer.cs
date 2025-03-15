using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres.ParametresSociete
{
    partial class ParametresCaisses
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            cmbBxFondDeCaisse = new ComboBox();
            panel4 = new Panel();
            cmbBxReglementParDefaut = new ComboBox();
            lblFondDeCaisse = new Label();
            lblReglementParDefaut = new Label();
            panel2 = new Panel();
            cmbBxClientParDefaut = new ComboBox();
            lblClientParDefaut = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel9 = new Panel();
            cmbBxReglement = new ComboBox();
            panel8 = new Panel();
            cmbBxTickets = new ComboBox();
            lblReglement = new Label();
            lblTickets = new Label();
            btnEnregistrer = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(15, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(60, 3, 60, 3);
            groupBox1.Size = new Size(554, 155);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vente comptoir";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel5, 1, 3);
            tableLayoutPanel1.Controls.Add(panel4, 1, 2);
            tableLayoutPanel1.Controls.Add(lblFondDeCaisse, 0, 3);
            tableLayoutPanel1.Controls.Add(lblReglementParDefaut, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(lblClientParDefaut, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(60, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(434, 133);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(cmbBxFondDeCaisse);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(154, 93);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 5, 4, 0);
            panel5.Size = new Size(277, 34);
            panel5.TabIndex = 31;
            // 
            // cmbBxFondDeCaisse
            // 
            cmbBxFondDeCaisse.Dock = DockStyle.Fill;
            cmbBxFondDeCaisse.FlatStyle = FlatStyle.Flat;
            cmbBxFondDeCaisse.FormattingEnabled = true;
            cmbBxFondDeCaisse.Location = new Point(20, 5);
            cmbBxFondDeCaisse.Name = "cmbBxFondDeCaisse";
            cmbBxFondDeCaisse.Size = new Size(251, 23);
            cmbBxFondDeCaisse.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cmbBxReglementParDefaut);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(154, 53);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 4, 0);
            panel4.Size = new Size(277, 34);
            panel4.TabIndex = 30;
            // 
            // cmbBxReglementParDefaut
            // 
            cmbBxReglementParDefaut.Dock = DockStyle.Fill;
            cmbBxReglementParDefaut.FlatStyle = FlatStyle.Flat;
            cmbBxReglementParDefaut.FormattingEnabled = true;
            cmbBxReglementParDefaut.Location = new Point(20, 5);
            cmbBxReglementParDefaut.Name = "cmbBxReglementParDefaut";
            cmbBxReglementParDefaut.Size = new Size(251, 23);
            cmbBxReglementParDefaut.TabIndex = 0;
            // 
            // lblFondDeCaisse
            // 
            lblFondDeCaisse.AutoSize = true;
            lblFondDeCaisse.Dock = DockStyle.Right;
            lblFondDeCaisse.Location = new Point(64, 90);
            lblFondDeCaisse.Name = "lblFondDeCaisse";
            lblFondDeCaisse.Size = new Size(84, 40);
            lblFondDeCaisse.TabIndex = 27;
            lblFondDeCaisse.Text = "Fond de caisse";
            lblFondDeCaisse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblReglementParDefaut
            // 
            lblReglementParDefaut.AutoSize = true;
            lblReglementParDefaut.Dock = DockStyle.Right;
            lblReglementParDefaut.Location = new Point(27, 50);
            lblReglementParDefaut.Name = "lblReglementParDefaut";
            lblReglementParDefaut.Size = new Size(121, 40);
            lblReglementParDefaut.TabIndex = 24;
            lblReglementParDefaut.Text = "Règlement par défaut";
            lblReglementParDefaut.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmbBxClientParDefaut);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(154, 13);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 5, 4, 0);
            panel2.Size = new Size(277, 34);
            panel2.TabIndex = 19;
            // 
            // cmbBxClientParDefaut
            // 
            cmbBxClientParDefaut.Dock = DockStyle.Fill;
            cmbBxClientParDefaut.FlatStyle = FlatStyle.Flat;
            cmbBxClientParDefaut.FormattingEnabled = true;
            cmbBxClientParDefaut.Location = new Point(20, 5);
            cmbBxClientParDefaut.Name = "cmbBxClientParDefaut";
            cmbBxClientParDefaut.Size = new Size(251, 23);
            cmbBxClientParDefaut.TabIndex = 0;
            // 
            // lblClientParDefaut
            // 
            lblClientParDefaut.AutoSize = true;
            lblClientParDefaut.Dock = DockStyle.Right;
            lblClientParDefaut.Location = new Point(53, 10);
            lblClientParDefaut.Name = "lblClientParDefaut";
            lblClientParDefaut.Size = new Size(95, 40);
            lblClientParDefaut.TabIndex = 0;
            lblClientParDefaut.Text = "Client par défaut";
            lblClientParDefaut.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(15, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(60, 3, 60, 3);
            groupBox2.Size = new Size(554, 115);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Regroupement lors de la clôture de caisse";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(panel9, 1, 2);
            tableLayoutPanel2.Controls.Add(panel8, 1, 1);
            tableLayoutPanel2.Controls.Add(lblReglement, 0, 2);
            tableLayoutPanel2.Controls.Add(lblTickets, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(60, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(434, 93);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(cmbBxReglement);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(154, 53);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 5, 4, 0);
            panel9.Size = new Size(277, 34);
            panel9.TabIndex = 28;
            // 
            // cmbBxReglement
            // 
            cmbBxReglement.Dock = DockStyle.Fill;
            cmbBxReglement.FlatStyle = FlatStyle.Flat;
            cmbBxReglement.FormattingEnabled = true;
            cmbBxReglement.Location = new Point(20, 5);
            cmbBxReglement.Name = "cmbBxReglement";
            cmbBxReglement.Size = new Size(251, 23);
            cmbBxReglement.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(cmbBxTickets);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(154, 13);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 5, 4, 0);
            panel8.Size = new Size(277, 34);
            panel8.TabIndex = 27;
            // 
            // cmbBxTickets
            // 
            cmbBxTickets.Dock = DockStyle.Fill;
            cmbBxTickets.FlatStyle = FlatStyle.Flat;
            cmbBxTickets.FormattingEnabled = true;
            cmbBxTickets.Location = new Point(20, 5);
            cmbBxTickets.Name = "cmbBxTickets";
            cmbBxTickets.Size = new Size(251, 23);
            cmbBxTickets.TabIndex = 0;
            // 
            // lblReglement
            // 
            lblReglement.AutoSize = true;
            lblReglement.Dock = DockStyle.Right;
            lblReglement.Location = new Point(84, 50);
            lblReglement.Name = "lblReglement";
            lblReglement.Size = new Size(64, 40);
            lblReglement.TabIndex = 24;
            lblReglement.Text = "Règlement";
            lblReglement.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Dock = DockStyle.Right;
            lblTickets.Location = new Point(104, 10);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(44, 40);
            lblTickets.TabIndex = 0;
            lblTickets.Text = "Tickets";
            lblTickets.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.FromArgb(129, 166, 181);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI", 11F);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(379, 389);
            btnEnregistrer.Margin = new Padding(144, 3, 144, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Padding = new Padding(8, 0, 0, 0);
            btnEnregistrer.Size = new Size(190, 45);
            btnEnregistrer.TabIndex = 20;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(571, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 40;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ParametresCaisses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(619, 452);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnEnregistrer);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ParametresCaisses";
            ShowIcon = false;
            ShowInTaskbar = false;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label lblClientParDefaut;
        private Label lblReglementParDefaut;
        private Label lblFondDeCaisse;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblReglement;
        private Label lblTickets;
        private Button btnEnregistrer;
        private ComboBox cmbBxClientParDefaut;
        private Panel panel5;
        private ComboBox cmbBxFondDeCaisse;
        private Panel panel4;
        private ComboBox cmbBxReglementParDefaut;
        private Panel panel9;
        private ComboBox cmbBxReglement;
        private Panel panel8;
        private ComboBox cmbBxTickets;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}