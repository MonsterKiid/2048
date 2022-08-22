namespace _2048
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
            this.bloc13 = new _2048.Block();
            this.bloc14 = new _2048.Block();
            this.bloc15 = new _2048.Block();
            this.bloc16 = new _2048.Block();
            this.bloc9 = new _2048.Block();
            this.bloc10 = new _2048.Block();
            this.bloc11 = new _2048.Block();
            this.bloc12 = new _2048.Block();
            this.bloc5 = new _2048.Block();
            this.bloc6 = new _2048.Block();
            this.bloc7 = new _2048.Block();
            this.bloc8 = new _2048.Block();
            this.bloc4 = new _2048.Block();
            this.bloc3 = new _2048.Block();
            this.bloc2 = new _2048.Block();
            this.bloc1 = new _2048.Block();
            this.lbl2048 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pnlGrille.Controls.Add(this.bloc13);
            this.pnlGrille.Controls.Add(this.bloc14);
            this.pnlGrille.Controls.Add(this.bloc15);
            this.pnlGrille.Controls.Add(this.bloc16);
            this.pnlGrille.Controls.Add(this.bloc9);
            this.pnlGrille.Controls.Add(this.bloc10);
            this.pnlGrille.Controls.Add(this.bloc11);
            this.pnlGrille.Controls.Add(this.bloc12);
            this.pnlGrille.Controls.Add(this.bloc5);
            this.pnlGrille.Controls.Add(this.bloc6);
            this.pnlGrille.Controls.Add(this.bloc7);
            this.pnlGrille.Controls.Add(this.bloc8);
            this.pnlGrille.Controls.Add(this.bloc4);
            this.pnlGrille.Controls.Add(this.bloc3);
            this.pnlGrille.Controls.Add(this.bloc2);
            this.pnlGrille.Controls.Add(this.bloc1);
            this.pnlGrille.Location = new System.Drawing.Point(0, 100);
            this.pnlGrille.Name = "pnlGrille";
            this.pnlGrille.Size = new System.Drawing.Size(480, 471);
            this.pnlGrille.TabIndex = 16;
            // 
            // bloc13
            // 
            this.bloc13.BackColor = System.Drawing.Color.DarkGray;
            this.bloc13.Location = new System.Drawing.Point(366, 363);
            this.bloc13.Moovable = false;
            this.bloc13.Name = "bloc13";
            this.bloc13.Size = new System.Drawing.Size(100, 100);
            this.bloc13.TabIndex = 15;
            this.bloc13.TabStop = false;
            this.bloc13.Tag = "15";
            this.bloc13.Valeur = 0;
            this.bloc13.X = 3;
            this.bloc13.Y = 3;
            // 
            // bloc14
            // 
            this.bloc14.BackColor = System.Drawing.Color.DarkGray;
            this.bloc14.Location = new System.Drawing.Point(249, 362);
            this.bloc14.Moovable = false;
            this.bloc14.Name = "bloc14";
            this.bloc14.Size = new System.Drawing.Size(100, 100);
            this.bloc14.TabIndex = 14;
            this.bloc14.TabStop = false;
            this.bloc14.Tag = "14";
            this.bloc14.Valeur = 0;
            this.bloc14.X = 2;
            this.bloc14.Y = 3;
            // 
            // bloc15
            // 
            this.bloc15.BackColor = System.Drawing.Color.DarkGray;
            this.bloc15.Location = new System.Drawing.Point(132, 362);
            this.bloc15.Moovable = false;
            this.bloc15.Name = "bloc15";
            this.bloc15.Size = new System.Drawing.Size(100, 100);
            this.bloc15.TabIndex = 13;
            this.bloc15.TabStop = false;
            this.bloc15.Tag = "13";
            this.bloc15.Valeur = 0;
            this.bloc15.X = 1;
            this.bloc15.Y = 3;
            // 
            // bloc16
            // 
            this.bloc16.BackColor = System.Drawing.Color.DarkGray;
            this.bloc16.Location = new System.Drawing.Point(15, 362);
            this.bloc16.Moovable = false;
            this.bloc16.Name = "bloc16";
            this.bloc16.Size = new System.Drawing.Size(100, 100);
            this.bloc16.TabIndex = 12;
            this.bloc16.TabStop = false;
            this.bloc16.Tag = "12";
            this.bloc16.Valeur = 0;
            this.bloc16.X = 0;
            this.bloc16.Y = 3;
            // 
            // bloc9
            // 
            this.bloc9.BackColor = System.Drawing.Color.DarkGray;
            this.bloc9.Location = new System.Drawing.Point(366, 245);
            this.bloc9.Moovable = false;
            this.bloc9.Name = "bloc9";
            this.bloc9.Size = new System.Drawing.Size(100, 100);
            this.bloc9.TabIndex = 11;
            this.bloc9.TabStop = false;
            this.bloc9.Tag = "11";
            this.bloc9.Valeur = 0;
            this.bloc9.X = 3;
            this.bloc9.Y = 2;
            // 
            // bloc10
            // 
            this.bloc10.BackColor = System.Drawing.Color.DarkGray;
            this.bloc10.Location = new System.Drawing.Point(249, 245);
            this.bloc10.Moovable = false;
            this.bloc10.Name = "bloc10";
            this.bloc10.Size = new System.Drawing.Size(100, 100);
            this.bloc10.TabIndex = 10;
            this.bloc10.TabStop = false;
            this.bloc10.Tag = "10";
            this.bloc10.Valeur = 0;
            this.bloc10.X = 2;
            this.bloc10.Y = 2;
            // 
            // bloc11
            // 
            this.bloc11.BackColor = System.Drawing.Color.DarkGray;
            this.bloc11.Location = new System.Drawing.Point(132, 245);
            this.bloc11.Moovable = false;
            this.bloc11.Name = "bloc11";
            this.bloc11.Size = new System.Drawing.Size(100, 100);
            this.bloc11.TabIndex = 9;
            this.bloc11.TabStop = false;
            this.bloc11.Tag = "9";
            this.bloc11.Valeur = 0;
            this.bloc11.X = 1;
            this.bloc11.Y = 2;
            // 
            // bloc12
            // 
            this.bloc12.BackColor = System.Drawing.Color.DarkGray;
            this.bloc12.Location = new System.Drawing.Point(15, 245);
            this.bloc12.Moovable = false;
            this.bloc12.Name = "bloc12";
            this.bloc12.Size = new System.Drawing.Size(100, 100);
            this.bloc12.TabIndex = 8;
            this.bloc12.TabStop = false;
            this.bloc12.Tag = "8";
            this.bloc12.Valeur = 0;
            this.bloc12.X = 0;
            this.bloc12.Y = 2;
            // 
            // bloc5
            // 
            this.bloc5.BackColor = System.Drawing.Color.DarkGray;
            this.bloc5.Location = new System.Drawing.Point(366, 128);
            this.bloc5.Moovable = false;
            this.bloc5.Name = "bloc5";
            this.bloc5.Size = new System.Drawing.Size(100, 100);
            this.bloc5.TabIndex = 7;
            this.bloc5.TabStop = false;
            this.bloc5.Tag = "7";
            this.bloc5.Valeur = 0;
            this.bloc5.X = 3;
            this.bloc5.Y = 1;
            // 
            // bloc6
            // 
            this.bloc6.BackColor = System.Drawing.Color.DarkGray;
            this.bloc6.Location = new System.Drawing.Point(249, 128);
            this.bloc6.Moovable = false;
            this.bloc6.Name = "bloc6";
            this.bloc6.Size = new System.Drawing.Size(100, 100);
            this.bloc6.TabIndex = 6;
            this.bloc6.TabStop = false;
            this.bloc6.Tag = "6";
            this.bloc6.Valeur = 0;
            this.bloc6.X = 2;
            this.bloc6.Y = 1;
            // 
            // bloc7
            // 
            this.bloc7.BackColor = System.Drawing.Color.DarkGray;
            this.bloc7.Location = new System.Drawing.Point(132, 128);
            this.bloc7.Moovable = false;
            this.bloc7.Name = "bloc7";
            this.bloc7.Size = new System.Drawing.Size(100, 100);
            this.bloc7.TabIndex = 5;
            this.bloc7.TabStop = false;
            this.bloc7.Tag = "5";
            this.bloc7.Valeur = 0;
            this.bloc7.X = 1;
            this.bloc7.Y = 1;
            // 
            // bloc8
            // 
            this.bloc8.BackColor = System.Drawing.Color.DarkGray;
            this.bloc8.Location = new System.Drawing.Point(15, 128);
            this.bloc8.Moovable = false;
            this.bloc8.Name = "bloc8";
            this.bloc8.Size = new System.Drawing.Size(100, 100);
            this.bloc8.TabIndex = 4;
            this.bloc8.TabStop = false;
            this.bloc8.Tag = "4";
            this.bloc8.Valeur = 0;
            this.bloc8.X = 0;
            this.bloc8.Y = 1;
            // 
            // bloc4
            // 
            this.bloc4.BackColor = System.Drawing.Color.DarkGray;
            this.bloc4.Location = new System.Drawing.Point(366, 11);
            this.bloc4.Moovable = false;
            this.bloc4.Name = "bloc4";
            this.bloc4.Size = new System.Drawing.Size(100, 100);
            this.bloc4.TabIndex = 3;
            this.bloc4.TabStop = false;
            this.bloc4.Tag = "3";
            this.bloc4.Valeur = 0;
            this.bloc4.X = 3;
            this.bloc4.Y = 0;
            // 
            // bloc3
            // 
            this.bloc3.BackColor = System.Drawing.Color.DarkGray;
            this.bloc3.Location = new System.Drawing.Point(249, 11);
            this.bloc3.Moovable = false;
            this.bloc3.Name = "bloc3";
            this.bloc3.Size = new System.Drawing.Size(100, 100);
            this.bloc3.TabIndex = 2;
            this.bloc3.TabStop = false;
            this.bloc3.Tag = "2";
            this.bloc3.Valeur = 0;
            this.bloc3.X = 2;
            this.bloc3.Y = 0;
            // 
            // bloc2
            // 
            this.bloc2.BackColor = System.Drawing.Color.DarkGray;
            this.bloc2.Location = new System.Drawing.Point(132, 11);
            this.bloc2.Moovable = false;
            this.bloc2.Name = "bloc2";
            this.bloc2.Size = new System.Drawing.Size(100, 100);
            this.bloc2.TabIndex = 1;
            this.bloc2.TabStop = false;
            this.bloc2.Tag = "1";
            this.bloc2.Valeur = 0;
            this.bloc2.X = 1;
            this.bloc2.Y = 0;
            // 
            // bloc1
            // 
            this.bloc1.BackColor = System.Drawing.Color.DarkGray;
            this.bloc1.Location = new System.Drawing.Point(15, 11);
            this.bloc1.Moovable = false;
            this.bloc1.Name = "bloc1";
            this.bloc1.Size = new System.Drawing.Size(100, 100);
            this.bloc1.TabIndex = 0;
            this.bloc1.TabStop = false;
            this.bloc1.Tag = "0";
            this.bloc1.Valeur = 0;
            this.bloc1.X = 0;
            this.bloc1.Y = 0;
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

        private Block bloc1;
        private Block bloc2;
        private Block bloc3;
        private Block bloc4;
        private Block bloc5;
        private Block bloc6;
        private Block bloc7;
        private Block bloc8;
        private Block bloc9;
        private Block bloc10;
        private Block bloc11;
        private Block bloc12;
        private Block bloc13;
        private Block bloc14;
        private Block bloc15;
        private Block bloc16;
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

