using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abueg_Assignment_06
{
    public partial class Form1 : Form
    {
        string filename = @"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_06\ContactTracingForm.txt";
        string textInfo;
        int dataCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void viewButton_Click(object sender, EventArgs e)
        {
            var read = new FileStream(@"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_06\ContactTracingForm.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(read, Encoding.UTF8))
            {
                textInfo = streamReader.ReadToEnd();
                int counter = 0;
                foreach( var a in textInfo.Split(new[] { "----------------------------------------------------------------------" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    counter++;
                }

                string[] noteContent = new string[counter + 1];
                counter = 0;
                foreach (var a in textInfo.Split(new[] { "----------------------------------------------------------------------" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    noteContent[counter] = a.ToString();
                    counter++;
                }
                if (noteContent.Length != (dataCounter + 1))
                {
                    textBox.Text = noteContent[dataCounter];
                    dataCounter++;
                    viewButton.Text = "Next";
                }
                else
                {
                    MessageBox.Show("Reached end of contents");
                    textBox.Text = "";
                    viewButton.Text = "View";
                    dataCounter = 0;
                }
                
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
