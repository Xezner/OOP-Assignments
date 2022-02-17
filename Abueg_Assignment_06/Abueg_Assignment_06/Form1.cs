using QRCoder;
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
        string temp_ = "";
        string date_ = "";
        string name_ = "";
        string address_ = "";
        string number_ = "";
        string email_ = "";
        string filename = @"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_06\ContactTracingForm.txt";
        string textInfo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tempBox_TextChanged(object sender, EventArgs e)
        {
            temp_ = tempBox.Text;
            if (!double.TryParse(temp_, out _) && tempBox.Text != "")
            {
                MessageBox.Show("Only input numbers please.");
                tempBox.Text = "";
            }
        }

        private void dateBox_TextChanged(object sender, EventArgs e)
        {
            date_ = dateBox.Text;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            name_ = nameBox.Text;
        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {
            address_ = addressBox.Text;
        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {
            number_ = numberBox.Text;
            if (!long.TryParse(number_, out _) && numberBox.Text != "")
            {
                MessageBox.Show("Only input numbers please.");
                numberBox.Text = "";
            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            email_ = emailBox.Text;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (temp_ != "" && date_ != "" && name_ != "" & address_ != "" && number_ != "" && email_ != "")
                {
                    if (!File.Exists(filename))
                    {
                        using (StreamWriter sw = File.CreateText(filename))
                        {
                            sw.WriteLine("----------------------------------------------------------------------");
                            sw.WriteLine("Body Temp: {0}", temp_);
                            sw.WriteLine("Date & Time {0}", date_);
                            sw.WriteLine("Name: {0}", name_);
                            sw.WriteLine("Address: {0}", address_);
                            sw.WriteLine("Contact No.: {0}", number_);
                            sw.WriteLine("Email: {0}", email_);
                            sw.WriteLine("----------------------------------------------------------------------");
                            //sw.WriteLine(" ");
                        }
                    }
                    else if (File.Exists(filename))
                    {
                        using (StreamWriter sw = File.AppendText(filename))
                        {
                            //sw.WriteLine("----------------------------------------------------------------------");
                            sw.WriteLine("Body Temp: {0}", temp_);
                            sw.WriteLine("Date & Time {0}", date_);
                            sw.WriteLine("Name: {0}", name_);
                            sw.WriteLine("Address: {0}", address_);
                            sw.WriteLine("Contact No.: {0}", number_);
                            sw.WriteLine("Email: {0}", email_);
                            sw.WriteLine("----------------------------------------------------------------------");
                            sw.WriteLine(" ");
                        }
                    }

                    string strCode = File.ReadAllText(filename);
                    QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(5, Color.Black, Color.White, null, 15, 5, true);
                    qrCodeImage.Save(@"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_06\ContactTracingForm.jpg");


                    MessageBox.Show("Successfully submitted");
                    tempBox.Text = "";
                    dateBox.Text = "";
                    nameBox.Text = "";
                    addressBox.Text = "";
                    numberBox.Text = "";
                    emailBox.Text = "";
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("Incomplete Information");
                }
                
            }
            else if (!checkBox1.Checked)
            {
                MessageBox.Show("Please check the checkbox");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            var read = new FileStream(@"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_06\ContactTracingForm.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(read, Encoding.UTF8))
            {
                textInfo = streamReader.ReadToEnd();
                foreach( var a in textInfo.Split(new[] { "----------------------------------------------------------------------" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    MessageBox.Show(a);
                }
                

            }
        }
    }
}
