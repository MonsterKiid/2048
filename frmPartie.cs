using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        /*
         * Cette fonction sert à récupérer le mouvement des blocs selon la touche pressée
         * 
         * On va d'abord bouger l'avant-dernière colonne (inutile de bouger la dernière car rien ne va changer == bordure)
         * Puis on va bouger la précédente, et enfin on va bouger la précédente
         * 
         * Cette technique permet que les blocs fusionnent dans le bon ordre.
         */
        private void frmPartie_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Si le joueur appuie sur la flèche de droite
            if (e.KeyCode == Keys.Right)
            {
                foreach (int i in thirdColumn) move("right", getBlockByTag(i));
                foreach (int i in secondColumn) move("right", getBlockByTag(i));
                foreach (int i in firstColumn) move("right", getBlockByTag(i));
            }
            // Si le joueur appuie sur la flèche de gauche
            else if (e.KeyCode == Keys.Left)
            {
                foreach (int i in secondColumn) move("left", getBlockByTag(i));
                foreach (int i in thirdColumn) move("left", getBlockByTag(i));
                foreach (int i in fourthColumn) move("left", getBlockByTag(i));
            }
            // Si le joueur appuie sur la flèche du bas
            else if (e.KeyCode == Keys.Down)
            {
                foreach (int i in thirdLine) move("down", getBlockByTag(i));
                foreach (int i in secondLine) move("down", getBlockByTag(i));
                foreach (int i in firstLine) move("down", getBlockByTag(i));
            }
            // Si le joueur appuie sur la flèche du haut
            else if (e.KeyCode == Keys.Up)
            {
                foreach (int i in secondLine) move("up", getBlockByTag(i));
                foreach (int i in thirdLine) move("up", getBlockByTag(i));
                foreach (int i in fourthLine) move("up", getBlockByTag(i));
            }
            // Si le joueur appuie sur une autre touche, on bloque l'ajout d'un autre bloc
            else
            {
                return;
            }
            addBlock();
        }

        /*
         * Cette fonction est appelée lors du chargement du formulaire
         */
        private void frmPartie_Load(object sender, EventArgs e)
        {
            startNewGame();
            StreamReader sr = new StreamReader("../../save.txt");
            lblRecord.Text = sr.ReadLine();
            lblRecord.Location = new Point((pnlScore.Width - lblRecord.Width) / 2, lblTitreRecord.Location.Y + 20);
            sr.Close();
            writeRecord();

        }

        /*
         * Cette fonction permet de commencer une nouvelle partie
         * 
         * On va mettre les valeurs de tous les blocs ainsi que le score à 0
         * Puis on va désigner de nouveaux blocs à une position aléatoire 
           qui permettront de commencer la partie
        */
        private void startNewGame()
        {
            // Mise du score à 0
            lblScore.Text = "0";

            // Recentrage des labels
            lblScore.Location = new Point((pnlScore.Width - lblScore.Width) / 2, lblTitreScore.Location.Y + 20);
            lblRecord.Location = new Point((pnlScore.Width - lblRecord.Width) / 2, lblTitreRecord.Location.Y + 20);

            // Réinitialisation des blocs
            foreach (Block block in pnlGrille.Controls.OfType<Block>())
            {
                block.Valeur = 0;
            }


            // Ajout de deux nouveaux blocs
            for (int i = 0; i < 2; i++)
            {
                addBlock();
            }
        }

        /*
         * Cette fonction permet d'ajouter un nouveau bloc bougeable à la grille
         * Pour se faire on va prendre un bloc aléatoirement dans les Controls et
           on va vérifier s'il est bougeable

         * Si oui, on l'ajoute avec la valeur "2"
         * Si non, on boucle
         */
        private void addBlock()
        {
            // Cette variable permet d'arrêter l'assignation d'un bloc dès qu'un est trouvé
            bool found = false;
            Random r = new Random();
            foreach (Block block in pnlGrille.Controls.OfType<Block>().Where(b => b.Moovable == false).OrderBy(x => r.Next()))
            {
                if (!found)
                {
                    found = true;
                    if (r.Next(0, 100) < 25) //25%
                    {
                        block.Valeur = 4;                    
                    }
                    else
                    {
                        block.Valeur = 2;
                    }
                }
            }
            
        }

        /*
         * Cette fonction permet d'obtenir le bloc selon le tag qui lui est assigné
         * Si le tag passé en paramètre ne correspond à aucun bloc, alors on retourne null
         */
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

        /*
         * Cette fonction matérialise les déplacements des blocs selon une direction
         * 
         * La direction aura un impact sur 
         *  - le facing (est-ce que mes blocs voisins sont à la verticale ou à l'horizontale)
         *  - le modifier (qui nous permettra d'incrémenter le tag et de passer au bloc suivant)
         *  - la column (qui est la dernière colonne de la direction)
         *  - le nearestBlock (qui est le bloc voisin le plus proche selon le facing)
         */
        public void move(string direction, Block block)
        {
            // On ne bouge que les blocs qui sont bougeables
            if (block.Moovable)
            {
                string facing = (direction == "up" || direction == "down") ? facing = "vertical" : facing = "horizontal";
                int modifier = (direction == "up" || direction == "down") ? modifier = 4 : modifier = 1;
                List<int> column = (direction == "up") ? column = firstLine : (direction == "left") ? column = firstColumn : (direction == "down") ? column = fourthLine : column = fourthColumn;

                // Le tag actuel du bloc qui bouge
                int tag = int.Parse(block.Tag.ToString());
                if (direction == "up" || direction == "left")
                {
                    while (!column.Contains(tag) && !getPreviousBlock(facing, getBlockByTag(tag)).Moovable)
                    {
                        tag -= modifier;
                    }
                } else
                {
                    while (!column.Contains(tag) && !getNextBlock(facing, getBlockByTag(tag)).Moovable)
                    {
                        tag += modifier;
                    }
                }

                // Ce bloc est le bloc de destination (jusqu'à où le bloc a voyagé)
                Block newBlock = getBlockByTag(tag);
                newBlock.Valeur = block.Valeur;

                Block nearestBlock = (direction == "up" || direction == "left") ? nearestBlock = getPreviousBlock(facing, newBlock) : nearestBlock = getNextBlock(facing, newBlock);
                
                // S'il y a une fusion de blocs (même valeur)
                if (newBlock.Valeur == nearestBlock.Valeur && nearestBlock != newBlock)
                {
                    // On incrémente la valeur du bloc
                    nearestBlock.Valeur *= 2;

                    // Si le joueur atteint 2048
                    if (nearestBlock.Valeur == 2048) MessageBox.Show("Vous avez gagné la partie parce que vous avez atteint 2048 !\n\nVous pouvez toujours continuer à jouer jusqu'à ce que le jeu soit bloqué", "Félicitations", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // On met à jour le score et on le centre sur le panel
                    lblScore.Text = (int.Parse(lblScore.Text) + nearestBlock.Valeur).ToString();
                    lblScore.Location = new Point((pnlScore.Width - lblScore.Width)/2, lblTitreScore.Location.Y+20);

                    // On met à jour le record s'il est supérieur à l'ancien
                    writeRecord();

                    // On supprime le bloc suite à la fusion
                    newBlock.Valeur = 0;
                }

                // Si le bloc a bougé, il a forcément changé de case donc on met cette case à 0
                if (block != newBlock)
                {
                    block.Valeur = 0;
                }
            }
        }

        /*
         * Cette fonction permet d'inscrire le record du joueur stocké dans le fichier save.txt
         */
        public void writeRecord()
        {
            if (int.Parse(lblRecord.Text) < int.Parse(lblScore.Text))
            {
                StreamWriter sw = new StreamWriter("../../save.txt", false);
                sw.WriteLine(lblScore.Text);
                lblRecord.Text = lblScore.Text;
                lblRecord.Location = new Point((pnlScore.Width - lblRecord.Width) / 2, lblTitreRecord.Location.Y + 20);

                sw.Close();
            }
        }

        /*
         * Cette fonction permet d'obtenir le bloc précédent selon le facing
         *  - vertical: on prend le bloc du haut
         *  - horizontal: on prend le bloc de gauche
         * 
         * Si le bloc n'a pas de bloc précédent (exemple: le premier bloc) alors on retourne lui-même)
         */
        public Block getPreviousBlock(string facing, Block block)
        {
            int modifier = (facing == "horizontal") ? modifier = 1 : modifier = 4;
            if (getBlockByTag(int.Parse(block.Tag.ToString()) - modifier) == null)
            {
                return block;
            }
            return getBlockByTag(int.Parse(block.Tag.ToString()) - modifier);

        }

        /*
         * Cette fonction permet d'obtenir le bloc suivant selon le facing
         *  - vertical: on prend le bloc du bas
         *  - horizontal: on prend le bloc de droite
         * 
         * Si le bloc n'a pas de bloc suivant (exemple: le dernier bloc) alors on retourne lui-même)
         */
        public Block getNextBlock(string facing, Block block)
        {
            int modifier = (facing == "horizontal") ? modifier = 1 : modifier = 4;
            if (getBlockByTag(int.Parse(block.Tag.ToString()) + modifier) == null)
            {
                return block;
            }
            return getBlockByTag(int.Parse(block.Tag.ToString()) + modifier);

        }

        /*
         * Cette fonction est appelée lors du clic sur le bouton pour recommencer
         */
        private void pbxRetry_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment commencer une nouvelle partie ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) startNewGame();
        }

        /*
         * Cette fonction est appelée lors de la fermeture du formulaire
         */
        private void frmPartie_FormClosed(object sender, FormClosedEventArgs e)
        {
            writeRecord();
        }
    }
}
