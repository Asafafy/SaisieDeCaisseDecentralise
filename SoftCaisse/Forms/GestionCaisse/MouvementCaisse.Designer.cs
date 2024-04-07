using System.Drawing;

namespace SoftCaisse.Forms.GestionCaisse
{
    partial class MouvementCaisse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Situation = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Fond = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableMouvement = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Afficher = new System.Windows.Forms.Button();
            this.listeCaisse = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMouvement)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Afficher);
            this.panel1.Controls.Add(this.listeCaisse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 551);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(828, 513);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 30);
            this.button5.TabIndex = 12;
            this.button5.Text = "Fermer";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(56, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 16);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Caisse";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tableMouvement);
            this.panel2.Location = new System.Drawing.Point(173, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 385);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Situation);
            this.panel4.Controls.Add(this.Total);
            this.panel4.Controls.Add(this.Fond);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(276, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(610, 64);
            this.panel4.TabIndex = 1;
            // 
            // Situation
            // 
            this.Situation.AutoSize = true;
            this.Situation.Location = new System.Drawing.Point(365, 32);
            this.Situation.Name = "Situation";
            this.Situation.Size = new System.Drawing.Size(0, 16);
            this.Situation.TabIndex = 9;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(203, 33);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 16);
            this.Total.TabIndex = 8;
            // 
            // Fond
            // 
            this.Fond.AutoSize = true;
            this.Fond.Location = new System.Drawing.Point(16, 33);
            this.Fond.Name = "Fond";
            this.Fond.Size = new System.Drawing.Size(0, 16);
            this.Fond.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // tableMouvement
            // 
            this.tableMouvement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableMouvement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableMouvement.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.tableMouvement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMouvement.Location = new System.Drawing.Point(3, 2);
            this.tableMouvement.Name = "tableMouvement";
            this.tableMouvement.RowHeadersVisible = false;
            this.tableMouvement.RowHeadersWidth = 51;
            this.tableMouvement.RowTemplate.Height = 24;
            this.tableMouvement.Size = new System.Drawing.Size(893, 280);
            this.tableMouvement.TabIndex = 0;
            this.tableMouvement.Paint += new System.Windows.Forms.PaintEventHandler(this.tableMouvement_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(12, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 385);
            this.panel3.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(3, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Tickets archivés";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ticket_archive);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Détails";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.details_click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Documents";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.document_state);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mouvements";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.mouvement_click);
            // 
            // Afficher
            // 
            this.Afficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Afficher.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Afficher.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Afficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afficher.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Afficher.Location = new System.Drawing.Point(838, 59);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(231, 33);
            this.Afficher.TabIndex = 8;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = false;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // listeCaisse
            // 
            this.listeCaisse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listeCaisse.FormattingEnabled = true;
            this.listeCaisse.Location = new System.Drawing.Point(128, 68);
            this.listeCaisse.Name = "listeCaisse";
            this.listeCaisse.Size = new System.Drawing.Size(334, 24);
            this.listeCaisse.TabIndex = 7;
            // 
            // MouvementCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 551);
            this.Controls.Add(this.panel1);
            this.Name = "MouvementCaisse";
            this.Text = "MouvementCaisse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMouvement)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableMouvement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Afficher;
        private System.Windows.Forms.ComboBox listeCaisse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Situation;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Fond;
    }
}