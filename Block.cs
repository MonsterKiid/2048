using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Block : UserControl
    {
        private int valeur = 0;
        private bool moovable = false;
        public Block()
        {
            InitializeComponent();
            lblValeur.Text = valeur.ToString();
        }
        public int Valeur
        {
            get
            {
                return int.Parse(lblValeur.Text);
            }
            set
            {
                if (value == 0)
                {
                    lblValeur.Visible = false;
                    this.Moovable = false;
                } else
                {
                    lblValeur.Visible = true;
                    this.Moovable = true;
                }
                lblValeur.Text = value.ToString();
                lblValeur.Location = new Point((this.Width - lblValeur.Width) / 2, (this.Height - lblValeur.Height) / 2);
                frmPartie.ColorBlockByValue(this, value);
            }
        }

        public bool Moovable
        {
            get
            {
                return moovable;
            }
            set
            {
                
                moovable = value;
            }
        }

        
    }
}
