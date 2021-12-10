using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace Abueg_Assigment_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonColorLoop();
            
        }
        public async void buttonColorLoop()
        {
            while (true)
            {
                buttonColorOn();
                await Task.Delay(500);
                buttonColorOff();
                await Task.Delay(500);
            }
        }
        public void buttonColorOn()
        {
            button1A.BackColor = Color.White;
            button1B.BackColor = Color.White;
            button1C.BackColor = Color.White;
            button1D.BackColor = Color.White;
            button1E.BackColor = Color.White;
            button1F.BackColor = Color.White;
            button1G.BackColor = Color.White;

            button2A.BackColor = Color.White;
            button2B.BackColor = Color.White;
            button2C.BackColor = Color.White;
            button2D.BackColor = Color.White;
            button2E.BackColor = Color.White;
            button2F.BackColor = Color.White;
            button2G.BackColor = Color.White;

            dot1A.BackColor = Color.White;
            dot1B.BackColor = Color.White;
            dot2A.BackColor = Color.White;
            dot2B.BackColor = Color.White;
            /* foreach (Control c in Controls)
             {
                 Button buttonAll = (Button)c;
                 buttonAll.BackColor = Color.White;
             }
            */
        }

        public void buttonColorOff()
        {
            dot1A.BackColor = Color.Transparent;
            dot1B.BackColor = Color.Transparent;
            dot2A.BackColor = Color.Transparent;
            dot2B.BackColor = Color.Transparent;
/*
            button1A.BackColor = Color.Transparent;
            button1B.BackColor = Color.Transparent;
            button1C.BackColor = Color.Transparent;
            button1D.BackColor = Color.Transparent;
            button1E.BackColor = Color.Transparent;
            button1F.BackColor = Color.Transparent;
            button1G.BackColor = Color.Transparent;

            button2A.BackColor = Color.Transparent;
            button2B.BackColor = Color.Transparent;
            button2C.BackColor = Color.Transparent;
            button2D.BackColor = Color.Transparent;
            button2E.BackColor = Color.Transparent;
            button2F.BackColor = Color.Transparent;
            button2G.BackColor = Color.Transparent;
*/
        }

        private void buttonHover(object sender, EventArgs e)
        {
            button1F.BackColor = Color.White;
        }

        private void buttonMouseLeave(object sender, EventArgs e)
        {
            button1F.BackColor = Color.Transparent;
        }
    }
}
