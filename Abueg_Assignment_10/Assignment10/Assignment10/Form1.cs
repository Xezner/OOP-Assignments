using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Aztec;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace Assignment10
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public Form1()
        {
            InitializeComponent();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }

            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }

            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            */
        }


        private void scanQR_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            MessageBox.Show("Scanner started");
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                if (result == null) { return; }
                string decoded = result.ToString().Trim();
                Console.WriteLine(decoded);
                if (decoded != "")
                {       
                    timer1.Stop();
                    MessageBox.Show("QR Code decoded and saved into text file");
                }
                string filename = @"C:\Users\prenc\Documents\GitHub\OOP-Assignments\Abueg_Assignment_10\Assignment10\ContactTracingForm.txt";

                if (!File.Exists(filename))
                {
                    using (StreamWriter sw = File.CreateText(filename))
                    {
                        sw.Write(decoded);
                    }
                }
                else if (File.Exists(filename))
                {
                    File.Delete(filename);
                    using (StreamWriter sw = File.CreateText(filename))
                    {
                        sw.Write(decoded);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }


    }
}
