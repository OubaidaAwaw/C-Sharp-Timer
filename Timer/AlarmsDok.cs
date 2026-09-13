using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class AlarmsDok : Form
    {
        string time,title, pathsound;
        public AlarmsDok(string time,string title,string pathsound)
        {
            this.time = time;
            this.title = title;
            this.pathsound = pathsound;
            InitializeComponent();
        }
        WMPLib.WindowsMediaPlayer jak = new WMPLib.WindowsMediaPlayer();
        bool tf = false;
        private void AlarmsDok_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!tf)
            e.Cancel = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            tf = true;
            this.Close();
            if (pathsound != null)
                jak.controls.stop();
        }
        private void AlarmsDok_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0,0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
            this.BackColor = Color.FromArgb(255,44,44,44);
            Photo.Location = new Point((this.Width-Photo.Width)/2,(this.Height-Photo.Height)/2);
            if(pathsound != null)
            { 
            jak.URL =pathsound;
            jak.controls.play();
            label1.Text = time;
            label2.Text = title;
            }
        }
    }
}
