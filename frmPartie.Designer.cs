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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartie));
            this.pnlGrille = new System.Windows.Forms.Panel();
            this.lbl2048 = new System.Windows.Forms.Label();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitreScore = new System.Windows.Forms.Label();
            this.pnlRecord = new System.Windows.Forms.Panel();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblTitreRecord = new System.Windows.Forms.Label();
            this.pbxRetry = new System.Windows.Forms.PictureBox();
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
            this.pnlGrille.SuspendLayout();
            this.pnlScore.SuspendLayout();
            this.pnlRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRetry)).BeginInit();
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
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.pnlScore.Controls.Add(this.lblScore);
            this.pnlScore.Controls.Add(this.lblTitreScore);
            this.pnlScore.Location = new System.Drawing.Point(190, 22);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(97, 61);
            this.pnlScore.TabIndex = 16;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(37, 32);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(22, 24);
            this.lblScore.TabIndex = 19;
            this.lblScore.Text = "0";
            // 
            // lblTitreScore
            // 
            this.lblTitreScore.AutoSize = true;
            this.lblTitreScore.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.lblTitreScore.Location = new System.Drawing.Point(21, 10);
            this.lblTitreScore.Name = "lblTitreScore";
            this.lblTitreScore.Size = new System.Drawing.Size(55, 20);
            this.lblTitreScore.TabIndex = 18;
            this.lblTitreScore.Text = "SCORE";
            // 
            // pnlRecord
            // 
            this.pnlRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.pnlRecord.Controls.Add(this.lblRecord);
            this.pnlRecord.Controls.Add(this.lblTitreRecord);
            this.pnlRecord.Location = new System.Drawing.Point(300, 22);
            this.pnlRecord.Name = "pnlRecord";
            this.pnlRecord.Size = new System.Drawing.Size(97, 61);
            this.pnlRecord.TabIndex = 20;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(37, 32);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(22, 24);
            this.lblRecord.TabIndex = 19;
            this.lblRecord.Text = "0";
            // 
            // lblTitreRecord
            // 
            this.lblTitreRecord.AutoSize = true;
            this.lblTitreRecord.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.lblTitreRecord.Location = new System.Drawing.Point(14, 10);
            this.lblTitreRecord.Name = "lblTitreRecord";
            this.lblTitreRecord.Size = new System.Drawing.Size(73, 20);
            this.lblTitreRecord.TabIndex = 18;
            this.lblTitreRecord.Text = "MEILLEUR";
            this.lblTitreRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxRetry
            // 
            this.pbxRetry.Image = global::_2048.Properties.Resources.retry;
            this.pbxRetry.Location = new System.Drawing.Point(414, 28);
            this.pbxRetry.Name = "pbxRetry";
            this.pbxRetry.Size = new System.Drawing.Size(54, 50);
            this.pbxRetry.TabIndex = 21;
            this.pbxRetry.TabStop = false;
            this.pbxRetry.Click += new System.EventHandler(this.pbxRetry_Click);
            // 
            // block16
            // 
            this.block16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.block16.Location = new System.Drawing.Point(366, 363);
            this.block16.Moovable = false;
            this.block16.Name = "block16";
            this.block16.Size = new System.Drawing.Size(100, 100);
            this.block16.TabIndex = 15;
            this.block16.TabStop = false;
            this.block16.Tag = "15";
            this.block16.Valeur = 0;
            // 
            // block15
            // 
            this.block15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.block15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
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
            this.block1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.block1.Location = new System.Drawing.Point(15, 11);
            this.block1.Moovable = false;
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(100, 100);
            this.block1.TabIndex = 0;
            this.block1.TabStop = false;
            this.block1.Tag = "0";
            this.block1.Valeur = 0;
            // 
            // frmPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 571);
            this.Controls.Add(this.pbxRetry);
            this.Controls.Add(this.pnlRecord);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.lbl2048);
            this.Controls.Add(this.pnlGrille);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPartie";
            this.Text = "Le jeu du 2048";
            this.Load += new System.EventHandler(this.frmPartie_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmPartie_PreviewKeyDown);
            this.pnlGrille.ResumeLayout(false);
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.pnlRecord.ResumeLayout(false);
            this.pnlRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRetry)).EndInit();
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
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTitreScore;
        private System.Windows.Forms.Panel pnlRecord;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblTitreRecord;
        private System.Windows.Forms.PictureBox pbxRetry;
    }
}
