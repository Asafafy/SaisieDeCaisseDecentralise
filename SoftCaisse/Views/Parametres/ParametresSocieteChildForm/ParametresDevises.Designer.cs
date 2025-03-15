using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres.ParametresSociete
{
    partial class ParametresDevises
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
            Devise = new DataGridViewTextBoxColumn();
            CodeISO = new DataGridViewTextBoxColumn();
            CodeISONum = new DataGridViewTextBoxColumn();
            Cours = new DataGridViewTextBoxColumn();
            btnBilletage = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Devise, CodeISO, CodeISONum, Cours });
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
            dataGridView1.Location = new Point(13, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(821, 736);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Devise
            // 
            Devise.HeaderText = "Devise";
            Devise.Name = "Devise";
            // 
            // CodeISO
            // 
            CodeISO.HeaderText = "Code ISO";
            CodeISO.Name = "CodeISO";
            // 
            // CodeISONum
            // 
            CodeISONum.HeaderText = "Code ISO Num";
            CodeISONum.Name = "CodeISONum";
            // 
            // Cours
            // 
            Cours.HeaderText = "Cours";
            Cours.Name = "Cours";
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
            btnBilletage.Location = new Point(644, 799);
            btnBilletage.Margin = new Padding(144, 3, 144, 3);
            btnBilletage.Name = "btnBilletage";
            btnBilletage.Padding = new Padding(8, 0, 0, 0);
            btnBilletage.Size = new Size(190, 45);
            btnBilletage.TabIndex = 22;
            btnBilletage.Text = "Billetage";
            btnBilletage.UseVisualStyleBackColor = false;
            btnBilletage.Click += btnBilletage_Click;
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
            iconButtonFermer.Location = new Point(835, 5);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 42;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ParametresDevises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(884, 861);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnBilletage);
            Controls.Add(dataGridView1);
            Name = "ParametresDevises";
            ShowIcon = false;
            ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Devise;
        private DataGridViewTextBoxColumn CodeISO;
        private DataGridViewTextBoxColumn CodeISONum;
        private DataGridViewTextBoxColumn Cours;
        private Button btnSupprimer;
        private Button btnBilletage;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}