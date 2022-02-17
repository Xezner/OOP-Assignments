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
using PdfSharp.Pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using PdfSharp.Drawing;
using PdfPage = PdfSharp.Pdf.PdfPage;
using PdfDocument = PdfSharp.Pdf.PdfDocument;

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
                surnameBox.Text = newResume.surname;
                firstNameBox.Text = newResume.firstname;
                middleNameBox.Text = newResume.middlename;
                ageBox.Text = newResume.age;
                genderBox.Text = newResume.gender;
                addressBox.Text = newResume.address;
                contactBox.Text = newResume.contact;
                emailBox.Text = newResume.email;
                hsNameBox.Text = newResume.hsName;
                hsYearsBox.Text = newResume.hsYears;
                collegeNameBox.Text = newResume.collegeName;
                collegeCourseBox.Text = newResume.collegeCourse;
                collegeYearsBox.Text = newResume.collegeYears;
                expBox.Text = newResume.exp;
                skillsBox.Text = newResume.skills;
                charRefNameBox1.Text = newResume.charRefName1;
                charRefTitleBox1.Text = newResume.charRefTitle1;
                charRefContactBox1.Text = newResume.charRefContact1;
                charRefNameBox2.Text = newResume.charRefName2;
                charRefTitleBox2.Text = newResume.charRefTitle2;
                charRefContactBox2.Text = newResume.charRefContact2;

            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            var newResume = new NewResume
            {
                surname = surnameBox.Text,
                firstname = firstNameBox.Text,
                middlename = middleNameBox.Text,
                age = ageBox.Text,
                gender = genderBox.Text,
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


            string filePath = @"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_09\Abueg_Assignment_09\" + surnameBox.Text + firstNameBox.Text + ".json";
            string pdfPath = @"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_09\Abueg_Assignment_09\" + surnameBox.Text + firstNameBox.Text + ".pdf";
            System.IO.File.WriteAllText(filePath, jsonResume);

            /*
            Document pdfResume = new Document();
            PdfWriter.GetInstance(pdfResume, new FileStream(pdfPath, FileMode.Create));
            pdfResume.Open();
            Paragraph p1 = new Paragraph("Hello World");
            pdfResume.Add(p1);
            pdfResume.Close();
            */
            try
            {
                System.Drawing.Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size, CopyPixelOperation.SourceCopy);
                    }
                    bitmap.Save(@"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_09\Abueg_Assignment_09\Rectangle.bmp", ImageFormat.Bmp);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }

            PdfDocument doc = new PdfDocument();

            PdfPage oPage = new PdfPage();

            doc.Pages.Add(oPage);
            oPage.Rotate = 90;
            XGraphics xgr = XGraphics.FromPdfPage(oPage);
            XImage img = XImage.FromFile(@"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_09\Abueg_Assignment_09\Rectangle.bmp");

            xgr.DrawImage(img, 0, 0);

            doc.Save(pdfPath);
            doc.Close();
        }

        


    }
    public class NewResume
    {
        public string surname;
        public string firstname;
        public string middlename;
        public string age;
        public string gender;
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
