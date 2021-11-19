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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        }

        private void tictactoe()
        {

        }

    }
}
