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
    public partial class frmPartie : Form
    {

        List<int> firstColumn = new List<int> { 0, 4, 8, 12 };
        List<int> secondColumn = new List<int> { 1, 5, 9, 13 };
        List<int> thirdColumn = new List<int> { 2, 6, 10, 14 };
        List<int> fourthColumn = new List<int> { 3, 7, 11, 15 };

        List<int> firstLine = new List<int> { 0, 1, 2, 3 };
        List<int> secondLine = new List<int> { 4, 5, 6, 7 };
        List<int> thirdLine = new List<int> { 8, 9, 10, 11 };
        List<int> fourthLine = new List<int> { 12, 13, 14, 15 };

        public frmPartie()
        {
            InitializeComponent();
        }

        public Block getBlockByTag(int tag)
        {
            foreach (Block block in pnlGrille.Controls.OfType<Block>())
            {
                if (int.Parse(block.Tag.ToString()) == tag)
                {
                    return block;
                }
            }
            return null;
        }

        public void mooveUp(Block block)
        {
            if (block.Moovable)
            {
                int tour = 0;
                int tag = int.Parse(block.Tag.ToString());
                while (!firstLine.Contains(tag) && !getPreviousBlock("vertical", getBlockByTag(tag)).Moovable)
                {
                    tag-=4;
                    tour++;
                }
                Block newBlock = getBlockByTag(tag);
                newBlock.Moovable = true;
                newBlock.Valeur = block.Valeur;
                ColorBlockByValue(newBlock, newBlock.Valeur);
                Block previousBlock = getPreviousBlock("vertical", newBlock);
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
                    block.Moovable = false;
                    block.Valeur = 0;
                    block.BackColor = Color.DarkGray;
                }
            }
        }

        public void mooveDown(Block block)
        {
            if (block.Moovable)
            {
                int tour = 0;
                int tag = int.Parse(block.Tag.ToString());
                while (!fourthLine.Contains(tag) && !getNextBlock("vertical", getBlockByTag(tag)).Moovable)
                {
                    tag += 4;
                    tour++;
                }
                Block newBlock = getBlockByTag(tag);
                newBlock.Moovable = true;
                newBlock.Valeur = block.Valeur;
                ColorBlockByValue(newBlock, newBlock.Valeur);
                Block nextBlock = getNextBlock("vertical", newBlock);
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
                    block.Moovable = false;
                    block.Valeur = 0;
                    block.BackColor = Color.DarkGray;
                }
            }
        }
        public void mooveLeft(Block block)
        {
            if (block.Moovable)
            {
                int tour = 0;
                int tag = int.Parse(block.Tag.ToString());
                while (!firstColumn.Contains(tag) && !getPreviousBlock("horizontal", getBlockByTag(tag)).Moovable)
                {
                    tag--;
                    tour++;
                }
                Block newBlock = getBlockByTag(tag);
                newBlock.Moovable = true;
                newBlock.Valeur = block.Valeur;
                ColorBlockByValue(newBlock, newBlock.Valeur);

                Block previousBlock = getPreviousBlock("horizontal", newBlock);
                //MessageBox.Show("BLOC " + newBlock.Name + " (Valeur: " + newBlock.Valeur + ")\n\nLe previous blockk est: " + previousBlock.Name + "\nValeur:" + previousBlock.Valeur);
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
                    block.Moovable = false;
                    block.Valeur = 0;
                    block.BackColor = Color.DarkGray;
                }
            }
        }

        public void mooveRight(Block block)
        {
            if (block.Moovable)
            {
                int tour = 0;
                int tag = int.Parse(block.Tag.ToString());
                while (!fourthColumn.Contains(tag) && !getNextBlock("horizontal", getBlockByTag(tag)).Moovable)
                {    
                    tag++;
                    tour++;
                }
                Block newBlock = getBlockByTag(tag);
                newBlock.Moovable = true;
                newBlock.Valeur = block.Valeur;
                ColorBlockByValue(newBlock, newBlock.Valeur);
                Block nextBlock = getNextBlock("horizontal", newBlock);
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
                    block.Moovable = false;
                    block.Valeur = 0;
                    block.BackColor = Color.DarkGray;
                }
                
            }
        }

        public Block getPreviousBlock(string type, Block block)
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
            if (getBlockByTag(int.Parse(block.Tag.ToString()) - modifier) == null)
            {
                return block;
            }
            return getBlockByTag(int.Parse(block.Tag.ToString()) - modifier);

        }

        public Block getNextBlock(string type, Block block)
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
            if (getBlockByTag(int.Parse(block.Tag.ToString()) + modifier) == null)
            {
                return block;
            }
            return getBlockByTag(int.Parse(block.Tag.ToString()) + modifier);

        }

        public void ColorBlockByValue(Block block, int value)
        {
            switch (value)
            {
                case 0: block.BackColor = Color.FromArgb(238, 228, 218); break;
                case 2: block.BackColor = ColorTranslator.FromHtml("#eee4da"); break;
                case 4: block.BackColor = ColorTranslator.FromHtml("#ede0c8"); break;
                case 8: case 16: block.BackColor = ColorTranslator.FromHtml("#f2b179"); break;
                case 32: block.BackColor = ColorTranslator.FromHtml("#f67c5f"); break;
                case 64: block.BackColor = ColorTranslator.FromHtml("#f65e3b"); break;
                default: block.BackColor = ColorTranslator.FromHtml("#edcf72"); break;
            }
            if (value > 4) ColorTranslator.FromHtml("#f9f6f2");
            

        }

        private void frmPartie_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                foreach (int i in thirdColumn)
                {
                    Block block = getBlockByTag(i);
                    mooveRight(block);
                }
                foreach (int i in secondColumn)
                {
                    Block block = getBlockByTag(i);
                    mooveRight(block);
                }
                foreach (int i in firstColumn)
                {
                    Block block = getBlockByTag(i);
                    mooveRight(block);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                foreach (int i in secondColumn)
                {
                    Block block = getBlockByTag(i);
                    mooveLeft(block);
                }
                foreach (int i in thirdColumn)
                {
                    Block block = getBlockByTag(i);
                    mooveLeft(block);
                }
                foreach (int i in fourthColumn)
                {
                    Block block = getBlockByTag(i);
                    mooveLeft(block);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                foreach (int i in thirdLine)
                {
                    Block block = getBlockByTag(i);
                    mooveDown(block);
                }
                foreach (int i in secondLine)
                {
                    Block block = getBlockByTag(i);
                    mooveDown(block);
                }
                foreach (int i in firstLine)
                {
                    Block block = getBlockByTag(i);
                    mooveDown(block);
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                foreach (int i in secondLine)
                {
                    Block block = getBlockByTag(i);
                    mooveUp(block);
                }
                foreach (int i in thirdLine)
                {
                    Block block = getBlockByTag(i);
                    mooveUp(block);
                }
                foreach (int i in fourthLine)
                {
                    Block block = getBlockByTag(i);
                    mooveUp(block);
                }
            }
            bool found = false;
            foreach(Block block in pnlGrille.Controls.OfType<Block>())
            {
                if(!block.Moovable && !found)
                {
          
                    found = true;
                    block.Moovable = true;
                    block.Valeur = 2;
                    block.BackColor = Color.White;
                }
            }
        }
    }
}
