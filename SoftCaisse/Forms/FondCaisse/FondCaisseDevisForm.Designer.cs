namespace SoftCaisse.Forms.FondCaisse
{
    partial class FondCaisseDevisForm
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
            this.GridViewFondCaisse = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMarq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SauvegardeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFondCaisse)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewFondCaisse
            // 
            this.GridViewFondCaisse.AllowUserToAddRows = false;
            this.GridViewFondCaisse.AllowUserToDeleteRows = false;
            this.GridViewFondCaisse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewFondCaisse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewFondCaisse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewFondCaisse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intitule,
            this.Valeur,
            this.cbMarq});
            this.GridViewFondCaisse.Location = new System.Drawing.Point(12, 12);
            this.GridViewFondCaisse.Name = "GridViewFondCaisse";
            this.GridViewFondCaisse.RowHeadersVisible = false;
            this.GridViewFondCaisse.RowHeadersWidth = 51;
            this.GridViewFondCaisse.RowTemplate.Height = 24;
            this.GridViewFondCaisse.Size = new System.Drawing.Size(594, 372);
            this.GridViewFondCaisse.TabIndex = 0;
            // 
            // Intitule
            // 
            this.Intitule.HeaderText = "Intitule";
            this.Intitule.MinimumWidth = 6;
            this.Intitule.Name = "Intitule";
            // 
            // Valeur
            // 
            this.Valeur.HeaderText = "Valeur";
            this.Valeur.MinimumWidth = 6;
            this.Valeur.Name = "Valeur";
            // 
            // cbMarq
            // 
            this.cbMarq.HeaderText = "cbMarq";
            this.cbMarq.MinimumWidth = 6;
            this.cbMarq.Name = "cbMarq";
            this.cbMarq.Visible = false;
            // 
            // SauvegardeButton
            // 
            this.SauvegardeButton.Location = new System.Drawing.Point(469, 470);
            this.SauvegardeButton.Name = "SauvegardeButton";
            this.SauvegardeButton.Size = new System.Drawing.Size(137, 48);
            this.SauvegardeButton.TabIndex = 1;
            this.SauvegardeButton.Values.Text = "Sauvegarde";
            this.SauvegardeButton.Click += new System.EventHandler(this.SauvegardeButton_Click);
            // 
            // FondCaisseDevisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 530);
            this.Controls.Add(this.SauvegardeButton);
            this.Controls.Add(this.GridViewFondCaisse);
            this.Name = "FondCaisseDevisForm";
            this.Text = "FondCaisseDevisForm";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFondCaisse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView GridViewFondCaisse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SauvegardeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbMarq;
    }
}