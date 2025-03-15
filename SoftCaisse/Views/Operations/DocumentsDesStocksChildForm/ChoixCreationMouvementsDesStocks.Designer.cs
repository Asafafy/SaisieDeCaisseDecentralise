using System.Drawing;
using System.Windows.Forms;




namespace Soft_Caisse.Views.Operations.DocumentsDesStocksChildForm
{
    partial class ChoixCreationMouvementsDesStocks
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
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            radioButtonMouvementDeSortie = new RadioButton();
            radioButtonMouvementDEntree = new RadioButton();
            btnOK = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 210);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(265, 15);
            label1.TabIndex = 1;
            label1.Text = "Quel type de mouvement voulez vous effectuer ?";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(radioButtonMouvementDeSortie, 0, 1);
            tableLayoutPanel1.Controls.Add(radioButtonMouvementDEntree, 0, 0);
            tableLayoutPanel1.Location = new Point(42, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(398, 81);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonMouvementDeSortie
            // 
            radioButtonMouvementDeSortie.AutoSize = true;
            radioButtonMouvementDeSortie.Location = new Point(3, 43);
            radioButtonMouvementDeSortie.Name = "radioButtonMouvementDeSortie";
            radioButtonMouvementDeSortie.Size = new Size(138, 19);
            radioButtonMouvementDeSortie.TabIndex = 1;
            radioButtonMouvementDeSortie.TabStop = true;
            radioButtonMouvementDeSortie.Text = "Mouvement de sortie";
            radioButtonMouvementDeSortie.UseVisualStyleBackColor = true;
            // 
            // radioButtonMouvementDEntree
            // 
            radioButtonMouvementDEntree.AutoSize = true;
            radioButtonMouvementDEntree.Location = new Point(3, 3);
            radioButtonMouvementDEntree.Name = "radioButtonMouvementDEntree";
            radioButtonMouvementDEntree.Size = new Size(136, 19);
            radioButtonMouvementDEntree.TabIndex = 0;
            radioButtonMouvementDEntree.TabStop = true;
            radioButtonMouvementDEntree.Text = "Mouvement d'entrée";
            radioButtonMouvementDEntree.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.BackColor = Color.FromArgb(129, 166, 181);
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 11F);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(308, 282);
            btnOK.Margin = new Padding(144, 3, 144, 3);
            btnOK.Name = "btnOK";
            btnOK.Padding = new Padding(8, 0, 0, 0);
            btnOK.Size = new Size(190, 45);
            btnOK.TabIndex = 29;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
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
            iconButtonFermer.Location = new Point(504, 3);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 53;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ChoixCreationMouvementsDesStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(550, 339);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel1);
            Controls.Add(btnOK);
            Name = "ChoixCreationMouvementsDesStocks";
            ShowIcon = false;
            ShowInTaskbar = false;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton radioButtonMouvementDeSortie;
        private RadioButton radioButtonMouvementDEntree;
        private Button btnOK;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}