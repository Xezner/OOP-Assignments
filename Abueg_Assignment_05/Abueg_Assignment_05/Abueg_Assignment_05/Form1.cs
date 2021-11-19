using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abueg_Assignment_05
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_counter = 0;
        string[] boxes = { "r1c1", "r1c2", "r1c3", "r2c1", "r2c2", "r2c3", "r3c1", "r3c2", "r3c3" };
        bool[] boxesState = { false, false, false, false, false, false, false, false, false };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click(object sender, EventArgs e)
        {
            Button box = (Button)sender;
            //MessageBox.Show(turn.ToString());
            if (turn)
            {
                //MessageBox.Show("X");
                for ( int i = 0; i<9; i++)
                {
                    if(box.Name == boxes[i])
                    {
                        if (boxesState[i] == true)
                            return;
                        else
                        {
                            box.ForeColor = Color.Red;
                            box.Text = "X";
                            boxesState[i] = true;
                            turn = !turn;
                        }
                    }    
                }

            }
            else
            {
                //MessageBox.Show("O");
                for (int i = 0; i < 9; i++)
                {
                    if (box.Name == boxes[i])
                    {
                        if (boxesState[i] == true)
                            return;
                        else
                        {
                            box.ForeColor = Color.Blue;
                            box.Text = "O";
                            boxesState[i] = true;
                            turn = !turn;
                        }
                    }
                }
            }

            tictactoe();
        }

        private void tictactoe()
        {
            if ((r1c1.Text == r1c2.Text) && (r1c2.Text == r1c3.Text)) // row1
            {
                if (r1c3.Text == "X")
                    MessageBox.Show("X wins");
                else if (r1c3.Text == "O")
                    MessageBox.Show("O wins");
            }
            if ((r2c1.Text == r2c2.Text) && (r2c2.Text == r2c3.Text)) //row2
            {
                if (r2c3.Text == "X")
                    MessageBox.Show("X wins");
                else if (r2c3.Text == "O")
                    MessageBox.Show("O wins");
            }
            if ((r3c1.Text == r3c2.Text) && (r3c2.Text == r3c3.Text)) //row3
            {
                if (r3c3.Text == "X")
                    MessageBox.Show("X wins");
                else if (r3c3.Text == "O")
                    MessageBox.Show("O wins");
            }
            if ((r1c1.Text == r2c1.Text) && (r2c1.Text == r3c1.Text)) //col1
            {
                if (r3c1.Text == "X")
                    MessageBox.Show("X wins");
                else if (r3c1.Text == "O")
                    MessageBox.Show("O wins");
            }
            if ((r1c2.Text == r2c2.Text) && (r2c2.Text == r3c2.Text)) //col2
            {
                if (r3c2.Text == "X")
                    MessageBox.Show("X wins");
                else if (r3c2.Text == "O")
                    MessageBox.Show("O wins");
            }
            if ((r1c3.Text == r2c3.Text) && (r2c3.Text == r3c3.Text)) //col3
            {
                if (r3c3.Text == "X")
                    MessageBox.Show("X wins");
                else if (r3c3.Text == "O")
                    MessageBox.Show("O wins");
            }
            if ((r1c1.Text == r2c2.Text) && (r2c2.Text == r3c3.Text)) //diag1 r1c1 r2c2 r3c3
            {
                if (r3c3.Text == "X")
                    MessageBox.Show("X wins");
                else if (r3c3.Text == "O")
                    MessageBox.Show("O wins");
            }
            if ((r1c3.Text == r2c2.Text) && (r2c2.Text == r3c1.Text)) //diag2 r1c3 r2c2 r3c1
            {
                if (r3c1.Text == "X")
                    MessageBox.Show("X wins");
                else if (r3c1.Text == "O")
                    MessageBox.Show("O wins");
            }
            turn_counter = 0;
            for ( int i = 0; i < 9; i ++)
            {
                if (boxesState[i] == true)
                    turn_counter++;
                if (turn_counter == 9)
                {
                    MessageBox.Show("Draw");
                    return;
                }
            }


        }

        private void newGameClick(object sender, EventArgs e)
        {
            turn = !turn;
            turn_counter = 0;
            for (int i = 0; i < 9; i++)
            {
                boxesState[i] = false;
            }
            try
            {
                foreach (Control c in Controls)
                {
                    Button box = (Button)c;
                    box.Text = "";
                }
            }
            catch { }
        }

        private void exitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
