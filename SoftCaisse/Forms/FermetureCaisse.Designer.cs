namespace SoftCaisse.Forms.FermetureCaisse
{
    partial class FermetureCaisse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fermer_caisse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caisse : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Veuillez préciser si vous souhaitiez mettre la valeur de caisse à zéro";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(85, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(240, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Remettre la valeur de caisse à zéro";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fermer_caisse
            // 
            this.fermer_caisse.Location = new System.Drawing.Point(358, 257);
            this.fermer_caisse.Name = "fermer_caisse";
            this.fermer_caisse.Size = new System.Drawing.Size(131, 38);
            this.fermer_caisse.TabIndex = 4;
            this.fermer_caisse.Values.Text = "OK";
            this.fermer_caisse.Click += new System.EventHandler(this.fermeture_caisse);
            // 
            // FermetureCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 318);
            this.Controls.Add(this.fermer_caisse);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FermetureCaisse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FermetureCaisse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton fermer_caisse;
    }
}