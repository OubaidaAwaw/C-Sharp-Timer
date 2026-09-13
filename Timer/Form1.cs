using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
namespace Timer
{
    public partial class Form1 : Form
    {
        //Start Variables
        List<string> asdf = new List<string>();
        List<string> asdfg = new List<string>();
        List<string> Lines = new List<string>();
        string line = null;
        string[] jak;
        int j = 0;
        int MD, MU, MM;
        bool Closes = false;
        string Active = "LHome";
        //End Variables
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Start Color Options
            Min.BackColor =
            Hour.BackColor =
            TextTitle.BackColor =
            PathSound.BackColor =
            AP.BackColor =
            label7.BackColor =
            PHome.BackColor =
            CreateClick.BackColor =
            PAlarm.BackColor =
            PPlus.BackColor =
            ListAlarms.BackColor =
            this.BackColor =
            label1.ForeColor =
            minuetry.BackColor =
            secondry.BackColor =
            houry.BackColor =
            button14.ForeColor =
            button15.ForeColor =
            button16.ForeColor =
            button17.ForeColor =
            button18.ForeColor =
            button19.ForeColor =
            ListPM.BackColor = comboBox1.BackColor = Color.FromArgb(255, 44, 44, 44);
            panel1.BackColor = Color.FromArgb(255, 255, 128, 0);
            CreateA.BackColor = Color.Orange;
            //End Color Options
            //Start Custom Options
            j++;
            CreateA.Height = 3;
            comboBox1.SelectedIndex = 1;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            //End Custom Options
            //Start Data Of ListsAlarm
            Lines.AddRange(File.ReadLines("Alarms.txt"));
            string[] length;
            for (int L = 0; L < Lines.Count; L++)
            {
                length = Lines[L].Split(';');
                ListAlarms.Items.Add(length[3] + "        " + length[0] + " : " + length[1] + " " + length[2]);
            }
            //End Data Of ListAlarm
            //Start Other Options
            Itemsave();
            RUN();
            DefaultTime();
            //End Other Options
        }
        private void Button21_Click(object sender, EventArgs e)
        {
            //To Save ++ Or -- In +- Title 
            if (int.Parse(secondry.Text) == 0 && int.Parse(minuetry.Text) == 0 && int.Parse(houry.Text) == 0)
            {
                Letter( "Please Click Start And Then Stop To Save");
            }
            else
            {
                if (ListPM.Items.Contains(houry.Text + ":" + minuetry.Text + ":" + secondry.Text))
                {
                    Letter("The Time Is Here In An Other Oporater");
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        if (timer2.Enabled == false)
                        {
                            asdf.Add(houry.Text + ":" + minuetry.Text + ":" + secondry.Text);
                            File.WriteAllLines("Pluss.txt", asdf.ToArray());
                            ListPM.Items.Add(houry.Text + ":" + minuetry.Text + ":" + secondry.Text);
                        }
                        else
                        {
                            Letter( "Please Click Stop To Save");
                        }
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            if (timer3.Enabled == false)
                            {
                                asdfg.Add(houry.Text + ":" + minuetry.Text + ":" + secondry.Text);
                                File.WriteAllLines("Miness.txt", asdfg.ToArray());
                                ListPM.Items.Add(houry.Text + ":" + minuetry.Text + ":" + secondry.Text);
                            }
                            else
                            {
                                Letter( "Please Click Stop To Save");
                            }
                        }
                    }
                }
            }
        }
        private void Button22_Click(object sender, EventArgs e)
        {
            //To Remove Saved ++ Or -- In +- Title
            if (!(ListPM.SelectedIndex == -1))
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    asdf.RemoveAt(ListPM.SelectedIndex);
                    ListPM.Items.RemoveAt(ListPM.SelectedIndex);
                    File.WriteAllLines("Pluss.txt", asdf.ToArray());
                    Letter( "The Item Is Deleted");
                }
                else
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        asdfg.RemoveAt(ListPM.SelectedIndex);
                        ListPM.Items.RemoveAt(ListPM.SelectedIndex);
                        File.WriteAllLines("Miness.txt", asdfg.ToArray());
                        Letter( "The Item Is Deleted");
                    }
                }
            }
            else
            {
                Letter( "You Haven't items");
            }
        }
        private void Label6_Click_1(object sender, EventArgs e)
        {
            //To Add Alarm You Have To Show The Time With This Button
            Shows();
            button5.Text = "Add";
        }
        private void Button23_Click(object sender, EventArgs e)
        {
            // ReSet Button
            if (timer2.Enabled || timer3.Enabled)
            {
                Letter( "Please Click On Stop Button To Return");
            }
            else
            {
                houry.Text = minuetry.Text = secondry.Text = "00";
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            //To Cancel Every Operation I Do
            if (line == null)
            {
                Heide();
                DefaultTime();
            }
            else
            {
                ListAlarms.Items.Add(line.Split(';')[3] + "        " + line.Split(';')[0] + " : " + line.Split(';')[1] + " " + line.Split(';')[2]);
                Lines.Add(line);
                line = null;
                Heide();
                DefaultTime();
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //To SelectedChanged
            Itemsave();
        }
        private void Button20_Click(object sender, EventArgs e)
        {
            //To Show Details Button
            if (ListAlarms.SelectedIndex != -1)
            {
                line = Lines[ListAlarms.SelectedIndex].ToString();
                Lines.RemoveAt(ListAlarms.SelectedIndex);
                ListAlarms.Items.RemoveAt(ListAlarms.SelectedIndex);
                string[] line2 = line.Split(';');
                Hour.Text = line2[0].ToString();
                Min.Text = line2[1].ToString();
                AP.Text = line2[2].ToString();
                TextTitle.Text = line2[3].ToString();
                PathSound.Text = line2[4].ToString();
                Shows();
            }
            else
            {
                Letter( "You Havenot Items");
            }
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //To Visit Our WebSite
            Process.Start("https:\\WWW.Google.com");
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            //To Remove Alarms
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            if (ListAlarms.SelectedIndex != -1)
            {
                Lines.RemoveAt(ListAlarms.SelectedIndex);
                ListAlarms.Items.RemoveAt(ListAlarms.SelectedIndex);
                File.WriteAllLines("Alarms.txt", Lines);
                Letter("The Item Is Deleted");
            }
            else
            {
                Letter( "you Haven't items");
            }
        }
        private void Label10_Click(object sender, EventArgs e)
        {
            //To Select Path Of Song For Alarms
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PathSound.Text = openFileDialog1.FileName.ToString();
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            //To Still On This Size
            this.Size = new Size(435, 400);
        }
        private void Label2_Click(object sender, EventArgs e)
        {
            //To Close The Application
            Closes = false;
            Application.Exit();
        }
        /// <summary>
        /// Start Groups Methods
        /// </summary>
        //Start To Move This Form
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {

            MD = 1;
            MU = e.X;
            MM = e.Y;
        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MD = 0;
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MU, MousePosition.Y - MM);
            }
        }
        //End To Move This Form
        //Start Hover On LHome
        private void LHome_MouseEnter(object sender, EventArgs e)
        {
            if (LHome.ForeColor.Name.ToString() == "White")
            {
                LHome.ForeColor = Color.Orange;
            }
        }
        private void LHome_MouseLeave(object sender, EventArgs e)
        {
            if (Active != "LHome")
            {
                if (LHome.ForeColor.Name.ToString() == "Orange")
                {
                    LHome.ForeColor = Color.White;
                }
            }
        }
        //End Hover On LHome
        //Start Hover On LAlarm
        private void LAlarm_MouseEnter(object sender, EventArgs e)
        {
            if (LAlarm.ForeColor.Name.ToString() == "White")
            {
                LAlarm.ForeColor = Color.Orange;
            }
        }
        private void LAlarm_MouseLeave(object sender, EventArgs e)
        {
            if (Active != "LAlarm")
            {
                if (LAlarm.ForeColor.Name.ToString() == "Orange")
                {
                    LAlarm.ForeColor = Color.White;
                }
            }
        }
        //End Hover On LAlarm
        //Start Hover On LPlus
        private void LPlus_MouseEnter(object sender, EventArgs e)
        {
            if (LPlus.ForeColor.Name.ToString() == "White")
            {
                LPlus.ForeColor = Color.Orange;
            }
        }
        private void LPlus_MouseLeave(object sender, EventArgs e)
        {
            if (Active != "LPlus")
            {
                if (LPlus.ForeColor.Name.ToString() == "Orange")
                {
                    LPlus.ForeColor = Color.White;
                }
            }
        }
        //End Hover On LPlus
        //Start Hover On Label10
        private void Label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.CornflowerBlue;
        }
        private void Label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Orange;
        }
        //End Hover On Label10
        //Start Mouse Leave On Some TextBox To Set Default
        private void Min_Leave(object sender, EventArgs e)
        {
            if (Min.Text.Trim() != "")
            {
                if (Min.Text.Length == 1)
                {
                    Min.Text = "0" + (int.Parse(Min.Text)).ToString();
                }
            }
        }
        private void Hour_Leave(object sender, EventArgs e)
        {
            if (Hour.Text.Trim() != "")
            {
                if (Hour.Text.Length == 1)
                {
                    Hour.Text = "0" + (int.Parse(Hour.Text)).ToString();
                }
            }
        }
        private void TextTitle_Leave(object sender, EventArgs e)
        {
            if (TextTitle.Text.Trim() == "")
            {
                TextTitle.Text = "Alarm";
            }
        }
        private void TextTitle_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextTitle.Text == "Alarm")
            {
                TextTitle.Text = "";
            }
        }
        //End Mouse Leave On Some TextBox To Set Default
        //Start Options Menu
        private void LHome_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                Active = "LHome";
                LAlarm.ForeColor = Color.White;
                LPlus.ForeColor = Color.White;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void LAlarm_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                Active = "LAlarm";
                LHome.ForeColor = Color.White;
                LPlus.ForeColor = Color.White;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void LPlus_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                Active = "LPlus";
                LHome.ForeColor = Color.White;
                LAlarm.ForeColor = Color.White;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        //End Options Menu
        //Start Close Or Hide
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Closes)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Wait!!", "The Application Is Still Runing", ToolTipIcon.Warning);
            }
        }
        //End Close Or Hide
        //Start Closeing
        private void Button1_Click(object sender, EventArgs e)
        {
            Closes = true;
            Application.Exit();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Closes = true;
            Application.Exit();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Closes = true;
            Application.Exit();
        }
        //End Closeing
        //Start Workers
        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CreateA.Height == 3)
            {
                for (int i = 0; i < (285 / 15); i++)
                {
                    System.Threading.Thread.Sleep(10);
                    CreateA.Invoke((MethodInvoker)delegate
                    {
                        CreateA.Height += 15;
                    });
                }
            }
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int X = ContainerPanel.Left;
            if (Active == "LHome")
            {
                if (X != 0)
                {
                    for (int i = 0; i < (X * -1) / 15; i++)
                    {
                        System.Threading.Thread.Sleep(1);
                        ContainerPanel.Invoke((MethodInvoker)delegate
                        {
                            ContainerPanel.Left += 15;
                        });
                    }
                }
            }
            else if (Active == "LAlarm")
            {
                if (X == 0)
                {
                    for (int i = 0; i < (435 / 15); i++)
                    {
                        System.Threading.Thread.Sleep(1);
                        ContainerPanel.Invoke((MethodInvoker)delegate
                        {
                            ContainerPanel.Left -= 15;
                        });
                    }
                }
                else if (X == -870)
                {
                    for (int i = 0; i < (435 / 15); i++)
                    {
                        System.Threading.Thread.Sleep(1);
                        ContainerPanel.Invoke((MethodInvoker)delegate
                        {
                            ContainerPanel.Left += 15;
                        });
                    }
                }
            }
            else if (Active == "LPlus")
            {
                if (X == 0)
                {
                    for (int i = 0; i < (870 / 15); i++)
                    {
                        System.Threading.Thread.Sleep(1);
                        ContainerPanel.Invoke((MethodInvoker)delegate
                        {
                            ContainerPanel.Left -= 15;
                        });
                    }
                }
                else if (X == -435)
                {
                    for (int i = 0; i < (435 / 15); i++)
                    {
                        System.Threading.Thread.Sleep(1);
                        ContainerPanel.Invoke((MethodInvoker)delegate
                        {
                            ContainerPanel.Left -= 15;
                        });
                    }
                }
            }
            else
            {
                ContainerPanel.Location = new Point(0, 65);
            }
        }
        //End Workers
        //Start Event Click Days
        private void Button7_Click(object sender, EventArgs e)
        {
            Days(button7);
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            Days(button12);
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            Days(button8);
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            Days(button13);
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            Days(button9);
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            Days(button10);
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            Days(button11);
        }
        //End Event Click Days
        //Start Options Of AP TextBox.Text
        private void Button19_Click(object sender, EventArgs e)
        {
            if (AP.Text == "AM")
            {
                AP.Text = "PM";
                Hour.Text = "12";
            }
            else
            {
                Hour.Text = "00";
                AP.Text = "AM";
            }
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            if (AP.Text == "AM")
            {
                Hour.Text = "12";
                AP.Text = "PM";
            }
            else
            {
                Hour.Text = "00";
                AP.Text = "AM";
            }
        }
        //End Options Of AP TextBox.Text
        //Start Add And Edit
        private void Button5_Click(object sender, EventArgs e)
        {
            if (TextTitle.Text.Trim() != "" && PathSound.Text.Trim() != "" && Hour.Text.Trim() != "" && Min.Text.Trim() != "")
            {
                if (line != null)
                {
                    //To Edit An Alarm
                    Letter( "The Alarm Is Edeted");
                    ADD();
                    RUN();
                    line = null;
                }
                else
                {
                    //To Add An Alarm And Exist Of It
                    bool GO = true;
                    string[] jak = File.ReadAllLines("Alarms.txt");
                    for (int i = 0; i < jak.Length; i++)
                    {
                        if (jak[i].Split(';')[3].ToString() == TextTitle.Text.Trim().ToString())
                        {
                            GO = false;
                        }
                    }
                    if (GO == true)
                    {
                        Lines.Add(Hour.Text + ";" + Min.Text + ";" + AP.Text + ";" + TextTitle.Text + ";" + PathSound.Text);
                        ListAlarms.Items.Add(TextTitle.Text + "        " + Hour.Text + " : " + Min.Text + " " + AP.Text);
                        File.WriteAllLines("Alarms.txt", Lines);
                        Letter( "The Alarm Is Added");
                        TextTitle.Text = "Alarm";
                        PathSound.Text = "";
                        RUN();
                        DefaultTime();
                        Heide();
                    }
                    else
                    {
                        Letter( "This Item Is Here please Change");
                        TextTitle.Text = "";
                        TextTitle.Focus();
                    }
                }
            }
            else
            {
                Letter( "Please Fill the empty Fialds");
            }
        }
        //End Add And Edit
        //Start Timers
        private void Timer3_Tick(object sender, EventArgs e)
        {
            int s = int.Parse(secondry.Text);
            int m = int.Parse(minuetry.Text);
            int h = int.Parse(houry.Text);
            if (s != 0 || m != 0 || h != 0)
            {
                secondry.Text = (s - 1).ToString();
                if (s == 0)
                {
                    if (m != 0)
                    {
                        s = 59;
                        secondry.Text = s.ToString();
                        minuetry.Text = (m - 1).ToString();
                    }
                }
                if (m == 0)
                {
                    if (h != 0)
                    {
                        m = 59;
                        minuetry.Text = m.ToString();
                        houry.Text = (h - 1).ToString();
                    }
                }
            }
            else
            {
                timer3.Enabled = false;
                comboBox1.Enabled = true;
                Letter( "The Timer Is Finish");
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            int x = DateTime.Now.Hour;
            if (x > 12)
            {
                x = 12;
            }
            else
            {
                x = 0;
            }
            if ((int.Parse(jak[0]) - x) == DateTime.Now.Hour - x)
            {
                if (int.Parse(jak[1]) == DateTime.Now.Minute)
                {
                    timer1.Enabled = false;
                    if (!File.Exists(@jak[4]))
                    {
                        jak[4] = "Default.wav";
                    }
                        AlarmsDok jk = new AlarmsDok(jak[0] + ":" + jak[1] + "   " + jak[2], jak[3], jak[4]);
                        jk.ShowDialog();
                        jak = null;
                    
                }
            }
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            int s = int.Parse(secondry.Text);
            int m = int.Parse(minuetry.Text);
            int h = int.Parse(houry.Text);
            secondry.Text = (s + 1).ToString();
            if (s == 59)
            {
                s = 0;
                secondry.Text = s.ToString();
                minuetry.Text = (m + 1).ToString();
            }
            if (m == 59)
            {
                m = 0;
                minuetry.Text = m.ToString();
                houry.Text = (h + 1).ToString();
            }
        }
        //End Timers
        //Start Show NotifyIcon
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }
        private void NotifyIcon1_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Show();
        }
        //End Show NotifyIcon
        //Start Stop/Start Timer And ComboBox
        private void Button3_Click_1(object sender, EventArgs e)
        {
            ComBox(true);
        }

        private void Button20_Click_1(object sender, EventArgs e)
        {
            ComBox(false);
        }
        //End Stop/Start Timer And ComboBox
        //Start Hour+- And Min+- In Create Alarm
        private void Button14_Click(object sender, EventArgs e)
        {
            //Hour--
            if (int.Parse(Hour.Text) == 1)
            {
                Hour.Text = "00";
            }
            else
            {
                if (int.Parse(Hour.Text) == 0)
                {
                    Hour.Text = "23";
                }
                else
                {
                    Hour.Text = (int.Parse(Hour.Text) - 1).ToString();
                    if (Hour.Text.Length == 1)
                    {
                        Hour.Text = "0" + (int.Parse(Hour.Text)).ToString();
                    }
                }
            }
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            //Hour++
            if (int.Parse(Hour.Text) >= 24)
            {
                Hour.Text = "00";
            }
            else
            {
                Hour.Text = (int.Parse(Hour.Text) + 1).ToString();
                if (Hour.Text.Length == 1)
                {
                    Hour.Text = "0" + (int.Parse(Hour.Text)).ToString();
                }
            }
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            //Min--
            if (int.Parse(Min.Text) < 1)
            {
                Min.Text = "59";
            }
            else
            {
                Min.Text = (int.Parse(Min.Text) - 1).ToString();
                if (Min.Text.Length == 1)
                {
                    Min.Text = "0" + (int.Parse(Min.Text)).ToString();
                }
            }
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            //Min++
            if (int.Parse(Min.Text) >= 59)
            {
                Min.Text = "00";
            }
            else
            {
                Min.Text = (int.Parse(Min.Text) + 1).ToString();
                if (Min.Text.Length == 1)
                {
                    Min.Text = "0" + (int.Parse(Min.Text)).ToString();
                }
            }
        }
        //End Hour+- And Min+- In Create Alarm
        //Start TextCharnged Of Min And Hour To Set Default And Security
        private void Min_TextChanged(object sender, EventArgs e)
        {
            if (!(Min.Text.Trim().Length == 0))
            {
                if (int.Parse(Min.Text.Trim()) > 59 || int.Parse(Min.Text.Trim()) < 0)
                {
                    Min.Text = "00";
                }
            }
        }
        private void Hour_TextChanged(object sender, EventArgs e)
        {
            if (!(Hour.Text.Trim().Length == 0))
            {
                if (int.Parse(Hour.Text) >= 12)
                    AP.Text = "PM";
                else
                    AP.Text = "AM";
                if (int.Parse(Hour.Text.Trim()) > 23 || int.Parse(Hour.Text.Trim()) < 0)
                {
                    Hour.Text = "00";
                }
            }
        }
        //End TextCharnged Of Min And Hour To Set Default And Security
        /// <summary>
        /// /////////////////////////////////Custom
        /// </summary>
        /// //Start Custom Methods
        /// You Can Know There Jops From Names
        private void ComBox(bool a)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                timer2.Enabled = a;
                comboBox1.Enabled = !a;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    timer3.Enabled = a;
                    comboBox1.Enabled = !a;
                }
            }
        }
        private void Itemsave()
        {
            ListPM.Items.Clear();
            if (comboBox1.SelectedIndex == 1)
            {
                string[] p = File.ReadAllLines("Pluss.txt");
                asdf.Clear();
                ListPM.Items.AddRange(p); ;
                asdf.AddRange(p);
                houry.Cursor = minuetry.Cursor = secondry.Cursor = Cursors.Default;
                houry.ReadOnly = minuetry.ReadOnly = secondry.ReadOnly = true;
                houry.Text = minuetry.Text = secondry.Text = "00";
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    asdfg.Clear();
                    string[] m = File.ReadAllLines("Miness.txt");
                    ListPM.Items.AddRange(m);
                    asdfg.AddRange(m);
                    houry.Cursor = minuetry.Cursor = secondry.Cursor = Cursors.IBeam;
                    houry.ReadOnly = minuetry.ReadOnly = secondry.ReadOnly = false;
                    houry.Text = minuetry.Text = secondry.Text = "00";
                }
            }
        }
        private void Heide()
        {
            CreateA.Height = 3;
            LALL.Visible = true;
            Exit.Visible = true;
            ListAlarms.Visible = true;
            ShowDetails.Visible = true;
            delete.Visible = true;
            CreateA.BackColor = Color.Orange;
        }
        private void RUN()
        {
            if (ListAlarms.Items.Count == 1)
            {
                jak = Lines[0].ToString().Split(';');
                timer1.Enabled = true;
            }
        }
        private void Shows()
        {
            CreateA.BackColor = Color.FromArgb(255, 44, 44, 44);
            LALL.Visible = false;
            Exit.Visible = false;
            ListAlarms.Visible = false;
            ShowDetails.Visible = false;
            delete.Visible = false;
            if (line != null)
            {
                button5.Text = "Edit";
            }
            else
            {
                line = null;
            }
            backgroundWorker2.RunWorkerAsync();
        }
        private void DefaultTime()
        {
            Min.Text = DateTime.Now.Minute.ToString();
            if (DateTime.Now.ToString("tt") == "ص")
            {
                AP.Text = "AM";
                Hour.Text = DateTime.Now.Hour.ToString();
            }
            else
            {
                AP.Text = "PM";
                if (!(DateTime.Now.Hour > 12))
                {
                    Hour.Text = (DateTime.Now.Hour + 12).ToString();
                }
                else
                {
                    Hour.Text = DateTime.Now.Hour.ToString(); ;
                }
            }
            TextTitle.Text = "Alarm";
            PathSound.Text = "Default.wav";
        }
        private void Days(Control CON)
        {
            if (CON.ForeColor.Name.ToString() == "CornflowerBlue")
            {
                CON.BackColor = Color.CornflowerBlue;
                CON.ForeColor = Color.FromArgb(255, 44, 44, 44);
                CON.Width += 4;
                CON.Height += 4;
                CON.Left -= 2;
                CON.Top -= 2;
            }
            else
            {
                CON.BackColor = Color.FromArgb(255, 44, 44, 44);
                CON.ForeColor = Color.CornflowerBlue;
                CON.Width -= 4;
                CON.Height -= 4;
                CON.Left += 2;
                CON.Top += 2;
            }
        }
        private void ADD()
        {
            if (TextTitle.Text.Trim() != "" && PathSound.Text.Trim() != "")
            {
                bool GO = true;
                for (int i = 0; i < Lines.Count; i++)
                {
                    if (Lines[i].Split(';')[3].ToString() == TextTitle.Text.Trim().ToString())
                    {
                        GO = false;
                    }
                }
                if (GO == true)
                {
                    ListAlarms.Items.Add(TextTitle.Text + "        " + Hour.Text + " : " + Min.Text + " " + AP.Text);
                    Lines.Add(Hour.Text + ";" + Min.Text + ";" + AP.Text + ";" + TextTitle.Text + ";" + PathSound.Text);
                    File.WriteAllLines("Alarms.txt", Lines.ToArray());
                    line = null;
                    Heide();
                }
            }
        }
        private void Letter(string content = null)
        {
            
            Letter LRT = new Letter(content);
            LRT.ShowDialog();
        }
        /// //End Custom Methods
        /// //End Groups Methods
    }
}