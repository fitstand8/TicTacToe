using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormMain : Form
    {
        // true = X, false = O
        internal static bool turn;
        int turnCount = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;

            Image xImage = Image.FromFile("../Pics/X.png");
            Image oImage = Image.FromFile("../Pics/O.png");
            xImage.Tag = "X";
            oImage.Tag = "O";

            if (turn) p.Image = xImage;
            else p.Image = oImage;

            turn = !turn;
            p.Enabled = false;

            turnCount++;
            CheckTurn();
            CheckForWinner();           
        }

        private void CheckTurn()
        {
            if (turn)
            {
                lblTurn.Text = "X's Turn";
                lblTurn.ForeColor = Color.Red;
            }              
            else
            {
                lblTurn.Text = "O's Turn";
                lblTurn.ForeColor = Color.LimeGreen;
            }               
        }

        private void CheckForWinner()
        {
            bool ThereIsAWinner = false;

            //Horizontal Checks
            if((A1.Image != null) && (A2.Image != null) && (A3.Image != null) && (A1.Image.Tag == A2.Image.Tag) && (A2.Image.Tag == A3.Image.Tag))
            {
                ThereIsAWinner = true;
            }
            else if ((B1.Image != null) && (B2.Image != null) && (B3.Image != null) && (B1.Image.Tag == B2.Image.Tag) && (B2.Image.Tag == B3.Image.Tag))
            {
                ThereIsAWinner = true;
            }
            else if ((C1.Image != null) && (C2.Image != null) && (C3.Image != null) && (C1.Image.Tag == C2.Image.Tag) && (C2.Image.Tag == C3.Image.Tag))
            {
                ThereIsAWinner = true;
            }

            //Vertical Checks
            else if ((A1.Image != null) && (B1.Image != null) && (C1.Image != null) && (A1.Image.Tag == B1.Image.Tag) && (B1.Image.Tag == C1.Image.Tag))
            {
                ThereIsAWinner = true;
            }
            else if ((A2.Image != null) && (B2.Image != null) && (C2.Image != null) && (A2.Image.Tag == B2.Image.Tag) && (B2.Image.Tag == C2.Image.Tag))
            {
                ThereIsAWinner = true;
            }
            else if ((A3.Image != null) && (B3.Image != null) && (C3.Image != null) && (A3.Image.Tag == B3.Image.Tag) && (B3.Image.Tag == C3.Image.Tag))
            {
                ThereIsAWinner = true;
            }

            //Diagonal Checks
            else if ((A1.Image != null) && (B2.Image != null) && (C3.Image != null) && (A1.Image.Tag == B2.Image.Tag) && (B2.Image.Tag == C3.Image.Tag))
            {
                ThereIsAWinner = true;
            }
            else if ((A3.Image != null) && (B2.Image != null) && (C1.Image != null) && (A3.Image.Tag == B2.Image.Tag) && (B2.Image.Tag == C1.Image.Tag))
            {
                ThereIsAWinner = true;
            }




            if (ThereIsAWinner)
            {
                DisableCells();
                if (turn)
                {
                    MessageBox.Show("O Won!", "Game Over");
                }
                else
                {
                    MessageBox.Show("X Won!", "Game Over");
                }
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("Draw!", "Game Over");
                }
            }
        }
        private void DisableCells()
        {
            foreach(Control c in Controls)
            {
                PictureBox p = c as PictureBox;
                if(p != null)
                {
                    p.Enabled = false;
                }
            }
        }

        private void StartAsXMenuStrip(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            foreach (Control c in Controls)
            {
                PictureBox p = c as PictureBox;
                if (p != null)
                {
                    p.Enabled = true;
                    p.Image = null;
                }
            }
            CheckTurn();
        }

        private void StartAsOMenuStrip(object sender, EventArgs e)
        {
            turn = false;
            turnCount = 0;
            foreach (Control c in Controls)
            {
                PictureBox p = c as PictureBox;
                if (p != null)
                {
                    p.Enabled = true;
                    p.Image = null;
                }
            }
            CheckTurn();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CheckTurn();
        }
    }
}
