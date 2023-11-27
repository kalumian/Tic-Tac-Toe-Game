using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        bool gameValid = true;
        short playCount = 0;
        enum Players
        {
            player1,
            player2,
        }
        private Players currentPlayer = Players.player1;

        private void switchPlayer()
        {
            if (currentPlayer == Players.player1)
            {
                currentPlayer = Players.player2;
                labe_turn.Text = "Player2";
                labe_turn.ForeColor = Color.Blue;
            }
            else
            {
                currentPlayer = Players.player1;
                labe_turn.Text = "Player1";
                labe_turn.ForeColor = Color.Red;
            }
        }

     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            Pen pen = new Pen(white,5);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //Y
            e.Graphics.DrawLine(pen, 154.5f, 60, 154.5f, 360);
            e.Graphics.DrawLine(pen, 265.5f, 60, 265.5f, 360);

            //X |y250/2=125|(110x)(250y)
            e.Graphics.DrawLine(pen, 56, 150.5f, 365, 150.5f);
            e.Graphics.DrawLine(pen, 56, 255.5f, 365, 255.5f);

        }

        private void playTurn(object sender)
        {
            PictureBox currentPictrue = (PictureBox)sender;
            if (gameValid && currentPictrue.Tag.ToString() != "x" && currentPictrue.Tag.ToString() != "o")
            {
                if (currentPlayer == Players.player1)
                {
                    currentPictrue.Image = Resources.X;
                    currentPictrue.Tag = "x";
                }
                else
                {
                    currentPictrue.Image = Resources.O;
                    currentPictrue.Tag = "o";
                }
                playCount++;
                if (playCount == 9)
                {
                    winner.Text = "No One!";
                    winner.ForeColor = Color.Green;
                    gameValid = false;
                }
                cheekWinner();
                switchPlayer();
            }
        }
        private void handleWineer(PictureBox btn1, PictureBox btn2, PictureBox btn3) {
        if(btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn3.Tag.ToString() == btn2.Tag.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                if (btn1.Tag.ToString() == "o")
                {
                    winner.Text = "Player2!";
                    winner.ForeColor = Color.Blue;
                    gameValid = false;
                }
                else if (btn1.Tag.ToString() == "x")
                {
                    winner.Text = "Player1!";
                    winner.ForeColor = Color.Red;
                    gameValid = false;
                }
            }
        }
        private void cheekWinner()
        {
            handleWineer(pb11, pb12, pb13);
            handleWineer(pb21, pb22, pb23);
            handleWineer(pb31, pb32, pb33);

            handleWineer(pb11, pb21, pb31);
            handleWineer(pb12, pb22, pb32);
            handleWineer(pb13, pb23, pb33);

            handleWineer(pb11, pb22, pb33);
            handleWineer(pb13, pb22, pb31);
        }
        // --------------------- Row 1 ---------------------
        private void pb11_Click(object sender, EventArgs e)
        {
            playTurn(sender);
        }
        private void pb12_Click(object sender, EventArgs e)
        {
            playTurn(sender);
        }
        private void pb13_Click(object sender, EventArgs e)
        {
            playTurn(sender);
        }
        // --------------------- Row 2 ---------------------
        private void pb21_Click(object sender, EventArgs e)
        {
            playTurn(sender);
        }
        private void pb22_Click(object sender, EventArgs e)
        {
            playTurn(sender);
        }
        private void pb23_Click(object sender, EventArgs e)
        {
            playTurn(sender);
        }

        // --------------------- Row 3 ---------------------
        private void pb31_Click(object sender, EventArgs e)
        {
            playTurn(sender);
        }
        private void pb32_Click(object sender, EventArgs e)
        {
            playTurn(sender);
        }
        private void pb33_Click(object sender, EventArgs e)
        {
            playTurn(sender);
        }

        private void resetButton(PictureBox box) {
            box.Image = Resources.question_mark_96;
            box.BackColor = Color.Transparent;
            box.Tag = "?";
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetButton(pb11);
            resetButton(pb12);
            resetButton(pb13);
            resetButton(pb21);
            resetButton(pb22);
            resetButton(pb23);
            resetButton(pb31);
            resetButton(pb32);
            resetButton(pb33);

            playCount = 0;
            currentPlayer = Players.player1;
            winner.Text = "";
            gameValid = true;
            labe_turn.Text = "Player1";
            labe_turn.ForeColor = Color.Red;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void winner_Click(object sender, EventArgs e)
        {

        }
    }
}
