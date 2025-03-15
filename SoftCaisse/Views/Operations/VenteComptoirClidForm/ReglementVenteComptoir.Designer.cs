using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Operations.VenteComptoirClidForm
{
    partial class ReglementVenteComptoir
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            MoyenDePayement = new DataGridViewTextBoxColumn();
            Montant = new DataGridViewTextBoxColumn();
            Libelle = new DataGridViewTextBoxColumn();
            Devise = new DataGridViewTextBoxColumn();
            Echeance = new DataGridViewTextBoxColumn();
            panelTotal = new Panel();
            label2 = new Label();
            label1 = new Label();
            labelARendre = new Label();
            labelMontantPaye = new Label();
            labelValeurTotalTTC = new Label();
            labelValeurTotalHT = new Label();
            labelResteDu = new Label();
            label = new Label();
            buttonFacture = new Button();
            buttonTicket = new Button();
            buttonValider = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel8 = new Panel();
            textBoxLibelle = new TextBox();
            panel7 = new Panel();
            txtBxMontantTTC = new TextBox();
            panel10 = new Panel();
            dateTimePickerCustom = new DateTimePicker();
            textBox2 = new TextBox();
            panel9 = new Panel();
            comboBox8 = new ComboBox();
            panel6 = new Panel();
            comboBox5 = new ComboBox();
            buttonEnregistrer = new Button();
            buttonSupprimer = new Button();
            buttonNouveau = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTotal.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MoyenDePayement, Montant, Libelle, Devise, Echeance });
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
            dataGridView1.Location = new Point(22, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(730, 262);
            dataGridView1.TabIndex = 31;
            // 
            // MoyenDePayement
            // 
            MoyenDePayement.HeaderText = "Moyen de payement";
            MoyenDePayement.Name = "MoyenDePayement";
            // 
            // Montant
            // 
            Montant.HeaderText = "Montant";
            Montant.Name = "Montant";
            // 
            // Libelle
            // 
            Libelle.HeaderText = "Libellé";
            Libelle.Name = "Libelle";
            // 
            // Devise
            // 
            Devise.HeaderText = "Devise";
            Devise.Name = "Devise";
            // 
            // Echeance
            // 
            Echeance.HeaderText = "Echéance";
            Echeance.Name = "Echeance";
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(230, 29, 64, 102);
            panelTotal.Controls.Add(label2);
            panelTotal.Controls.Add(label1);
            panelTotal.Controls.Add(labelARendre);
            panelTotal.Controls.Add(labelMontantPaye);
            panelTotal.Controls.Add(labelValeurTotalTTC);
            panelTotal.Controls.Add(labelValeurTotalHT);
            panelTotal.Controls.Add(labelResteDu);
            panelTotal.Controls.Add(label);
            panelTotal.Location = new Point(22, 45);
            panelTotal.Margin = new Padding(5, 5, 0, 5);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(728, 168);
            panelTotal.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(547, 39);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 7;
            label2.Text = "0,00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(496, 104);
            label1.Name = "label1";
            label1.Size = new Size(53, 28);
            label1.TabIndex = 6;
            label1.Text = "0,00";
            // 
            // labelARendre
            // 
            labelARendre.AutoSize = true;
            labelARendre.BackColor = Color.Transparent;
            labelARendre.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelARendre.ForeColor = Color.White;
            labelARendre.Location = new Point(385, 104);
            labelARendre.Name = "labelARendre";
            labelARendre.Size = new Size(105, 28);
            labelARendre.TabIndex = 5;
            labelARendre.Text = "A rendre :";
            // 
            // labelMontantPaye
            // 
            labelMontantPaye.AutoSize = true;
            labelMontantPaye.BackColor = Color.Transparent;
            labelMontantPaye.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelMontantPaye.ForeColor = Color.White;
            labelMontantPaye.Location = new Point(385, 39);
            labelMontantPaye.Name = "labelMontantPaye";
            labelMontantPaye.Size = new Size(156, 28);
            labelMontantPaye.TabIndex = 4;
            labelMontantPaye.Text = "Montant Payé :";
            // 
            // labelValeurTotalTTC
            // 
            labelValeurTotalTTC.AutoSize = true;
            labelValeurTotalTTC.BackColor = Color.Transparent;
            labelValeurTotalTTC.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelValeurTotalTTC.ForeColor = Color.White;
            labelValeurTotalTTC.Location = new Point(149, 104);
            labelValeurTotalTTC.Name = "labelValeurTotalTTC";
            labelValeurTotalTTC.Size = new Size(53, 28);
            labelValeurTotalTTC.TabIndex = 3;
            labelValeurTotalTTC.Text = "0,00";
            // 
            // labelValeurTotalHT
            // 
            labelValeurTotalHT.AutoSize = true;
            labelValeurTotalHT.BackColor = Color.Transparent;
            labelValeurTotalHT.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelValeurTotalHT.ForeColor = Color.White;
            labelValeurTotalHT.Location = new Point(149, 39);
            labelValeurTotalHT.Name = "labelValeurTotalHT";
            labelValeurTotalHT.Size = new Size(53, 28);
            labelValeurTotalHT.TabIndex = 2;
            labelValeurTotalHT.Text = "0,00";
            // 
            // labelResteDu
            // 
            labelResteDu.AutoSize = true;
            labelResteDu.BackColor = Color.Transparent;
            labelResteDu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelResteDu.ForeColor = Color.White;
            labelResteDu.Location = new Point(30, 104);
            labelResteDu.Name = "labelResteDu";
            labelResteDu.Size = new Size(105, 28);
            labelResteDu.TabIndex = 1;
            labelResteDu.Text = "Reste dû :";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Location = new Point(30, 39);
            label.Name = "label";
            label.Size = new Size(103, 28);
            label.TabIndex = 0;
            label.Text = "Total HT :";
            // 
            // buttonFacture
            // 
            buttonFacture.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFacture.BackColor = Color.FromArgb(84, 138, 178);
            buttonFacture.Cursor = Cursors.Hand;
            buttonFacture.FlatAppearance.BorderSize = 0;
            buttonFacture.FlatStyle = FlatStyle.Flat;
            buttonFacture.Font = new Font("Segoe UI", 11F);
            buttonFacture.ForeColor = Color.White;
            buttonFacture.Location = new Point(567, 648);
            buttonFacture.Margin = new Padding(144, 3, 144, 3);
            buttonFacture.Name = "buttonFacture";
            buttonFacture.Padding = new Padding(8, 0, 0, 0);
            buttonFacture.Size = new Size(185, 45);
            buttonFacture.TabIndex = 34;
            buttonFacture.Text = "Facture";
            buttonFacture.UseVisualStyleBackColor = false;
            // 
            // buttonTicket
            // 
            buttonTicket.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTicket.BackColor = Color.FromArgb(84, 138, 178);
            buttonTicket.Cursor = Cursors.Hand;
            buttonTicket.FlatAppearance.BorderSize = 0;
            buttonTicket.FlatStyle = FlatStyle.Flat;
            buttonTicket.Font = new Font("Segoe UI", 11F);
            buttonTicket.ForeColor = Color.White;
            buttonTicket.Location = new Point(373, 648);
            buttonTicket.Margin = new Padding(144, 3, 144, 3);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Padding = new Padding(8, 0, 0, 0);
            buttonTicket.Size = new Size(185, 45);
            buttonTicket.TabIndex = 33;
            buttonTicket.Text = "Ticket";
            buttonTicket.UseVisualStyleBackColor = false;
            // 
            // buttonValider
            // 
            buttonValider.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValider.BackColor = Color.FromArgb(84, 138, 178);
            buttonValider.Cursor = Cursors.Hand;
            buttonValider.FlatAppearance.BorderSize = 0;
            buttonValider.FlatStyle = FlatStyle.Flat;
            buttonValider.Font = new Font("Segoe UI", 11F);
            buttonValider.ForeColor = Color.White;
            buttonValider.Location = new Point(179, 648);
            buttonValider.Margin = new Padding(144, 3, 144, 3);
            buttonValider.Name = "buttonValider";
            buttonValider.Padding = new Padding(8, 0, 0, 0);
            buttonValider.Size = new Size(185, 45);
            buttonValider.TabIndex = 35;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel8, 2, 1);
            tableLayoutPanel1.Controls.Add(panel7, 1, 1);
            tableLayoutPanel1.Controls.Add(panel10, 4, 1);
            tableLayoutPanel1.Controls.Add(panel9, 3, 1);
            tableLayoutPanel1.Controls.Add(panel6, 0, 1);
            tableLayoutPanel1.Location = new Point(22, 234);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(728, 57);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(textBoxLibelle);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(293, 13);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 9, 20, 10);
            panel8.Size = new Size(139, 34);
            panel8.TabIndex = 42;
            // 
            // textBoxLibelle
            // 
            textBoxLibelle.BorderStyle = BorderStyle.None;
            textBoxLibelle.Dock = DockStyle.Fill;
            textBoxLibelle.Location = new Point(20, 9);
            textBoxLibelle.Name = "textBoxLibelle";
            //textBoxLibelle.PlaceholderText = "Libellé";
            textBoxLibelle.Size = new Size(97, 16);
            textBoxLibelle.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txtBxMontantTTC);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(148, 13);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 9, 20, 10);
            panel7.Size = new Size(139, 34);
            panel7.TabIndex = 41;
            // 
            // txtBxMontantTTC
            // 
            txtBxMontantTTC.BorderStyle = BorderStyle.None;
            txtBxMontantTTC.Dock = DockStyle.Fill;
            txtBxMontantTTC.Location = new Point(20, 9);
            txtBxMontantTTC.Name = "txtBxMontantTTC";
            //txtBxMontantTTC.PlaceholderText = "Montant TTC";
            txtBxMontantTTC.Size = new Size(97, 16);
            txtBxMontantTTC.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(dateTimePickerCustom);
            panel10.Controls.Add(textBox2);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(583, 13);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 9, 20, 10);
            panel10.Size = new Size(142, 34);
            panel10.TabIndex = 40;
            // 
            // dateTimePickerCustom
            // 
            dateTimePickerCustom.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerCustom.Format = DateTimePickerFormat.Short;
            dateTimePickerCustom.Location = new Point(-1, 34);
            dateTimePickerCustom.Name = "dateTimePickerCustom";
            dateTimePickerCustom.Size = new Size(142, 23);
            dateTimePickerCustom.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(20, 9);
            textBox2.Name = "textBox2";
            //textBox2.PlaceholderText = "DD/MM/YYYY";
            textBox2.Size = new Size(100, 16);
            textBox2.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(comboBox8);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(438, 13);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 5, 4, 0);
            panel9.Size = new Size(139, 34);
            panel9.TabIndex = 37;
            // 
            // comboBox8
            // 
            comboBox8.Dock = DockStyle.Fill;
            comboBox8.FlatStyle = FlatStyle.Flat;
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(20, 5);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(113, 23);
            comboBox8.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboBox5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 13);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(139, 34);
            panel6.TabIndex = 34;
            // 
            // comboBox5
            // 
            comboBox5.Dock = DockStyle.Fill;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(20, 5);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(113, 23);
            comboBox5.TabIndex = 0;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEnregistrer.BackColor = Color.FromArgb(129, 166, 181);
            buttonEnregistrer.Cursor = Cursors.Hand;
            buttonEnregistrer.FlatAppearance.BorderSize = 0;
            buttonEnregistrer.FlatStyle = FlatStyle.Flat;
            buttonEnregistrer.Font = new Font("Segoe UI", 11F);
            buttonEnregistrer.ForeColor = Color.White;
            buttonEnregistrer.Location = new Point(567, 299);
            buttonEnregistrer.Margin = new Padding(144, 3, 144, 3);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Padding = new Padding(8, 0, 0, 0);
            buttonEnregistrer.Size = new Size(185, 45);
            buttonEnregistrer.TabIndex = 37;
            buttonEnregistrer.Text = "Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = false;
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
            buttonSupprimer.Location = new Point(373, 299);
            buttonSupprimer.Margin = new Padding(144, 3, 144, 3);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Padding = new Padding(8, 0, 0, 0);
            buttonSupprimer.Size = new Size(185, 45);
            buttonSupprimer.TabIndex = 38;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
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
            buttonNouveau.Location = new Point(179, 299);
            buttonNouveau.Margin = new Padding(144, 3, 144, 3);
            buttonNouveau.Name = "buttonNouveau";
            buttonNouveau.Padding = new Padding(8, 0, 0, 0);
            buttonNouveau.Size = new Size(185, 45);
            buttonNouveau.TabIndex = 39;
            buttonNouveau.Text = "Nouveau";
            buttonNouveau.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(752, 4);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 65;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ReglementVenteComptoir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 705);
            Controls.Add(iconButtonFermer);
            Controls.Add(buttonNouveau);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonEnregistrer);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonValider);
            Controls.Add(buttonFacture);
            Controls.Add(buttonTicket);
            Controls.Add(panelTotal);
            Controls.Add(dataGridView1);
            Name = "ReglementVenteComptoir";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Reglement au vente comptoir";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MoyenDePayement;
        private DataGridViewTextBoxColumn Montant;
        private DataGridViewTextBoxColumn Libelle;
        private DataGridViewTextBoxColumn Devise;
        private DataGridViewTextBoxColumn Echeance;
        private Panel panelTotal;
        private Label labelValeurTotalTTC;
        private Label labelValeurTotalHT;
        private Label labelResteDu;
        private Label label;
        private Label labelMontantPaye;
        private Label labelARendre;
        private Label label1;
        private Label label2;
        private Button buttonFacture;
        private Button buttonTicket;
        private Button buttonValider;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel9;
        private ComboBox comboBox8;
        private Panel panel6;
        private ComboBox comboBox5;
        private Panel panel10;
        private DateTimePicker dateTimePickerCustom;
        private TextBox textBox2;
        private Panel panel8;
        private TextBox textBoxLibelle;
        private Panel panel7;
        private TextBox txtBxMontantTTC;
        private Button buttonEnregistrer;
        private Button buttonSupprimer;
        private Button buttonNouveau;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}