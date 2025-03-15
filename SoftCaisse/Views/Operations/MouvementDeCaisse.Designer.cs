using System.Drawing;
using System.Windows.Forms;







namespace Soft_Caisse.Views.Operations
{
    partial class MouvementDeCaisse
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
            buttonCaisse = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            textBoxCommentaire = new TextBox();
            labelCommentaire = new Label();
            labelMontant = new Label();
            labelCompte = new Label();
            panel2 = new Panel();
            comboBoxCompteG = new ComboBox();
            panel1 = new Panel();
            textBoxMontant = new TextBox();
            labelType = new Label();
            labelDate = new Label();
            panel5 = new Panel();
            comboBoxTypeMouvement = new ComboBox();
            panel4 = new Panel();
            dateTimePickerCustom = new DateTimePicker();
            textBoxDateTime = new TextBox();
            buttonOK = new Button();
            panel6 = new Panel();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCaisse
            // 
            buttonCaisse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCaisse.BackColor = Color.FromArgb(84, 138, 178);
            buttonCaisse.FlatAppearance.BorderSize = 0;
            buttonCaisse.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 138, 178);
            buttonCaisse.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 138, 178);
            buttonCaisse.FlatStyle = FlatStyle.Flat;
            buttonCaisse.Font = new Font("Segoe UI", 12F);
            buttonCaisse.ForeColor = Color.White;
            buttonCaisse.Location = new Point(12, 45);
            buttonCaisse.Margin = new Padding(144, 3, 144, 3);
            buttonCaisse.Name = "buttonCaisse";
            buttonCaisse.Padding = new Padding(8, 0, 0, 0);
            buttonCaisse.Size = new Size(306, 45);
            buttonCaisse.TabIndex = 36;
            buttonCaisse.Text = "Caisse : Annexe BIJOU SA";
            buttonCaisse.TextAlign = ContentAlignment.MiddleLeft;
            buttonCaisse.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 5);
            tableLayoutPanel1.Controls.Add(labelCommentaire, 0, 5);
            tableLayoutPanel1.Controls.Add(labelMontant, 0, 4);
            tableLayoutPanel1.Controls.Add(labelCompte, 0, 3);
            tableLayoutPanel1.Controls.Add(panel2, 1, 3);
            tableLayoutPanel1.Controls.Add(panel1, 1, 4);
            tableLayoutPanel1.Controls.Add(labelType, 0, 2);
            tableLayoutPanel1.Controls.Add(labelDate, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 2);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(575, 219);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBoxCommentaire);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(118, 173);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 9, 20, 10);
            panel3.Size = new Size(454, 34);
            panel3.TabIndex = 68;
            // 
            // textBoxCommentaire
            // 
            textBoxCommentaire.BorderStyle = BorderStyle.None;
            textBoxCommentaire.Dock = DockStyle.Fill;
            textBoxCommentaire.Location = new Point(20, 9);
            textBoxCommentaire.Name = "textBoxCommentaire";
            //textBoxCommentaire.PlaceholderText = "Commentaire";
            textBoxCommentaire.Size = new Size(412, 16);
            textBoxCommentaire.TabIndex = 0;
            // 
            // labelCommentaire
            // 
            labelCommentaire.AutoSize = true;
            labelCommentaire.Dock = DockStyle.Right;
            labelCommentaire.Location = new Point(32, 170);
            labelCommentaire.Name = "labelCommentaire";
            labelCommentaire.Size = new Size(80, 40);
            labelCommentaire.TabIndex = 67;
            labelCommentaire.Text = "Commentaire";
            labelCommentaire.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Dock = DockStyle.Right;
            labelMontant.Location = new Point(59, 130);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(53, 40);
            labelMontant.TabIndex = 66;
            labelMontant.Text = "Montant";
            labelMontant.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCompte
            // 
            labelCompte.AutoSize = true;
            labelCompte.Dock = DockStyle.Right;
            labelCompte.Location = new Point(62, 90);
            labelCompte.Name = "labelCompte";
            labelCompte.Size = new Size(50, 40);
            labelCompte.TabIndex = 65;
            labelCompte.Text = "Compte";
            labelCompte.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBoxCompteG);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(118, 93);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 5, 4, 0);
            panel2.Size = new Size(454, 34);
            panel2.TabIndex = 64;
            // 
            // comboBoxCompteG
            // 
            comboBoxCompteG.Dock = DockStyle.Fill;
            comboBoxCompteG.FlatStyle = FlatStyle.Flat;
            comboBoxCompteG.FormattingEnabled = true;
            comboBoxCompteG.Location = new Point(20, 5);
            comboBoxCompteG.Name = "comboBoxCompteG";
            comboBoxCompteG.Size = new Size(428, 23);
            comboBoxCompteG.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxMontant);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(118, 133);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(454, 34);
            panel1.TabIndex = 63;
            // 
            // textBoxMontant
            // 
            textBoxMontant.BorderStyle = BorderStyle.None;
            textBoxMontant.Dock = DockStyle.Fill;
            textBoxMontant.Location = new Point(20, 9);
            textBoxMontant.Name = "textBoxMontant";
            //textBoxMontant.PlaceholderText = "Montant du mouvement de caisse";
            textBoxMontant.Size = new Size(412, 16);
            textBoxMontant.TabIndex = 0;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = DockStyle.Right;
            labelType.Location = new Point(80, 50);
            labelType.Name = "labelType";
            labelType.Size = new Size(32, 40);
            labelType.TabIndex = 62;
            labelType.Text = "Type";
            labelType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Dock = DockStyle.Right;
            labelDate.Location = new Point(81, 10);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 40);
            labelDate.TabIndex = 59;
            labelDate.Text = "Date";
            labelDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBoxTypeMouvement);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(118, 53);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 5, 4, 0);
            panel5.Size = new Size(454, 34);
            panel5.TabIndex = 58;
            // 
            // comboBoxTypeMouvement
            // 
            comboBoxTypeMouvement.Dock = DockStyle.Fill;
            comboBoxTypeMouvement.FlatStyle = FlatStyle.Flat;
            comboBoxTypeMouvement.FormattingEnabled = true;
            comboBoxTypeMouvement.Location = new Point(20, 5);
            comboBoxTypeMouvement.Name = "comboBoxTypeMouvement";
            comboBoxTypeMouvement.Size = new Size(428, 23);
            comboBoxTypeMouvement.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dateTimePickerCustom);
            panel4.Controls.Add(textBoxDateTime);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(118, 13);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 20, 10);
            panel4.Size = new Size(454, 34);
            panel4.TabIndex = 57;
            // 
            // dateTimePickerCustom
            // 
            dateTimePickerCustom.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerCustom.Format = DateTimePickerFormat.Short;
            dateTimePickerCustom.Location = new Point(-1, 34);
            dateTimePickerCustom.Name = "dateTimePickerCustom";
            dateTimePickerCustom.Size = new Size(382, 23);
            dateTimePickerCustom.TabIndex = 25;
            dateTimePickerCustom.ValueChanged += dateTimePickerCustom_ValueChanged_1;
            // 
            // textBoxDateTime
            // 
            textBoxDateTime.BorderStyle = BorderStyle.None;
            textBoxDateTime.Dock = DockStyle.Fill;
            textBoxDateTime.Location = new Point(20, 9);
            textBoxDateTime.Name = "textBoxDateTime";
            //textBoxDateTime.PlaceholderText = "DD/MM/YYYY";
            textBoxDateTime.Size = new Size(412, 16);
            textBoxDateTime.TabIndex = 0;
            textBoxDateTime.Click += textBoxDateTime_Click;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.BackColor = Color.FromArgb(129, 166, 181);
            buttonOK.Cursor = Cursors.Hand;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Segoe UI", 11F);
            buttonOK.ForeColor = Color.White;
            buttonOK.Location = new Point(447, 391);
            buttonOK.Margin = new Padding(144, 3, 144, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Padding = new Padding(8, 0, 0, 0);
            buttonOK.Size = new Size(185, 45);
            buttonOK.TabIndex = 39;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(tableLayoutPanel1);
            panel6.Location = new Point(12, 105);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20);
            panel6.Size = new Size(617, 261);
            panel6.TabIndex = 40;
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
            iconButtonFermer.Location = new Point(630, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 70;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // MouvementDeCaisse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(682, 459);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel6);
            Controls.Add(buttonOK);
            Controls.Add(buttonCaisse);
            Font = new Font("Segoe UI", 9F);
            Name = "MouvementDeCaisse";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Mouvement de caisse";
            Load += MouvementDeCaisse_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonCaisse;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private DateTimePicker dateTimePickerCustom;
        private TextBox textBoxDateTime;
        private Label labelDate;
        private Panel panel5;
        private ComboBox comboBoxTypeMouvement;
        private Label labelType;
        private Label labelMontant;
        private Label labelCompte;
        private Panel panel2;
        private ComboBox comboBoxCompteG;
        private Panel panel1;
        private TextBox textBoxMontant;
        private Panel panel3;
        private TextBox textBoxCommentaire;
        private Label labelCommentaire;
        private Button buttonOK;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}