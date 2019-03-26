using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public void newGame()
        {
            button1.Text = "";
            button2.Text = " ";
            button3.Text = "   ";
            button4.Text = "    ";
            button5.Text = "   ";
            button6.Text = "  ";
            button7.Text = " ";
            button8.Text = "   ";
            button9.Text = "     ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;



        }




        public int check()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                
                newGame();
                return 1;
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                newGame();
                return 1;
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                newGame();
                return 1;
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                newGame();
                return 1;
            }
            else if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                newGame();
                return 1;
            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text)
            {
                newGame();
                return 1;
            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                newGame();
                return 1;
            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                newGame();

                return 1;
            }

            else
            {
                
                return 0;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        //string[,] matrix = new string[3, 3];

        string turn = "X";

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = turn;
           /// matrix[0, 0] = turn;
            button1.Enabled = false;
            check();
            if (turn == "X")
                turn = "O";
            else if (turn == "O")
                turn = "X";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = turn;
           /// matrix[0, 1] = turn;
            button2.Enabled = false;
            check();
            if (turn == "X")
                turn = "O";
            else if (turn == "O")
                turn = "X";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = turn;
            ///matrix[0, 2] = turn;
            button3.Enabled = false;
            check();
            if (turn == "X")
                turn = "O";
            else if (turn == "O")
                turn = "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = turn;
           /// matrix[1, 0] = turn;
            button4.Enabled = false;
            check();
            if (turn == "X")
                turn = "O";
            else if (turn == "O")
                turn = "X";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = turn;
           /// matrix[1, 1] = turn;
            button5.Enabled = false;
            check();
            if (turn == "X")
                turn = "O";
            else if (turn == "O")
                turn = "X";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = turn;
           /// matrix[1, 2] = turn;
            button6.Enabled = false;
            check();
            if (turn == "X")
                turn = "O";
            else if (turn == "O")
                turn = "X";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = turn;
           /// matrix[2, 0] = turn;
            button7.Enabled = false;
            check();
            if (turn == "X")
                turn = "O";
            else if (turn == "O")
                turn = "X";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = turn;
           /// matrix[2, 1] = turn;
            button8.Enabled = false;
            check();
            if (turn == "X")
                turn = "O";
            else if (turn == "O")
                turn = "X";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = turn;
           /// matrix[2, 2] = turn;
            button9.Enabled = false;
            check();
            if (turn == "X")
                turn = "O";
            else if (turn == "O")
                turn = "X";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            newGame();



        }
    }
}
