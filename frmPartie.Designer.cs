﻿namespace _2048
{
    partial class frmPartie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGrille = new System.Windows.Forms.Panel();
            this.block16 = new _2048.Block();
            this.block15 = new _2048.Block();
            this.block14 = new _2048.Block();
            this.block13 = new _2048.Block();
            this.block12 = new _2048.Block();
            this.block11 = new _2048.Block();
            this.block10 = new _2048.Block();
            this.block9 = new _2048.Block();
            this.block8 = new _2048.Block();
            this.block7 = new _2048.Block();
            this.block6 = new _2048.Block();
            this.block5 = new _2048.Block();
            this.block4 = new _2048.Block();
            this.block3 = new _2048.Block();
            this.block2 = new _2048.Block();
            this.block1 = new _2048.Block();
            this.lbl2048 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMeilleur = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGrille.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrille
            // 
            this.pnlGrille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.pnlGrille.Controls.Add(this.block16);
            this.pnlGrille.Controls.Add(this.block15);
            this.pnlGrille.Controls.Add(this.block14);
            this.pnlGrille.Controls.Add(this.block13);
            this.pnlGrille.Controls.Add(this.block12);
            this.pnlGrille.Controls.Add(this.block11);
            this.pnlGrille.Controls.Add(this.block10);
            this.pnlGrille.Controls.Add(this.block9);
            this.pnlGrille.Controls.Add(this.block8);
            this.pnlGrille.Controls.Add(this.block7);
            this.pnlGrille.Controls.Add(this.block6);
            this.pnlGrille.Controls.Add(this.block5);
            this.pnlGrille.Controls.Add(this.block4);
            this.pnlGrille.Controls.Add(this.block3);
            this.pnlGrille.Controls.Add(this.block2);
            this.pnlGrille.Controls.Add(this.block1);
            this.pnlGrille.Location = new System.Drawing.Point(0, 100);
            this.pnlGrille.Name = "pnlGrille";
            this.pnlGrille.Size = new System.Drawing.Size(480, 471);
            this.pnlGrille.TabIndex = 16;
            // 
            // block16
            // 
            this.block16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(177)))), ((int)(((byte)(121)))));
            this.block16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.block16.Location = new System.Drawing.Point(366, 363);
            this.block16.Moovable = true;
            this.block16.Name = "block16";
            this.block16.Size = new System.Drawing.Size(100, 100);
            this.block16.TabIndex = 15;
            this.block16.TabStop = false;
            this.block16.Tag = "15";
            this.block16.Valeur = 8;
            // 
            // block15
            // 
            this.block15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block15.Location = new System.Drawing.Point(249, 362);
            this.block15.Moovable = false;
            this.block15.Name = "block15";
            this.block15.Size = new System.Drawing.Size(100, 100);
            this.block15.TabIndex = 14;
            this.block15.TabStop = false;
            this.block15.Tag = "14";
            this.block15.Valeur = 0;
            // 
            // block14
            // 
            this.block14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block14.Location = new System.Drawing.Point(132, 362);
            this.block14.Moovable = false;
            this.block14.Name = "block14";
            this.block14.Size = new System.Drawing.Size(100, 100);
            this.block14.TabIndex = 13;
            this.block14.TabStop = false;
            this.block14.Tag = "13";
            this.block14.Valeur = 0;
            // 
            // block13
            // 
            this.block13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block13.Location = new System.Drawing.Point(15, 362);
            this.block13.Moovable = false;
            this.block13.Name = "block13";
            this.block13.Size = new System.Drawing.Size(100, 100);
            this.block13.TabIndex = 12;
            this.block13.TabStop = false;
            this.block13.Tag = "12";
            this.block13.Valeur = 0;
            // 
            // block12
            // 
            this.block12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block12.Location = new System.Drawing.Point(366, 245);
            this.block12.Moovable = false;
            this.block12.Name = "block12";
            this.block12.Size = new System.Drawing.Size(100, 100);
            this.block12.TabIndex = 11;
            this.block12.TabStop = false;
            this.block12.Tag = "11";
            this.block12.Valeur = 0;
            // 
            // block11
            // 
            this.block11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block11.Location = new System.Drawing.Point(249, 245);
            this.block11.Moovable = false;
            this.block11.Name = "block11";
            this.block11.Size = new System.Drawing.Size(100, 100);
            this.block11.TabIndex = 10;
            this.block11.TabStop = false;
            this.block11.Tag = "10";
            this.block11.Valeur = 0;
            // 
            // block10
            // 
            this.block10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block10.Location = new System.Drawing.Point(132, 245);
            this.block10.Moovable = false;
            this.block10.Name = "block10";
            this.block10.Size = new System.Drawing.Size(100, 100);
            this.block10.TabIndex = 9;
            this.block10.TabStop = false;
            this.block10.Tag = "9";
            this.block10.Valeur = 0;
            // 
            // block9
            // 
            this.block9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block9.Location = new System.Drawing.Point(15, 245);
            this.block9.Moovable = false;
            this.block9.Name = "block9";
            this.block9.Size = new System.Drawing.Size(100, 100);
            this.block9.TabIndex = 8;
            this.block9.TabStop = false;
            this.block9.Tag = "8";
            this.block9.Valeur = 0;
            // 
            // block8
            // 
            this.block8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block8.Location = new System.Drawing.Point(366, 128);
            this.block8.Moovable = false;
            this.block8.Name = "block8";
            this.block8.Size = new System.Drawing.Size(100, 100);
            this.block8.TabIndex = 7;
            this.block8.TabStop = false;
            this.block8.Tag = "7";
            this.block8.Valeur = 0;
            // 
            // block7
            // 
            this.block7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block7.Location = new System.Drawing.Point(249, 128);
            this.block7.Moovable = false;
            this.block7.Name = "block7";
            this.block7.Size = new System.Drawing.Size(100, 100);
            this.block7.TabIndex = 6;
            this.block7.TabStop = false;
            this.block7.Tag = "6";
            this.block7.Valeur = 0;
            // 
            // block6
            // 
            this.block6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block6.Location = new System.Drawing.Point(132, 128);
            this.block6.Moovable = false;
            this.block6.Name = "block6";
            this.block6.Size = new System.Drawing.Size(100, 100);
            this.block6.TabIndex = 5;
            this.block6.TabStop = false;
            this.block6.Tag = "5";
            this.block6.Valeur = 0;
            // 
            // block5
            // 
            this.block5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block5.Location = new System.Drawing.Point(15, 128);
            this.block5.Moovable = false;
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(100, 100);
            this.block5.TabIndex = 4;
            this.block5.TabStop = false;
            this.block5.Tag = "4";
            this.block5.Valeur = 0;
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block4.Location = new System.Drawing.Point(366, 11);
            this.block4.Moovable = false;
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(100, 100);
            this.block4.TabIndex = 3;
            this.block4.TabStop = false;
            this.block4.Tag = "3";
            this.block4.Valeur = 0;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block3.Location = new System.Drawing.Point(249, 11);
            this.block3.Moovable = false;
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(100, 100);
            this.block3.TabIndex = 2;
            this.block3.TabStop = false;
            this.block3.Tag = "2";
            this.block3.Valeur = 0;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block2.Location = new System.Drawing.Point(132, 11);
            this.block2.Moovable = false;
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(100, 100);
            this.block2.TabIndex = 1;
            this.block2.TabStop = false;
            this.block2.Tag = "1";
            this.block2.Valeur = 0;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block1.Location = new System.Drawing.Point(15, 11);
            this.block1.Moovable = false;
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(100, 100);
            this.block1.TabIndex = 0;
            this.block1.TabStop = false;
            this.block1.Tag = "0";
            this.block1.Valeur = 0;
            // 
            // lbl2048
            // 
            this.lbl2048.AutoSize = true;
            this.lbl2048.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.lbl2048.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lbl2048.Location = new System.Drawing.Point(4, 22);
            this.lbl2048.Name = "lbl2048";
            this.lbl2048.Size = new System.Drawing.Size(147, 63);
            this.lbl2048.TabIndex = 17;
            this.lbl2048.Text = "2048";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Location = new System.Drawing.Point(190, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 61);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.lblScore.Location = new System.Drawing.Point(21, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 20);
            this.lblScore.TabIndex = 18;
            this.lblScore.Text = "SCORE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblMeilleur);
            this.panel2.Location = new System.Drawing.Point(300, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 61);
            this.panel2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "0";
            // 
            // lblMeilleur
            // 
            this.lblMeilleur.AutoSize = true;
            this.lblMeilleur.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeilleur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.lblMeilleur.Location = new System.Drawing.Point(14, 10);
            this.lblMeilleur.Name = "lblMeilleur";
            this.lblMeilleur.Size = new System.Drawing.Size(73, 20);
            this.lblMeilleur.TabIndex = 18;
            this.lblMeilleur.Text = "MEILLEUR";
            this.lblMeilleur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2048.Properties.Resources.retry;
            this.pictureBox1.Location = new System.Drawing.Point(414, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl2048);
            this.Controls.Add(this.pnlGrille);
            this.Name = "frmPartie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPartie_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmPartie_PreviewKeyDown);
            this.pnlGrille.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Block block1;
        private Block block2;
        private Block block3;
        private Block block4;
        private Block block8;
        private Block block7;
        private Block block6;
        private Block block5;
        private Block block12;
        private Block block11;
        private Block block10;
        private Block block9;
        private Block block16;
        private Block block15;
        private Block block14;
        private Block block13;
        private System.Windows.Forms.Panel pnlGrille;
        private System.Windows.Forms.Label lbl2048;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMeilleur;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
