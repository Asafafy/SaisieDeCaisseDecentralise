using System.Drawing;
using System.Windows.Forms;










namespace Soft_Caisse.Views.Operations
{
    partial class FermetureDeCaisse
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
            checkBoxRemettreAZero = new CheckBox();
            label1 = new Label();
            panel1 = new Panel();
            buttonCaisse = new Button();
            buttonOK = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxRemettreAZero
            // 
            checkBoxRemettreAZero.AutoSize = true;
            checkBoxRemettreAZero.Location = new Point(17, 155);
            checkBoxRemettreAZero.Name = "checkBoxRemettreAZero";
            checkBoxRemettreAZero.Size = new Size(205, 19);
            checkBoxRemettreAZero.TabIndex = 26;
            checkBoxRemettreAZero.Text = "Remettre la valeur de caisse à zéro";
            checkBoxRemettreAZero.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 123);
            label1.Name = "label1";
            label1.Size = new Size(361, 15);
            label1.TabIndex = 27;
            label1.Text = "Veuillez préciser si vous souhaitez remettre la valeur de caisse à zéro";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonCaisse);
            panel1.Controls.Add(checkBoxRemettreAZero);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 195);
            panel1.TabIndex = 28;
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
            buttonCaisse.Location = new Point(17, 20);
            buttonCaisse.Margin = new Padding(144, 3, 144, 3);
            buttonCaisse.Name = "buttonCaisse";
            buttonCaisse.Padding = new Padding(8, 0, 0, 0);
            buttonCaisse.Size = new Size(306, 45);
            buttonCaisse.TabIndex = 37;
            buttonCaisse.Text = "Caisse : Annexe BIJOU SA";
            buttonCaisse.TextAlign = ContentAlignment.MiddleLeft;
            buttonCaisse.UseVisualStyleBackColor = false;
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
            buttonOK.Location = new Point(229, 261);
            buttonOK.Margin = new Padding(144, 3, 144, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Padding = new Padding(8, 0, 0, 0);
            buttonOK.Size = new Size(185, 45);
            buttonOK.TabIndex = 29;
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
            iconButtonFermer.Location = new Point(418, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 69;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // FermetureDeCaisse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(466, 318);
            Controls.Add(iconButtonFermer);
            Controls.Add(buttonOK);
            Controls.Add(panel1);
            Name = "FermetureDeCaisse";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Fermeture de caisse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBoxRemettreAZero;
        private Label label1;
        private Panel panel1;
        private Button buttonCaisse;
        private Button buttonOK;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}