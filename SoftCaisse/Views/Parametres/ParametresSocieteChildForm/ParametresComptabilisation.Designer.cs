using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres.ParametresSociete
{
    partial class ParametresComptabilisation
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
            groupBoxComptabilisationMouvementsDeCaisse = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            cmbBxCompteCredit = new ComboBox();
            panel3 = new Panel();
            cmbBxCompteDebit = new ComboBox();
            lblCompteCredit = new Label();
            lblCompteDebit = new Label();
            btnBilletage = new Button();
            checkBoxComptabiliserLesMouvementsDeCaisse = new CheckBox();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBoxComptabilisationMouvementsDeCaisse.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxComptabilisationMouvementsDeCaisse
            // 
            groupBoxComptabilisationMouvementsDeCaisse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxComptabilisationMouvementsDeCaisse.Controls.Add(tableLayoutPanel1);
            groupBoxComptabilisationMouvementsDeCaisse.Location = new Point(50, 50);
            groupBoxComptabilisationMouvementsDeCaisse.Name = "groupBoxComptabilisationMouvementsDeCaisse";
            groupBoxComptabilisationMouvementsDeCaisse.Padding = new Padding(60, 3, 60, 3);
            groupBoxComptabilisationMouvementsDeCaisse.Size = new Size(576, 140);
            groupBoxComptabilisationMouvementsDeCaisse.TabIndex = 0;
            groupBoxComptabilisationMouvementsDeCaisse.TabStop = false;
            groupBoxComptabilisationMouvementsDeCaisse.Text = "Comptabilisation des mouvements de caisse";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel6, 1, 3);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(lblCompteCredit, 0, 3);
            tableLayoutPanel1.Controls.Add(lblCompteDebit, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(60, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(456, 118);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(cmbBxCompteCredit);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(162, 73);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(291, 34);
            panel6.TabIndex = 31;
            // 
            // cmbBxCompteCredit
            // 
            cmbBxCompteCredit.Dock = DockStyle.Fill;
            cmbBxCompteCredit.FlatStyle = FlatStyle.Flat;
            cmbBxCompteCredit.FormattingEnabled = true;
            cmbBxCompteCredit.Location = new Point(20, 5);
            cmbBxCompteCredit.Name = "cmbBxCompteCredit";
            cmbBxCompteCredit.Size = new Size(265, 23);
            cmbBxCompteCredit.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cmbBxCompteDebit);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(162, 13);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 5, 4, 0);
            panel3.Size = new Size(291, 34);
            panel3.TabIndex = 28;
            // 
            // cmbBxCompteDebit
            // 
            cmbBxCompteDebit.Dock = DockStyle.Fill;
            cmbBxCompteDebit.FlatStyle = FlatStyle.Flat;
            cmbBxCompteDebit.FormattingEnabled = true;
            cmbBxCompteDebit.Location = new Point(20, 5);
            cmbBxCompteDebit.Name = "cmbBxCompteDebit";
            cmbBxCompteDebit.Size = new Size(265, 23);
            cmbBxCompteDebit.TabIndex = 0;
            // 
            // lblCompteCredit
            // 
            lblCompteCredit.AutoSize = true;
            lblCompteCredit.Dock = DockStyle.Right;
            lblCompteCredit.Location = new Point(73, 70);
            lblCompteCredit.Name = "lblCompteCredit";
            lblCompteCredit.Size = new Size(83, 40);
            lblCompteCredit.TabIndex = 25;
            lblCompteCredit.Text = "Compte crédit";
            lblCompteCredit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCompteDebit
            // 
            lblCompteDebit.AutoSize = true;
            lblCompteDebit.Dock = DockStyle.Right;
            lblCompteDebit.Location = new Point(76, 10);
            lblCompteDebit.Name = "lblCompteDebit";
            lblCompteDebit.Size = new Size(80, 40);
            lblCompteDebit.TabIndex = 0;
            lblCompteDebit.Text = "Compte débit";
            lblCompteDebit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnBilletage
            // 
            btnBilletage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBilletage.BackColor = Color.FromArgb(129, 166, 181);
            btnBilletage.Cursor = Cursors.Hand;
            btnBilletage.FlatAppearance.BorderSize = 0;
            btnBilletage.FlatStyle = FlatStyle.Flat;
            btnBilletage.Font = new Font("Segoe UI", 11F);
            btnBilletage.ForeColor = Color.White;
            btnBilletage.Location = new Point(436, 245);
            btnBilletage.Margin = new Padding(144, 3, 144, 3);
            btnBilletage.Name = "btnBilletage";
            btnBilletage.Padding = new Padding(8, 0, 0, 0);
            btnBilletage.Size = new Size(190, 45);
            btnBilletage.TabIndex = 24;
            btnBilletage.Text = "Enregistrer";
            btnBilletage.UseVisualStyleBackColor = false;
            // 
            // checkBoxComptabiliserLesMouvementsDeCaisse
            // 
            checkBoxComptabiliserLesMouvementsDeCaisse.AutoSize = true;
            checkBoxComptabiliserLesMouvementsDeCaisse.Location = new Point(50, 205);
            checkBoxComptabiliserLesMouvementsDeCaisse.Name = "checkBoxComptabiliserLesMouvementsDeCaisse";
            checkBoxComptabiliserLesMouvementsDeCaisse.Size = new Size(240, 19);
            checkBoxComptabiliserLesMouvementsDeCaisse.TabIndex = 25;
            checkBoxComptabiliserLesMouvementsDeCaisse.Text = "Comptabiliser les mouvements de caisse";
            checkBoxComptabiliserLesMouvementsDeCaisse.UseVisualStyleBackColor = true;
            checkBoxComptabiliserLesMouvementsDeCaisse.CheckedChanged += checkBoxComptabiliserLesMouvementsDeCaisse_CheckedChanged;
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
            iconButtonFermer.Location = new Point(632, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 41;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ParametresComptabilisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(684, 302);
            Controls.Add(iconButtonFermer);
            Controls.Add(checkBoxComptabiliserLesMouvementsDeCaisse);
            Controls.Add(btnBilletage);
            Controls.Add(groupBoxComptabilisationMouvementsDeCaisse);
            Name = "ParametresComptabilisation";
            ShowIcon = false;
            ShowInTaskbar = false;
            groupBoxComptabilisationMouvementsDeCaisse.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxComptabilisationMouvementsDeCaisse;
        private Button btnBilletage;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCompteCredit;
        private Label lblCompteDebit;
        private Panel panel6;
        private ComboBox cmbBxCompteCredit;
        private Panel panel3;
        private ComboBox cmbBxCompteDebit;
        private CheckBox checkBoxComptabiliserLesMouvementsDeCaisse;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}