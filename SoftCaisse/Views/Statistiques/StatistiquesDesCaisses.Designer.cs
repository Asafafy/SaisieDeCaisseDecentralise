using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Statistiques
{
    partial class StatistiquesDesCaisses
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
            labelStatistiquesDeCaisse = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            comboBoxDocuments = new ComboBox();
            panel3 = new Panel();
            comboBoxTypeDEtat = new ComboBox();
            labelDocuments = new Label();
            labelTypeDEtat = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            textBoxNPieceA = new TextBox();
            panel8 = new Panel();
            textBoxNPieceDe = new TextBox();
            panel1 = new Panel();
            dateTimePickerDateFin = new DateTimePicker();
            textBoxDateA = new TextBox();
            panel7 = new Panel();
            dateTimePickerDateDebut = new DateTimePicker();
            textBoxDateDe = new TextBox();
            labelANPiece = new Label();
            labelADate = new Label();
            labelNPieceDe = new Label();
            labelDateDe = new Label();
            groupBoxCaisse = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel6 = new Panel();
            comboBoxCaisseA = new ComboBox();
            panel5 = new Panel();
            comboBoxCaisseDe = new ComboBox();
            labelACaisse = new Label();
            labelCaisseDe = new Label();
            buttonOK = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            groupBoxCaisse.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // labelStatistiquesDeCaisse
            // 
            labelStatistiquesDeCaisse.AutoSize = true;
            labelStatistiquesDeCaisse.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelStatistiquesDeCaisse.ForeColor = Color.FromArgb(29, 64, 102);
            labelStatistiquesDeCaisse.Location = new Point(125, 57);
            labelStatistiquesDeCaisse.Name = "labelStatistiquesDeCaisse";
            labelStatistiquesDeCaisse.Size = new Size(196, 25);
            labelStatistiquesDeCaisse.TabIndex = 19;
            labelStatistiquesDeCaisse.Text = "Statistiques de caisse";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 10, 10, 15);
            groupBox1.Size = new Size(420, 122);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Types à contrôler";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(labelDocuments, 0, 1);
            tableLayoutPanel1.Controls.Add(labelTypeDEtat, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(400, 81);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(comboBoxDocuments);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(163, 43);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 4, 0);
            panel4.Size = new Size(234, 35);
            panel4.TabIndex = 48;
            // 
            // comboBoxDocuments
            // 
            comboBoxDocuments.Dock = DockStyle.Fill;
            comboBoxDocuments.FlatStyle = FlatStyle.Flat;
            comboBoxDocuments.FormattingEnabled = true;
            comboBoxDocuments.Location = new Point(20, 5);
            comboBoxDocuments.Name = "comboBoxDocuments";
            comboBoxDocuments.Size = new Size(208, 23);
            comboBoxDocuments.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboBoxTypeDEtat);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(163, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 5, 4, 0);
            panel3.Size = new Size(234, 34);
            panel3.TabIndex = 47;
            // 
            // comboBoxTypeDEtat
            // 
            comboBoxTypeDEtat.Dock = DockStyle.Fill;
            comboBoxTypeDEtat.FlatStyle = FlatStyle.Flat;
            comboBoxTypeDEtat.FormattingEnabled = true;
            comboBoxTypeDEtat.Location = new Point(20, 5);
            comboBoxTypeDEtat.Name = "comboBoxTypeDEtat";
            comboBoxTypeDEtat.Size = new Size(208, 23);
            comboBoxTypeDEtat.TabIndex = 0;
            // 
            // labelDocuments
            // 
            labelDocuments.AutoSize = true;
            labelDocuments.Dock = DockStyle.Right;
            labelDocuments.Location = new Point(89, 40);
            labelDocuments.Name = "labelDocuments";
            labelDocuments.Size = new Size(68, 41);
            labelDocuments.TabIndex = 2;
            labelDocuments.Text = "Documents";
            labelDocuments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTypeDEtat
            // 
            labelTypeDEtat.AutoSize = true;
            labelTypeDEtat.Dock = DockStyle.Right;
            labelTypeDEtat.Location = new Point(92, 0);
            labelTypeDEtat.Name = "labelTypeDEtat";
            labelTypeDEtat.Size = new Size(65, 40);
            labelTypeDEtat.TabIndex = 0;
            labelTypeDEtat.Text = "Type d'état";
            labelTypeDEtat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(12, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 10, 10, 15);
            groupBox2.Size = new Size(420, 122);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Intervalles";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Controls.Add(panel2, 3, 1);
            tableLayoutPanel2.Controls.Add(panel8, 1, 1);
            tableLayoutPanel2.Controls.Add(panel1, 3, 0);
            tableLayoutPanel2.Controls.Add(panel7, 1, 0);
            tableLayoutPanel2.Controls.Add(labelANPiece, 2, 1);
            tableLayoutPanel2.Controls.Add(labelADate, 2, 0);
            tableLayoutPanel2.Controls.Add(labelNPieceDe, 0, 1);
            tableLayoutPanel2.Controls.Add(labelDateDe, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(400, 81);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxNPieceA);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(263, 43);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 9, 4, 0);
            panel2.Size = new Size(134, 35);
            panel2.TabIndex = 49;
            // 
            // textBoxNPieceA
            // 
            textBoxNPieceA.BorderStyle = BorderStyle.None;
            textBoxNPieceA.Dock = DockStyle.Fill;
            textBoxNPieceA.Location = new Point(10, 9);
            textBoxNPieceA.Name = "textBoxNPieceA";
            textBoxNPieceA.Size = new Size(118, 16);
            textBoxNPieceA.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(textBoxNPieceDe);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(83, 43);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(10, 9, 4, 0);
            panel8.Size = new Size(134, 35);
            panel8.TabIndex = 48;
            // 
            // textBoxNPieceDe
            // 
            textBoxNPieceDe.BorderStyle = BorderStyle.None;
            textBoxNPieceDe.Dock = DockStyle.Fill;
            textBoxNPieceDe.Location = new Point(10, 9);
            textBoxNPieceDe.Name = "textBoxNPieceDe";
            textBoxNPieceDe.Size = new Size(118, 16);
            textBoxNPieceDe.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePickerDateFin);
            panel1.Controls.Add(textBoxDateA);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(263, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 9, 10, 10);
            panel1.Size = new Size(134, 34);
            panel1.TabIndex = 41;
            // 
            // dateTimePickerDateFin
            // 
            dateTimePickerDateFin.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerDateFin.Location = new Point(1, 34);
            dateTimePickerDateFin.Name = "dateTimePickerDateFin";
            dateTimePickerDateFin.Size = new Size(158, 23);
            dateTimePickerDateFin.TabIndex = 25;
            dateTimePickerDateFin.ValueChanged += dateTimePickerDateFin_ValueChanged;
            // 
            // textBoxDateA
            // 
            textBoxDateA.BorderStyle = BorderStyle.None;
            textBoxDateA.Dock = DockStyle.Fill;
            textBoxDateA.Location = new Point(10, 9);
            textBoxDateA.Name = "textBoxDateA";
            textBoxDateA.Size = new Size(112, 16);
            textBoxDateA.TabIndex = 0;
            textBoxDateA.Click += textBoxDateA_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(dateTimePickerDateDebut);
            panel7.Controls.Add(textBoxDateDe);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(83, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10, 9, 10, 10);
            panel7.Size = new Size(134, 34);
            panel7.TabIndex = 40;
            // 
            // dateTimePickerDateDebut
            // 
            dateTimePickerDateDebut.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerDateDebut.Location = new Point(1, 34);
            dateTimePickerDateDebut.Name = "dateTimePickerDateDebut";
            dateTimePickerDateDebut.Size = new Size(158, 23);
            dateTimePickerDateDebut.TabIndex = 25;
            dateTimePickerDateDebut.ValueChanged += dateTimePickerDateDebut_ValueChanged;
            // 
            // textBoxDateDe
            // 
            textBoxDateDe.BorderStyle = BorderStyle.None;
            textBoxDateDe.Dock = DockStyle.Fill;
            textBoxDateDe.Location = new Point(10, 9);
            textBoxDateDe.Name = "textBoxDateDe";
            textBoxDateDe.Size = new Size(112, 16);
            textBoxDateDe.TabIndex = 0;
            textBoxDateDe.Click += textBoxDateDe_Click;
            // 
            // labelANPiece
            // 
            labelANPiece.AutoSize = true;
            labelANPiece.Dock = DockStyle.Fill;
            labelANPiece.Location = new Point(223, 40);
            labelANPiece.Name = "labelANPiece";
            labelANPiece.Size = new Size(34, 41);
            labelANPiece.TabIndex = 8;
            labelANPiece.Text = "à";
            labelANPiece.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelADate
            // 
            labelADate.AutoSize = true;
            labelADate.Dock = DockStyle.Fill;
            labelADate.Location = new Point(223, 0);
            labelADate.Name = "labelADate";
            labelADate.Size = new Size(34, 40);
            labelADate.TabIndex = 5;
            labelADate.Text = "à";
            labelADate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNPieceDe
            // 
            labelNPieceDe.AutoSize = true;
            labelNPieceDe.Dock = DockStyle.Right;
            labelNPieceDe.Location = new Point(9, 40);
            labelNPieceDe.Name = "labelNPieceDe";
            labelNPieceDe.Size = new Size(68, 41);
            labelNPieceDe.TabIndex = 3;
            labelNPieceDe.Text = "N° pièce de";
            labelNPieceDe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDateDe
            // 
            labelDateDe.AutoSize = true;
            labelDateDe.Dock = DockStyle.Right;
            labelDateDe.Location = new Point(30, 0);
            labelDateDe.Name = "labelDateDe";
            labelDateDe.Size = new Size(47, 40);
            labelDateDe.TabIndex = 1;
            labelDateDe.Text = "Date de";
            labelDateDe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBoxCaisse
            // 
            groupBoxCaisse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCaisse.Controls.Add(tableLayoutPanel3);
            groupBoxCaisse.Location = new Point(12, 414);
            groupBoxCaisse.Name = "groupBoxCaisse";
            groupBoxCaisse.Padding = new Padding(10, 10, 10, 15);
            groupBoxCaisse.Size = new Size(420, 122);
            groupBoxCaisse.TabIndex = 22;
            groupBoxCaisse.TabStop = false;
            groupBoxCaisse.Text = "Caisse";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Controls.Add(panel6, 1, 1);
            tableLayoutPanel3.Controls.Add(panel5, 1, 0);
            tableLayoutPanel3.Controls.Add(labelACaisse, 0, 1);
            tableLayoutPanel3.Controls.Add(labelCaisseDe, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 26);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(400, 81);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboBoxCaisseA);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(123, 43);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(274, 35);
            panel6.TabIndex = 48;
            // 
            // comboBoxCaisseA
            // 
            comboBoxCaisseA.Dock = DockStyle.Fill;
            comboBoxCaisseA.FlatStyle = FlatStyle.Flat;
            comboBoxCaisseA.FormattingEnabled = true;
            comboBoxCaisseA.Location = new Point(20, 5);
            comboBoxCaisseA.Name = "comboBoxCaisseA";
            comboBoxCaisseA.Size = new Size(248, 23);
            comboBoxCaisseA.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBoxCaisseDe);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(123, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 5, 4, 0);
            panel5.Size = new Size(274, 34);
            panel5.TabIndex = 47;
            // 
            // comboBoxCaisseDe
            // 
            comboBoxCaisseDe.Dock = DockStyle.Fill;
            comboBoxCaisseDe.FlatStyle = FlatStyle.Flat;
            comboBoxCaisseDe.FormattingEnabled = true;
            comboBoxCaisseDe.Location = new Point(20, 5);
            comboBoxCaisseDe.Name = "comboBoxCaisseDe";
            comboBoxCaisseDe.Size = new Size(248, 23);
            comboBoxCaisseDe.TabIndex = 0;
            // 
            // labelACaisse
            // 
            labelACaisse.AutoSize = true;
            labelACaisse.Dock = DockStyle.Right;
            labelACaisse.Location = new Point(104, 40);
            labelACaisse.Name = "labelACaisse";
            labelACaisse.Size = new Size(13, 41);
            labelACaisse.TabIndex = 3;
            labelACaisse.Text = "à";
            labelACaisse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCaisseDe
            // 
            labelCaisseDe.AutoSize = true;
            labelCaisseDe.Dock = DockStyle.Right;
            labelCaisseDe.Location = new Point(61, 0);
            labelCaisseDe.Name = "labelCaisseDe";
            labelCaisseDe.Size = new Size(56, 40);
            labelCaisseDe.TabIndex = 1;
            labelCaisseDe.Text = "Caisse de";
            labelCaisseDe.TextAlign = ContentAlignment.MiddleRight;
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
            buttonOK.Location = new Point(247, 570);
            buttonOK.Margin = new Padding(144, 3, 144, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Padding = new Padding(8, 0, 0, 0);
            buttonOK.Size = new Size(185, 45);
            buttonOK.TabIndex = 46;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(432, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 49;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // StatistiquesDesCaisses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(484, 627);
            Controls.Add(iconButtonFermer);
            Controls.Add(buttonOK);
            Controls.Add(groupBoxCaisse);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelStatistiquesDeCaisse);
            Name = "StatistiquesDesCaisses";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Statistiques des caisses";
            Load += StatistiquesDesCaisses_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            groupBoxCaisse.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelStatistiquesDeCaisse;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelDocuments;
        private Label labelTypeDEtat;
        private Label labelNPieceDe;
        private Label labelDateDe;
        private Label labelANPiece;
        private Label labelADate;
        private GroupBox groupBoxCaisse;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelACaisse;
        private Label labelCaisseDe;
        private Button buttonOK;
        private Panel panel1;
        private DateTimePicker dateTimePickerDateFin;
        private TextBox textBoxDateA;
        private Panel panel7;
        private DateTimePicker dateTimePickerDateDebut;
        private TextBox textBoxDateDe;
        private Panel panel2;
        private TextBox textBoxNPieceA;
        private Panel panel8;
        private TextBox textBoxNPieceDe;
        private Panel panel4;
        private ComboBox comboBoxDocuments;
        private Panel panel3;
        private ComboBox comboBoxTypeDEtat;
        private Panel panel6;
        private ComboBox comboBoxCaisseA;
        private Panel panel5;
        private ComboBox comboBoxCaisseDe;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}