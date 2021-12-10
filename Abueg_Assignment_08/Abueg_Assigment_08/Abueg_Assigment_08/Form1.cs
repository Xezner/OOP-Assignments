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
        string dateTime;
        char[] timeArray = {'a', 'a', 'a', 'a', 'a', 'a'} ;
        char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        bool[] zero = { true, true, true, true, true, true, false };
        bool[] one = { false, true, true, false, false, false, false };
        bool[] two = { true, true, false, true, true, false, true };
        bool[] three = { true, true, true, true, false, false, true };
        bool[] four = { false, true, true, false, false, true, true };
        bool[] five = { true, false, true, true, false, true, true };
        bool[] six = { true, false, true, true, true, true, true };
        bool[] seven = { true, true, true, false, false, false, false };
        bool[] eight = { true, true, true, true, true, true, true };
        bool[] nine = { true, true, true, false, false, true, true };
        public Form1()
        {
            InitializeComponent();
            buttonColorLoop();
            reflectClock();
        }

        // gets date and convert to char array
        public void getDate()
        {
            dateTime = DateTime.Now.ToString("hh:mm:ss");
            string[] time = dateTime.Split(':');
            int x = 0;
            foreach (var subTime in time)
            {
                
                foreach (char stringArray in subTime)
                {
                    if(x<6)
                    timeArray[x] = stringArray;
                    x++;
                } 
            }
            get7Seg();
        }

        // gets and displays the 7segment digit
        public void get7Seg()
        {
            int counter = 1;
            foreach (char c in timeArray)
            {
                //gets what button to display the number to
                List<Button> sevenSeg = getButton(counter);

                //get what number is to display
                string sevenDigit = c.ToString();
                int sevenNum = Int32.Parse(sevenDigit);
                switch(sevenNum)
                {
                    case 0:
                        int i0 = 0;
                        foreach (bool b in zero)
                        {
                            if (b)
                                sevenSeg[i0].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i0].BackColor = Color.Transparent;
                            i0++;
                        }
                        break;
                    case 1:
                        int i1 = 0;
                        foreach (bool b in one)
                        {
                            if (b)
                                sevenSeg[i1].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i1].BackColor = Color.Transparent;
                            i1++;
                        }
                        break;
                    case 2:
                        int i2 = 0;
                        foreach (bool b in two)
                        {
                            if (b)
                                sevenSeg[i2].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i2].BackColor = Color.Transparent;
                            i2++;
                        }
                        break;
                    case 3:
                        int i3 = 0;
                        foreach (bool b in three)
                        {
                            if (b)
                                sevenSeg[i3].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i3].BackColor = Color.Transparent;
                            i3++;
                        }
                        break;
                    case 4:
                        int i4 = 0;
                        foreach (bool b in four)
                        {
                            if (b)
                                sevenSeg[i4].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i4].BackColor = Color.Transparent;
                            i4++;
                        }
                        break;
                    case 5:
                        int i5 = 0;
                        foreach (bool b in five)
                        {
                            if (b)
                                sevenSeg[i5].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i5].BackColor = Color.Transparent;
                            i5++;
                        }
                        break;
                    case 6:
                        int i6 = 0;
                        foreach (bool b in six)
                        {
                            if (b)
                                sevenSeg[i6].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i6].BackColor = Color.Transparent;
                            i6++;
                        }
                        break;
                    case 7:
                        int i7 = 0;
                        foreach (bool b in seven)
                        {
                            if (b)
                                sevenSeg[i7].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i7].BackColor = Color.Transparent;
                            i7++;
                        }
                        break;
                    case 8:
                        int i8 = 0;
                        foreach (bool b in eight)
                        {
                            if (b)
                                sevenSeg[i8].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i8].BackColor = Color.Transparent;
                            i8++;
                        }
                        break;
                    case 9:
                        int i9 = 0;
                        foreach (bool b in nine)
                        {
                            if (b)
                                sevenSeg[i9].BackColor = Color.White;

                            if (!b)
                                sevenSeg[i9].BackColor = Color.Transparent;
                            i9++;
                        }
                        break;
                } 
             counter++;
            }
        }

        //sets the buttons in a list for easier access
        public List<Button> getButton(int num)
        {
            List<Button> button1 = new List<Button> { button1A, button1B, button1C, button1D, button1E, button1F, button1G };
            List<Button> button2 = new List<Button> { button2A, button2B, button2C, button2D, button2E, button2F, button2G };
            List<Button> button3 = new List<Button> { button3A, button3B, button3C, button3D, button3E, button3F, button3G };
            List<Button> button4 = new List<Button> { button4A, button4B, button4C, button4D, button4E, button4F, button4G };
            List<Button> button5 = new List<Button> { button5A, button5B, button5C, button5D, button5E, button5F, button5G };
            List<Button> button6 = new List<Button> { button6A, button6B, button6C, button6D, button6E, button6F, button6G };
            

            switch (num)
            {
                case 1: 
                    return button1;
                case 2:
                    return button2;
                case 3:
                    return button3;
                case 4:
                    return button4;
                case 5:
                    return button5;
                case 6:
                    return button6;
            }
            return null;
        }


        // gets date every 1second
        public async void reflectClock()
        {
            while (true)
            {
                getDate();
                await Task.Delay(1000);
            }
        }

        //turn the colons on and off
        public async void buttonColorLoop()
        {
            while (true)
            {
                buttonColorOn();
                await Task.Delay(1000);
                buttonColorOff();
                await Task.Delay(1000);
            }
        }
        
        //turn colons on
        public void buttonColorOn()
        {
            dot1A.BackColor = Color.White;
            dot1B.BackColor = Color.White;
            dot2A.BackColor = Color.White;
            dot2B.BackColor = Color.White;
        }

        //turns colons off
        public void buttonColorOff()
        {
            dot1A.BackColor = Color.Transparent;
            dot1B.BackColor = Color.Transparent;
            dot2A.BackColor = Color.Transparent;
            dot2B.BackColor = Color.Transparent;
        }

        private void buttonHover(object sender, EventArgs e)
        {
        }

        private void buttonMouseLeave(object sender, EventArgs e)
        {
        }
    }
}
