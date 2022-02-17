using Json.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment09
{
    public partial class Resume : Form
    {
        public Resume()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            var newResume = new NewResume
            {
                surname = surnameBox.Text
            };

            string jsonResume = JsonNet.Serialize(newResume);

            MessageBox.Show(jsonResume);

            string filePath = @"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_09\Abueg_Assignment_09\" + surnameBox.Text +".txt";
            System.IO.File.WriteAllText(filePath, jsonResume);

        }

        


    }
    public class NewResume
    {
        public string surname;
    }
}
