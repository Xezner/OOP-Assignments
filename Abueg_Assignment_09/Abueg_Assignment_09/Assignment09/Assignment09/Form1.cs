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
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_09\Abueg_Assignment_09\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = fdlg.FileName;
                string jsonResume = System.IO.File.ReadAllText(fileName);
                NewResume newResume = JsonNet.Deserialize<NewResume>(jsonResume);

                MessageBox.Show($"surname: { newResume.surname} ");
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            var newResume = new NewResume
            {
                surname = surnameBox.Text,
                firstname = firstNameBox.Text,
                middlename = middleNameBox.Text,
                address = addressBox.Text,
                contact = contactBox.Text,
                email = emailBox.Text,
                hsName = hsNameBox.Text,
                hsYears = hsYearsBox.Text,
                collegeName = collegeNameBox.Text,
                collegeCourse = collegeCourseBox.Text,
                collegeYears = collegeYearsBox.Text,
                exp = expBox.Text,
                skills = skillsBox.Text,
                charRefName1 = charRefNameBox1.Text,
                charRefTitle1 = charRefTitleBox1.Text,
                charRefContact1 = charRefContactBox1.Text,
                charRefName2 = charRefNameBox2.Text,
                charRefTitle2 = charRefTitleBox2.Text,
                charRefContact2 = charRefContactBox2.Text
            };

            string jsonResume = JsonNet.Serialize(newResume);

            MessageBox.Show(jsonResume);

            string filePath = @"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_09\Abueg_Assignment_09\" + surnameBox.Text + firstNameBox.Text + ".json";
            System.IO.File.WriteAllText(filePath, jsonResume);

        }

        


    }
    public class NewResume
    {
        public string surname;
        public string firstname;
        public string middlename;
        public string address;
        public string contact;
        public string email;
        public string hsName;
        public string hsYears;
        public string collegeName;
        public string collegeCourse;
        public string collegeYears;
        public string exp;
        public string skills;
        public string charRefName1;
        public string charRefTitle1;
        public string charRefContact1;
        public string charRefName2;
        public string charRefTitle2;
        public string charRefContact2;
    }
}
