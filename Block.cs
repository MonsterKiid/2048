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

        public Label getLabel()
        {
            return lblValeur;
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
                switch (value)
                {
                    case 0: this.BackColor = Color.FromArgb(238, 228, 218); break;
                    case 2: this.BackColor = ColorTranslator.FromHtml("#eee4da"); break;
                    case 4: this.BackColor = ColorTranslator.FromHtml("#ede0c8"); break;
                    case 8: case 16: this.BackColor = ColorTranslator.FromHtml("#f2b179"); break;
                    case 32: this.BackColor = ColorTranslator.FromHtml("#f67c5f"); break;
                    case 64: this.BackColor = ColorTranslator.FromHtml("#f65e3b"); break;
                    default: this.BackColor = ColorTranslator.FromHtml("#edcf72"); break;
                }
                if (value > 4) lblValeur.ForeColor = ColorTranslator.FromHtml("#f9f6f2");
                else lblValeur.ForeColor = ColorTranslator.FromHtml("#776e65");

                lblValeur.Location = new Point((this.Width - lblValeur.Width) / 2, (this.Height - lblValeur.Height) / 2);
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
