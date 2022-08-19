namespace _2048
{
    partial class Bloc
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValeur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeur.Location = new System.Drawing.Point(27, 43);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(46, 16);
            this.lblValeur.TabIndex = 0;
            this.lblValeur.Text = "Valeur";
            this.lblValeur.Visible = false;
            // 
            // Bloc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.lblValeur);
            this.Name = "Bloc";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValeur;
    }
}
