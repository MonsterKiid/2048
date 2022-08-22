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

        public void moove(string direction, Block block)
        {
            if (block.Moovable)
            {
                string facing = (direction == "up" || direction == "down") ? facing = "vertical" : facing = "horizontal";
                int modifier = (direction == "up" || direction == "down") ? modifier = 4 : modifier = 1;
                List<int> column = (direction == "up") ? column = firstLine : (direction == "left") ? column = firstColumn : (direction == "down") ? column = fourthLine : column = fourthColumn;

                int lap = 0;
                int tag = int.Parse(block.Tag.ToString());
                if (direction == "up" || direction == "left")
                {
                    while (!column.Contains(tag) && !getPreviousBlock(facing, getBlockByTag(tag)).Moovable)
                    {
                        tag -= modifier;
                        lap++;
                    }
                } else
                {
                    while (!column.Contains(tag) && !getNextBlock(facing, getBlockByTag(tag)).Moovable)
                    {
                        tag += modifier;
                        lap++;
                    }
                }
                Block newBlock = getBlockByTag(tag);
                newBlock.Valeur = block.Valeur;
                Block nearestBlock = (direction == "up" || direction == "left") ? nearestBlock = getPreviousBlock(facing, newBlock) : nearestBlock = getNextBlock(facing, newBlock);
                if (newBlock.Valeur == nearestBlock.Valeur && nearestBlock != newBlock)
                {
                    nearestBlock.Valeur *= 2;
                    lblScore.Text = (int.Parse(lblScore.Text) + nearestBlock.Valeur).ToString();
                    lblScore.Location = new Point((pnlScore.Width - lblScore.Width)/2, lblTitreScore.Location.Y+20);
                    newBlock.Valeur = 0;
                    newBlock.BackColor = Color.FromArgb(238, 228, 218);
                }
                if (lap > 0)
                {
                    block.Valeur = 0;
                    block.BackColor = Color.FromArgb(238, 228, 218);
                }
            }
        }

        public Block getPreviousBlock(string type, Block block)
        {
            int modifier = (type == "horizontal") ? modifier = 1 : modifier = 4;
            if (getBlockByTag(int.Parse(block.Tag.ToString()) - modifier) == null)
            {
                return block;
            }
            return getBlockByTag(int.Parse(block.Tag.ToString()) - modifier);

        }

        public Block getNextBlock(string type, Block block)
        {
            int modifier = (type == "horizontal") ? modifier = 1 : modifier = 4;
            if (getBlockByTag(int.Parse(block.Tag.ToString()) + modifier) == null)
            {
                return block;
            }
            return getBlockByTag(int.Parse(block.Tag.ToString()) + modifier);

        }

        private void addBlock()
        {
            bool found = false;
            Random r = new Random();
            foreach (Block block in pnlGrille.Controls.OfType<Block>().OrderBy(x => r.Next()))
            {
                if (!block.Moovable && !found)
                {
                    found = true;
                    block.Valeur = 2;
                }
            }
        }

        private void frmPartie_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                foreach (int i in thirdColumn) moove("right", getBlockByTag(i));
                foreach (int i in secondColumn) moove("right", getBlockByTag(i));       
                foreach (int i in firstColumn) moove("right", getBlockByTag(i));
            }
            else if (e.KeyCode == Keys.Left)
            {
                foreach (int i in secondColumn) moove("left", getBlockByTag(i));
                foreach (int i in thirdColumn) moove("left", getBlockByTag(i));
                foreach (int i in fourthColumn) moove("left", getBlockByTag(i));
            }
            else if (e.KeyCode == Keys.Down)
            {
                foreach (int i in thirdLine) moove("down", getBlockByTag(i));
                foreach (int i in secondLine) moove("down", getBlockByTag(i));
                foreach (int i in firstLine) moove("down", getBlockByTag(i));
            }
            else if (e.KeyCode == Keys.Up)
            {
                foreach (int i in secondLine) moove("up", getBlockByTag(i));
                foreach (int i in thirdLine) moove("up", getBlockByTag(i));
                foreach (int i in fourthLine) moove("up", getBlockByTag(i));
            }
            addBlock();
        }

        private void frmPartie_Load(object sender, EventArgs e)
        {
            lblTitreScore.Location = new Point((pnlScore.Width - lblTitreScore.Width)/2, lblTitreScore.Location.Y);
            lblTitreRecord.Location = new Point((pnlRecord.Width - lblTitreRecord.Width) / 2, lblTitreRecord.Location.Y);
            lblScore.Location = new Point((pnlScore.Width - lblScore.Width) / 2, lblTitreScore.Location.Y+20);
            lblRecord.Location = new Point((pnlRecord.Width - lblRecord.Width) / 2, lblTitreRecord.Location.Y+20);

            for (int i = 0;i<2;i++)
            {
                addBlock();
            }
        }
    }
}
