using System.Drawing;
using System.Windows.Forms;




namespace Soft_Caisse.Views.Operations.SaisieDesReglementsChildForm
{
    partial class VisualisationDUnReglement
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
            dataGridView1 = new DataGridView();
            Echeance = new DataGridViewTextBoxColumn();
            NPiece = new DataGridViewTextBoxColumn();
            NClient = new DataGridViewTextBoxColumn();
            ModeDeReglement = new DataGridViewTextBoxColumn();
            Pourcentage = new DataGridViewTextBoxColumn();
            EstPaye = new DataGridViewTextBoxColumn();
            Solde = new DataGridViewTextBoxColumn();
            Reglement = new DataGridViewTextBoxColumn();
            panelTotal = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelValeurResteAImputer = new Label();
            labelResteAImputer = new Label();
            labelTotalImpute = new Label();
            labelTotalReglement = new Label();
            labelValeurTotalImpute = new Label();
            labelValeurTotalReglement = new Label();
            buttonFermer = new Button();
            buttonReglement = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTotal.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Echeance, NPiece, NClient, ModeDeReglement, Pourcentage, EstPaye, Solde, Reglement });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(889, 409);
            dataGridView1.TabIndex = 49;
            // 
            // Echeance
            // 
            Echeance.HeaderText = "Echéance";
            Echeance.Name = "Echeance";
            // 
            // NPiece
            // 
            NPiece.HeaderText = "N° Piece";
            NPiece.Name = "NPiece";
            // 
            // NClient
            // 
            NClient.HeaderText = "N° Client";
            NClient.Name = "NClient";
            // 
            // ModeDeReglement
            // 
            ModeDeReglement.HeaderText = "Mode de règlement";
            ModeDeReglement.Name = "ModeDeReglement";
            // 
            // Pourcentage
            // 
            Pourcentage.HeaderText = "%";
            Pourcentage.Name = "Pourcentage";
            // 
            // EstPaye
            // 
            EstPaye.HeaderText = "Est payé";
            EstPaye.Name = "EstPaye";
            // 
            // Solde
            // 
            Solde.HeaderText = "Solde";
            Solde.Name = "Solde";
            // 
            // Reglement
            // 
            Reglement.HeaderText = "Règlement";
            Reglement.Name = "Reglement";
            // 
            // panelTotal
            // 
            panelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelTotal.BackColor = Color.FromArgb(84, 138, 178);
            panelTotal.Controls.Add(tableLayoutPanel4);
            panelTotal.Location = new Point(12, 544);
            panelTotal.Name = "panelTotal";
            panelTotal.Padding = new Padding(12);
            panelTotal.Size = new Size(526, 104);
            panelTotal.TabIndex = 52;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(labelValeurResteAImputer, 2, 1);
            tableLayoutPanel4.Controls.Add(labelResteAImputer, 2, 0);
            tableLayoutPanel4.Controls.Add(labelTotalImpute, 1, 0);
            tableLayoutPanel4.Controls.Add(labelTotalReglement, 0, 0);
            tableLayoutPanel4.Controls.Add(labelValeurTotalImpute, 1, 1);
            tableLayoutPanel4.Controls.Add(labelValeurTotalReglement, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(12, 12);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Size = new Size(502, 80);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // labelValeurResteAImputer
            // 
            labelValeurResteAImputer.AutoSize = true;
            labelValeurResteAImputer.Dock = DockStyle.Fill;
            labelValeurResteAImputer.Font = new Font("Segoe UI", 10F);
            labelValeurResteAImputer.ForeColor = Color.White;
            labelValeurResteAImputer.Location = new Point(337, 40);
            labelValeurResteAImputer.Name = "labelValeurResteAImputer";
            labelValeurResteAImputer.Size = new Size(162, 40);
            labelValeurResteAImputer.TabIndex = 7;
            labelValeurResteAImputer.Text = "0";
            labelValeurResteAImputer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelResteAImputer
            // 
            labelResteAImputer.AutoSize = true;
            labelResteAImputer.Dock = DockStyle.Fill;
            labelResteAImputer.Font = new Font("Segoe UI", 10F);
            labelResteAImputer.ForeColor = Color.White;
            labelResteAImputer.Location = new Point(337, 0);
            labelResteAImputer.Name = "labelResteAImputer";
            labelResteAImputer.Size = new Size(162, 40);
            labelResteAImputer.TabIndex = 6;
            labelResteAImputer.Text = "Reste à imputer";
            labelResteAImputer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalImpute
            // 
            labelTotalImpute.AutoSize = true;
            labelTotalImpute.Dock = DockStyle.Fill;
            labelTotalImpute.Font = new Font("Segoe UI", 10F);
            labelTotalImpute.ForeColor = Color.White;
            labelTotalImpute.Location = new Point(170, 0);
            labelTotalImpute.Name = "labelTotalImpute";
            labelTotalImpute.Size = new Size(161, 40);
            labelTotalImpute.TabIndex = 5;
            labelTotalImpute.Text = "Total imputé";
            labelTotalImpute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalReglement
            // 
            labelTotalReglement.AutoSize = true;
            labelTotalReglement.Dock = DockStyle.Fill;
            labelTotalReglement.Font = new Font("Segoe UI", 10F);
            labelTotalReglement.ForeColor = Color.White;
            labelTotalReglement.Location = new Point(3, 0);
            labelTotalReglement.Name = "labelTotalReglement";
            labelTotalReglement.Size = new Size(161, 40);
            labelTotalReglement.TabIndex = 4;
            labelTotalReglement.Text = "Total règlement";
            labelTotalReglement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValeurTotalImpute
            // 
            labelValeurTotalImpute.AutoSize = true;
            labelValeurTotalImpute.Dock = DockStyle.Fill;
            labelValeurTotalImpute.Font = new Font("Segoe UI", 10F);
            labelValeurTotalImpute.ForeColor = Color.White;
            labelValeurTotalImpute.Location = new Point(170, 40);
            labelValeurTotalImpute.Name = "labelValeurTotalImpute";
            labelValeurTotalImpute.Size = new Size(161, 40);
            labelValeurTotalImpute.TabIndex = 3;
            labelValeurTotalImpute.Text = "0";
            labelValeurTotalImpute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValeurTotalReglement
            // 
            labelValeurTotalReglement.AutoSize = true;
            labelValeurTotalReglement.Dock = DockStyle.Fill;
            labelValeurTotalReglement.Font = new Font("Segoe UI", 10F);
            labelValeurTotalReglement.ForeColor = Color.White;
            labelValeurTotalReglement.Location = new Point(3, 40);
            labelValeurTotalReglement.Name = "labelValeurTotalReglement";
            labelValeurTotalReglement.Size = new Size(161, 40);
            labelValeurTotalReglement.TabIndex = 0;
            labelValeurTotalReglement.Text = "0";
            labelValeurTotalReglement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonFermer
            // 
            buttonFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFermer.BackColor = Color.FromArgb(129, 166, 181);
            buttonFermer.Cursor = Cursors.Hand;
            buttonFermer.FlatAppearance.BorderSize = 0;
            buttonFermer.FlatStyle = FlatStyle.Flat;
            buttonFermer.Font = new Font("Segoe UI", 11F);
            buttonFermer.ForeColor = Color.White;
            buttonFermer.Location = new Point(716, 603);
            buttonFermer.Margin = new Padding(144, 3, 144, 3);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Padding = new Padding(8, 0, 0, 0);
            buttonFermer.Size = new Size(185, 45);
            buttonFermer.TabIndex = 53;
            buttonFermer.Text = "Fermer";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // buttonReglement
            // 
            buttonReglement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonReglement.BackColor = Color.FromArgb(84, 138, 178);
            buttonReglement.FlatAppearance.BorderSize = 0;
            buttonReglement.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 138, 178);
            buttonReglement.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 138, 178);
            buttonReglement.FlatStyle = FlatStyle.Flat;
            buttonReglement.Font = new Font("Segoe UI", 12F);
            buttonReglement.ForeColor = Color.White;
            buttonReglement.Location = new Point(12, 35);
            buttonReglement.Margin = new Padding(144, 3, 144, 3);
            buttonReglement.Name = "buttonReglement";
            buttonReglement.Padding = new Padding(8, 0, 0, 0);
            buttonReglement.Size = new Size(306, 45);
            buttonReglement.TabIndex = 54;
            buttonReglement.Text = "N° Pièce (règlement) :      1";
            buttonReglement.TextAlign = ContentAlignment.MiddleLeft;
            buttonReglement.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(904, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 63;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // VisualisationDUnReglement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(956, 665);
            Controls.Add(iconButtonFermer);
            Controls.Add(buttonReglement);
            Controls.Add(buttonFermer);
            Controls.Add(panelTotal);
            Controls.Add(dataGridView1);
            Name = "VisualisationDUnReglement";
            Text = "Visualisation d' un règlement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTotal.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Echeance;
        private DataGridViewTextBoxColumn NPiece;
        private DataGridViewTextBoxColumn NClient;
        private DataGridViewTextBoxColumn ModeDeReglement;
        private DataGridViewTextBoxColumn Pourcentage;
        private DataGridViewTextBoxColumn EstPaye;
        private DataGridViewTextBoxColumn Solde;
        private DataGridViewTextBoxColumn Reglement;
        private Panel panelTotal;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelValeurResteAImputer;
        private Label labelResteAImputer;
        private Label labelTotalImpute;
        private Label labelTotalReglement;
        private Label labelValeurTotalImpute;
        private Label labelValeurTotalReglement;
        private Button buttonFermer;
        private Button buttonReglement;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}