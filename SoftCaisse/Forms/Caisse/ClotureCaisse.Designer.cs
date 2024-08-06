namespace SoftCaisse.Forms.ClotureCaisse
{
    partial class ClotureCaisse
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
            this.DateCloture = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.kryptonComboBox5 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonComboBox3 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // DateCloture
            // 
            this.DateCloture.Location = new System.Drawing.Point(116, 13);
            this.DateCloture.Name = "DateCloture";
            this.DateCloture.Size = new System.Drawing.Size(178, 25);
            this.DateCloture.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caisse de";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 178;
            this.kryptonComboBox1.Location = new System.Drawing.Point(116, 58);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(178, 25);
            this.kryptonComboBox1.TabIndex = 4;
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropDownWidth = 178;
            this.kryptonComboBox2.Location = new System.Drawing.Point(417, 58);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(178, 25);
            this.kryptonComboBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "à";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(22, 115);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(267, 24);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Paramètre de génération des factures";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Regroupements tickets";
            // 
            // kryptonComboBox5
            // 
            this.kryptonComboBox5.DropDownWidth = 176;
            this.kryptonComboBox5.Items.AddRange(new object[] {
            "Par jour",
            "Par semaine",
            "Par mois"});
            this.kryptonComboBox5.Location = new System.Drawing.Point(417, 215);
            this.kryptonComboBox5.Name = "kryptonComboBox5";
            this.kryptonComboBox5.Size = new System.Drawing.Size(176, 25);
            this.kryptonComboBox5.TabIndex = 14;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(498, 280);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(97, 37);
            this.kryptonButton1.TabIndex = 23;
            this.kryptonButton1.Values.Text = "OK";
            this.kryptonButton1.Click += new System.EventHandler(this.cloturer_caisse);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Souche";
            // 
            // kryptonComboBox3
            // 
            this.kryptonComboBox3.DropDownWidth = 176;
            this.kryptonComboBox3.Location = new System.Drawing.Point(419, 163);
            this.kryptonComboBox3.Name = "kryptonComboBox3";
            this.kryptonComboBox3.Size = new System.Drawing.Size(176, 25);
            this.kryptonComboBox3.TabIndex = 12;
            // 
            // ClotureCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 359);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonComboBox5);
            this.Controls.Add(this.kryptonComboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonComboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateCloture);
            this.Controls.Add(this.label1);
            this.Name = "ClotureCaisse";
            this.Text = "ClotureCaisse";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateCloture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox3;
    }
}