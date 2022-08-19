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
    public partial class Form1 : Form
    {

        List<int> firstColumn = new List<int> { 0, 4, 8, 12 };
        List<int> secondColumn = new List<int> { 1, 5, 9, 13 };
        List<int> thirdColumn = new List<int> { 2, 6, 10, 14 };
        List<int> fourthColumn = new List<int> { 3, 7, 11, 15 };

        List<int> firstLine = new List<int> { 0, 1, 2, 3 };
        List<int> secondLine = new List<int> { 4, 5, 6, 7 };
        List<int> thirdLine = new List<int> { 8, 9, 10, 11 };
        List<int> fourthLine = new List<int> { 12, 13, 14, 15 };

        public Form1()
        {
            InitializeComponent();
        }

        public Bloc getBlockByTag(int tag)
        {
            foreach (Bloc bloc in pnlGrille.Controls.OfType<Bloc>())
            {
                if (int.Parse(bloc.Tag.ToString()) == tag)
                {
                    return bloc;
                }
            }
            return null;
        }

        public void mooveUp(Bloc bloc)
        {
            if (bloc.Moovable)
            {
                int tour = 0;
                int tag = int.Parse(bloc.Tag.ToString());
                while (!firstLine.Contains(tag) && !getPreviousBlock("vertical", getBlockByTag(tag)).Moovable)
                {
                    tag-=4;
                    tour++;
                }
                Bloc newBlock = getBlockByTag(tag);
                newBlock.Moovable = true;
                newBlock.Valeur = bloc.Valeur;
                ColorBlockByValue(newBlock, newBlock.Valeur);
                Bloc previousBlock = getPreviousBlock("vertical", newBlock);
                if (newBlock.Valeur == previousBlock.Valeur && previousBlock != newBlock)
                {
                    ColorBlockByValue(previousBlock, previousBlock.Valeur * 2);
                    previousBlock.Valeur *= 2;
                    newBlock.Moovable = false;
                    newBlock.Valeur = 0;
                    newBlock.BackColor = Color.DarkGray;
                }
                if(tour>0)
                {
                    bloc.Moovable = false;
                    bloc.Valeur = 0;
                    bloc.BackColor = Color.DarkGray;
                }
            }
        }

        public void mooveDown(Bloc bloc)
        {
            if (bloc.Moovable)
            {
                int tour = 0;
                int tag = int.Parse(bloc.Tag.ToString());
                while (!fourthLine.Contains(tag) && !getNextBlock("vertical", getBlockByTag(tag)).Moovable)
                {
                    tag += 4;
                    tour++;
                }
                Bloc newBlock = getBlockByTag(tag);
                newBlock.Moovable = true;
                newBlock.Valeur = bloc.Valeur;
                ColorBlockByValue(newBlock, newBlock.Valeur);
                Bloc nextBlock = getNextBlock("vertical", newBlock);
                if (newBlock.Valeur == nextBlock.Valeur && newBlock != nextBlock)
                {
                    ColorBlockByValue(nextBlock, nextBlock.Valeur * 2);
                    nextBlock.Valeur *= 2;
                    newBlock.Moovable = false;
                    newBlock.Valeur = 0;
                    newBlock.BackColor = Color.DarkGray;
                }
                if(tour>0)
                {
                    bloc.Moovable = false;
                    bloc.Valeur = 0;
                    bloc.BackColor = Color.DarkGray;
                }
            }
        }
        public void mooveLeft(Bloc bloc)
        {
            if (bloc.Moovable)
            {
                int tour = 0;
                int tag = int.Parse(bloc.Tag.ToString());
                while (!firstColumn.Contains(tag) && !getPreviousBlock("horizontal", getBlockByTag(tag)).Moovable)
                {
                    tag--;
                    tour++;
                }
                Bloc newBlock = getBlockByTag(tag);
                newBlock.Moovable = true;
                newBlock.Valeur = bloc.Valeur;
                ColorBlockByValue(newBlock, newBlock.Valeur);

                Bloc previousBlock = getPreviousBlock("horizontal", newBlock);
                //MessageBox.Show("BLOC " + newBlock.Name + " (Valeur: " + newBlock.Valeur + ")\n\nLe previous block est: " + previousBlock.Name + "\nValeur:" + previousBlock.Valeur);
                if (newBlock.Valeur == previousBlock.Valeur && previousBlock != newBlock)
                {
                    ColorBlockByValue(previousBlock, previousBlock.Valeur * 2);
                    previousBlock.Valeur *= 2;
                    newBlock.Moovable = false;
                    newBlock.Valeur = 0;
                    newBlock.BackColor = Color.DarkGray;

                }
                if(tour>0)
                {
                    bloc.Moovable = false;
                    bloc.Valeur = 0;
                    bloc.BackColor = Color.DarkGray;
                }
            }
        }

        public void mooveRight(Bloc bloc)
        {
            if (bloc.Moovable)
            {
                int tour = 0;
                int tag = int.Parse(bloc.Tag.ToString());
                while (!fourthColumn.Contains(tag) && !getNextBlock("horizontal", getBlockByTag(tag)).Moovable)
                {    
                    tag++;
                    tour++;
                }
                Bloc newBlock = getBlockByTag(tag);
                newBlock.Moovable = true;
                newBlock.Valeur = bloc.Valeur;
                ColorBlockByValue(newBlock, newBlock.Valeur);
                Bloc nextBlock = getNextBlock("horizontal", newBlock);
                if (newBlock.Valeur == nextBlock.Valeur && newBlock != nextBlock)
                {
                    ColorBlockByValue(nextBlock, nextBlock.Valeur * 2);
                    nextBlock.Valeur *= 2;
                    newBlock.Moovable = false;
                    newBlock.Valeur = 0;
                    newBlock.BackColor = Color.DarkGray;
                }
                if(tour>0)
                {
                    bloc.Moovable = false;
                    bloc.Valeur = 0;
                    bloc.BackColor = Color.DarkGray;
                }
                
            }
        }

        public Bloc getPreviousBlock(string type, Bloc bloc)
        {
            int modifier;
            if (type == "horizontal")
            {
                modifier = 1;
            }
            else
            {
                modifier = 4;
            }
            if (getBlockByTag(int.Parse(bloc.Tag.ToString()) - modifier) == null)
            {
                return bloc;
            }
            return getBlockByTag(int.Parse(bloc.Tag.ToString()) - modifier);

        }

        public Bloc getNextBlock(string type, Bloc bloc)
        {
            int modifier;
            if (type == "horizontal")
            {
                modifier = 1;
            }
            else
            {
                modifier = 4;
            }
            if (getBlockByTag(int.Parse(bloc.Tag.ToString()) + modifier) == null)
            {
                return bloc;
            }
            return getBlockByTag(int.Parse(bloc.Tag.ToString()) + modifier);

        }

        public void ColorBlockByValue(Bloc bloc, int value)
        {
            switch (value)
            {
                case 2: bloc.BackColor = Color.White; break;
                case 4: bloc.BackColor = Color.Beige; break;
                case 8: bloc.BackColor = Color.Orange; break;
                case 16: bloc.BackColor = Color.Orange; break;
                case 32: bloc.BackColor = Color.Tomato; break;
                case 64: bloc.BackColor = Color.Red; break;
                case 128: bloc.BackColor = Color.Yellow; break;
                case 256: bloc.BackColor = Color.Yellow; break;
                case 512: bloc.BackColor = Color.Yellow; break;
                case 1024: bloc.BackColor = Color.Yellow; break;
                case 2048: bloc.BackColor = Color.Gold; break;
                default: bloc.BackColor = Color.DarkGray; break;
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                foreach (int i in thirdColumn)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveRight(bloc);
                }
                foreach (int i in secondColumn)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveRight(bloc);
                }
                foreach (int i in firstColumn)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveRight(bloc);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                foreach (int i in secondColumn)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveLeft(bloc);
                }
                foreach (int i in thirdColumn)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveLeft(bloc);
                }
                foreach (int i in fourthColumn)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveLeft(bloc);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                foreach (int i in thirdLine)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveDown(bloc);
                }
                foreach (int i in secondLine)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveDown(bloc);
                }
                foreach (int i in firstLine)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveDown(bloc);
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                foreach (int i in secondLine)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveUp(bloc);
                }
                foreach (int i in thirdLine)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveUp(bloc);
                }
                foreach (int i in fourthLine)
                {
                    Bloc bloc = getBlockByTag(i);
                    mooveUp(bloc);
                }
            }
            bool found = false;
            foreach(Bloc bloc in pnlGrille.Controls.OfType<Bloc>())
            {
                if(!bloc.Moovable && !found)
                {
          
                    found = true;
                    bloc.Moovable = true;
                    bloc.Valeur = 2;
                    bloc.BackColor = Color.White;
                }
            }
        }

        private void bloc1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
