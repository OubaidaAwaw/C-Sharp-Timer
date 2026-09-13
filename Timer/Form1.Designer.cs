namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.LPlus = new System.Windows.Forms.Label();
            this.LAlarm = new System.Windows.Forms.Label();
            this.LHome = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PHome = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PAlarm = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.ListAlarms = new System.Windows.Forms.ListBox();
            this.LALL = new System.Windows.Forms.Label();
            this.CreateClick = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateA = new System.Windows.Forms.Panel();
            this.PathSound = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.MaskedTextBox();
            this.Min = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ShowDetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.PPlus = new System.Windows.Forms.Panel();
            this.secondry = new System.Windows.Forms.MaskedTextBox();
            this.minuetry = new System.Windows.Forms.MaskedTextBox();
            this.houry = new System.Windows.Forms.MaskedTextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.ListPM = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PHome.SuspendLayout();
            this.PAlarm.SuspendLayout();
            this.CreateClick.SuspendLayout();
            this.CreateA.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PPlus.SuspendLayout();
            this.ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LPlus);
            this.panel7.Controls.Add(this.LAlarm);
            this.panel7.Controls.Add(this.LHome);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(0, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1305, 25);
            this.panel7.TabIndex = 1;
            // 
            // LPlus
            // 
            this.LPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LPlus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPlus.ForeColor = System.Drawing.Color.White;
            this.LPlus.Location = new System.Drawing.Point(274, 2);
            this.LPlus.Name = "LPlus";
            this.LPlus.Size = new System.Drawing.Size(45, 23);
            this.LPlus.TabIndex = 2;
            this.LPlus.Text = "+-";
            this.LPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LPlus, "To Set An Increasing Or Secreasing Alarm");
            this.LPlus.Click += new System.EventHandler(this.LPlus_Click);
            this.LPlus.MouseEnter += new System.EventHandler(this.LPlus_MouseEnter);
            this.LPlus.MouseLeave += new System.EventHandler(this.LPlus_MouseLeave);
            // 
            // LAlarm
            // 
            this.LAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LAlarm.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAlarm.ForeColor = System.Drawing.Color.White;
            this.LAlarm.Location = new System.Drawing.Point(196, 2);
            this.LAlarm.Name = "LAlarm";
            this.LAlarm.Size = new System.Drawing.Size(72, 23);
            this.LAlarm.TabIndex = 1;
            this.LAlarm.Text = "Alarm";
            this.LAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LAlarm, "To Set New Alarms");
            this.LAlarm.Click += new System.EventHandler(this.LAlarm_Click);
            this.LAlarm.MouseEnter += new System.EventHandler(this.LAlarm_MouseEnter);
            this.LAlarm.MouseLeave += new System.EventHandler(this.LAlarm_MouseLeave);
            // 
            // LHome
            // 
            this.LHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LHome.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHome.ForeColor = System.Drawing.Color.Orange;
            this.LHome.Location = new System.Drawing.Point(120, 2);
            this.LHome.Name = "LHome";
            this.LHome.Size = new System.Drawing.Size(70, 23);
            this.LHome.TabIndex = 0;
            this.LHome.Text = "Home";
            this.LHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LHome, "About Us");
            this.LHome.Click += new System.EventHandler(this.LHome_Click);
            this.LHome.MouseEnter += new System.EventHandler(this.LHome_MouseEnter);
            this.LHome.MouseLeave += new System.EventHandler(this.LHome_MouseLeave);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Timer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "|*Mp3;";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // PHome
            // 
            this.PHome.Controls.Add(this.linkLabel1);
            this.PHome.Controls.Add(this.label5);
            this.PHome.Controls.Add(this.label4);
            this.PHome.Controls.Add(this.label3);
            this.PHome.Controls.Add(this.button1);
            this.PHome.Location = new System.Drawing.Point(0, -1);
            this.PHome.Name = "PHome";
            this.PHome.Size = new System.Drawing.Size(435, 335);
            this.PHome.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Orange;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(33, 256);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 25);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Our Web Site";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 105);
            this.label5.TabIndex = 8;
            this.label5.Text = "We are honored to have you on our website to receive all our programs, products a" +
    "nd updates, and thank you for your very supportive support.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 64);
            this.label4.TabIndex = 7;
            this.label4.Text = "I created this program to serve the interests of people who want to monitor their" +
    " time and what they accomplished during it.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hello World!";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(319, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.toolTip1.SetToolTip(this.button1, "Exit Application");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PAlarm
            // 
            this.PAlarm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PAlarm.Controls.Add(this.delete);
            this.PAlarm.Controls.Add(this.ListAlarms);
            this.PAlarm.Controls.Add(this.LALL);
            this.PAlarm.Controls.Add(this.CreateClick);
            this.PAlarm.Controls.Add(this.CreateA);
            this.PAlarm.Controls.Add(this.ShowDetails);
            this.PAlarm.Controls.Add(this.panel2);
            this.PAlarm.Controls.Add(this.Exit);
            this.PAlarm.Location = new System.Drawing.Point(435, -1);
            this.PAlarm.Name = "PAlarm";
            this.PAlarm.Size = new System.Drawing.Size(435, 335);
            this.PAlarm.TabIndex = 3;
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.delete.Location = new System.Drawing.Point(197, 287);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(115, 35);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.toolTip1.SetToolTip(this.delete, "To Delete An Alarm");
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ListAlarms
            // 
            this.ListAlarms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListAlarms.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ListAlarms.FormattingEnabled = true;
            this.ListAlarms.ItemHeight = 25;
            this.ListAlarms.Location = new System.Drawing.Point(21, 81);
            this.ListAlarms.Name = "ListAlarms";
            this.ListAlarms.Size = new System.Drawing.Size(397, 200);
            this.ListAlarms.TabIndex = 12;
            this.toolTip1.SetToolTip(this.ListAlarms, "All Alarms");
            // 
            // LALL
            // 
            this.LALL.Cursor = System.Windows.Forms.Cursors.Default;
            this.LALL.ForeColor = System.Drawing.Color.Orange;
            this.LALL.Location = new System.Drawing.Point(16, 49);
            this.LALL.Name = "LALL";
            this.LALL.Size = new System.Drawing.Size(125, 29);
            this.LALL.TabIndex = 2;
            this.LALL.Text = "All Alarms:";
            this.LALL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateClick
            // 
            this.CreateClick.Controls.Add(this.label6);
            this.CreateClick.Controls.Add(this.pictureBox1);
            this.CreateClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateClick.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateClick.Location = new System.Drawing.Point(0, 0);
            this.CreateClick.Name = "CreateClick";
            this.CreateClick.Size = new System.Drawing.Size(435, 42);
            this.CreateClick.TabIndex = 8;
            this.toolTip1.SetToolTip(this.CreateClick, "To Add A New Alarm");
            this.CreateClick.Click += new System.EventHandler(this.Label6_Click_1);
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 42);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add New Alarm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.label6, "To Add A New Alarm");
            this.label6.Click += new System.EventHandler(this.Label6_Click_1);
            // 
            // CreateA
            // 
            this.CreateA.BackColor = System.Drawing.Color.Orange;
            this.CreateA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateA.Controls.Add(this.button19);
            this.CreateA.Controls.Add(this.button18);
            this.CreateA.Controls.Add(this.button17);
            this.CreateA.Controls.Add(this.button16);
            this.CreateA.Controls.Add(this.button15);
            this.CreateA.Controls.Add(this.button14);
            this.CreateA.Controls.Add(this.PathSound);
            this.CreateA.Controls.Add(this.label10);
            this.CreateA.Controls.Add(this.button13);
            this.CreateA.Controls.Add(this.button12);
            this.CreateA.Controls.Add(this.button11);
            this.CreateA.Controls.Add(this.button10);
            this.CreateA.Controls.Add(this.button9);
            this.CreateA.Controls.Add(this.button8);
            this.CreateA.Controls.Add(this.button7);
            this.CreateA.Controls.Add(this.TextTitle);
            this.CreateA.Controls.Add(this.label9);
            this.CreateA.Controls.Add(this.AP);
            this.CreateA.Controls.Add(this.label8);
            this.CreateA.Controls.Add(this.Hour);
            this.CreateA.Controls.Add(this.Min);
            this.CreateA.Controls.Add(this.label7);
            this.CreateA.Controls.Add(this.button6);
            this.CreateA.Controls.Add(this.button5);
            this.CreateA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateA.Location = new System.Drawing.Point(5, 45);
            this.CreateA.Margin = new System.Windows.Forms.Padding(0);
            this.CreateA.Name = "CreateA";
            this.CreateA.Size = new System.Drawing.Size(425, 3);
            this.CreateA.TabIndex = 7;
            // 
            // PathSound
            // 
            this.PathSound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathSound.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathSound.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.PathSound.Location = new System.Drawing.Point(219, 198);
            this.PathSound.Name = "PathSound";
            this.PathSound.ReadOnly = true;
            this.PathSound.Size = new System.Drawing.Size(148, 33);
            this.PathSound.TabIndex = 35;
            this.PathSound.Text = "Default.wav";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(13, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 33);
            this.label10.TabIndex = 34;
            this.label10.Text = "Select Sound:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            this.label10.MouseEnter += new System.EventHandler(this.Label10_MouseEnter);
            this.label10.MouseLeave += new System.EventHandler(this.Label10_MouseLeave);
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button13.Location = new System.Drawing.Point(344, 85);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 35);
            this.button13.TabIndex = 33;
            this.button13.Text = "A";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button12.Location = new System.Drawing.Point(344, 44);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 35);
            this.button12.TabIndex = 32;
            this.button12.Text = "A";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button11.Location = new System.Drawing.Point(344, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 35);
            this.button11.TabIndex = 31;
            this.button11.Text = "A";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button10.Location = new System.Drawing.Point(385, 126);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 35);
            this.button10.TabIndex = 30;
            this.button10.Text = "A";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button9.Location = new System.Drawing.Point(385, 85);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 35);
            this.button9.TabIndex = 29;
            this.button9.Text = "A";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button8.Location = new System.Drawing.Point(385, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 28;
            this.button8.Text = "A";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Location = new System.Drawing.Point(385, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 27;
            this.button7.Text = "A";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // TextTitle
            // 
            this.TextTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TextTitle.Location = new System.Drawing.Point(112, 159);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(148, 33);
            this.TextTitle.TabIndex = 26;
            this.TextTitle.Text = "Alarm";
            this.TextTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextTitle_MouseClick);
            this.TextTitle.Leave += new System.EventHandler(this.TextTitle_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(13, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 33);
            this.label9.TabIndex = 25;
            this.label9.Text = "Title :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AP
            // 
            this.AP.AutoSize = true;
            this.AP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AP.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.AP.Location = new System.Drawing.Point(264, 50);
            this.AP.Name = "AP";
            this.AP.Size = new System.Drawing.Size(101, 58);
            this.AP.TabIndex = 23;
            this.AP.Text = "AM";
            this.AP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(241, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 50);
            this.label8.TabIndex = 18;
            this.label8.Text = ":";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hour
            // 
            this.Hour.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Hour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Hour.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Hour.Location = new System.Drawing.Point(57, 50);
            this.Hour.Name = "Hour";
            this.Hour.PromptChar = ' ';
            this.Hour.Size = new System.Drawing.Size(70, 58);
            this.Hour.TabIndex = 13;
            this.Hour.Text = "00";
            this.Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hour.TextChanged += new System.EventHandler(this.Hour_TextChanged);
            this.Hour.Leave += new System.EventHandler(this.Hour_Leave);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Min.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Min.Location = new System.Drawing.Point(170, 50);
            this.Min.Mask = "00";
            this.Min.Name = "Min";
            this.Min.PromptChar = ' ';
            this.Min.Size = new System.Drawing.Size(70, 58);
            this.Min.TabIndex = 12;
            this.Min.Text = "00";
            this.Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min.TextChanged += new System.EventHandler(this.Min_TextChanged);
            this.Min.Leave += new System.EventHandler(this.Min_Leave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(135, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 50);
            this.label7.TabIndex = 11;
            this.label7.Text = ":";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Location = new System.Drawing.Point(228, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 35);
            this.button6.TabIndex = 8;
            this.button6.Text = "Cancel";
            this.toolTip1.SetToolTip(this.button6, "To Cancel Operator");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Location = new System.Drawing.Point(69, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "Add";
            this.toolTip1.SetToolTip(this.button5, "To Add Or Edit An Alarm");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // ShowDetails
            // 
            this.ShowDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDetails.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ShowDetails.Location = new System.Drawing.Point(21, 287);
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(170, 35);
            this.ShowDetails.TabIndex = 10;
            this.ShowDetails.Text = "Show Details";
            this.toolTip1.SetToolTip(this.ShowDetails, "To Show Details And Edit");
            this.ShowDetails.UseVisualStyleBackColor = true;
            this.ShowDetails.Click += new System.EventHandler(this.Button20_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(432, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 335);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(319, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Exit.Location = new System.Drawing.Point(318, 287);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 35);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.toolTip1.SetToolTip(this.Exit, "Exit Application");
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Button3_Click);
            // 
            // PPlus
            // 
            this.PPlus.Controls.Add(this.secondry);
            this.PPlus.Controls.Add(this.minuetry);
            this.PPlus.Controls.Add(this.houry);
            this.PPlus.Controls.Add(this.button23);
            this.PPlus.Controls.Add(this.button22);
            this.PPlus.Controls.Add(this.ListPM);
            this.PPlus.Controls.Add(this.comboBox1);
            this.PPlus.Controls.Add(this.button21);
            this.PPlus.Controls.Add(this.button20);
            this.PPlus.Controls.Add(this.button3);
            this.PPlus.Controls.Add(this.label15);
            this.PPlus.Controls.Add(this.label14);
            this.PPlus.Controls.Add(this.button4);
            this.PPlus.Location = new System.Drawing.Point(870, 0);
            this.PPlus.Name = "PPlus";
            this.PPlus.Size = new System.Drawing.Size(433, 332);
            this.PPlus.TabIndex = 7;
            // 
            // secondry
            // 
            this.secondry.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.secondry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondry.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondry.ForeColor = System.Drawing.Color.Orange;
            this.secondry.Location = new System.Drawing.Point(287, 15);
            this.secondry.Mask = "00";
            this.secondry.Name = "secondry";
            this.secondry.PromptChar = ' ';
            this.secondry.Size = new System.Drawing.Size(87, 81);
            this.secondry.TabIndex = 45;
            this.secondry.Text = "00";
            this.secondry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuetry
            // 
            this.minuetry.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.minuetry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minuetry.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuetry.ForeColor = System.Drawing.Color.Orange;
            this.minuetry.Location = new System.Drawing.Point(172, 15);
            this.minuetry.Mask = "00";
            this.minuetry.Name = "minuetry";
            this.minuetry.PromptChar = ' ';
            this.minuetry.Size = new System.Drawing.Size(87, 81);
            this.minuetry.TabIndex = 44;
            this.minuetry.Text = "00";
            this.minuetry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // houry
            // 
            this.houry.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.houry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.houry.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houry.ForeColor = System.Drawing.Color.Orange;
            this.houry.Location = new System.Drawing.Point(58, 15);
            this.houry.Mask = "00";
            this.houry.Name = "houry";
            this.houry.PromptChar = ' ';
            this.houry.Size = new System.Drawing.Size(87, 81);
            this.houry.TabIndex = 43;
            this.houry.Text = "00";
            this.houry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button23
            // 
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button23.Location = new System.Drawing.Point(336, 103);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 50);
            this.button23.TabIndex = 25;
            this.button23.Text = "RE";
            this.toolTip1.SetToolTip(this.button23, "To Set Default");
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Button23_Click);
            // 
            // button22
            // 
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button22.Location = new System.Drawing.Point(202, 283);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(108, 35);
            this.button22.TabIndex = 24;
            this.button22.Text = "Remove";
            this.toolTip1.SetToolTip(this.button22, "To Remove A Result");
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Button22_Click);
            // 
            // ListPM
            // 
            this.ListPM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListPM.ForeColor = System.Drawing.Color.Orange;
            this.ListPM.FormattingEnabled = true;
            this.ListPM.ItemHeight = 25;
            this.ListPM.Location = new System.Drawing.Point(20, 155);
            this.ListPM.Name = "ListPM";
            this.ListPM.Size = new System.Drawing.Size(397, 125);
            this.ListPM.TabIndex = 23;
            this.toolTip1.SetToolTip(this.ListPM, "All Results");
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--",
            "++"});
            this.comboBox1.Location = new System.Drawing.Point(19, 285);
            this.comboBox1.MaxDropDownItems = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 33);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 22;
            this.toolTip1.SetToolTip(this.comboBox1, "To Switshing");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button21
            // 
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button21.Location = new System.Drawing.Point(228, 103);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(116, 50);
            this.button21.TabIndex = 21;
            this.button21.Text = "Save";
            this.toolTip1.SetToolTip(this.button21, "To Save Result");
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Button21_Click);
            // 
            // button20
            // 
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button20.Location = new System.Drawing.Point(133, 103);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(106, 50);
            this.button20.TabIndex = 20;
            this.button20.Text = "Stop";
            this.toolTip1.SetToolTip(this.button20, "To stop counting ascending or descending");
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Button20_Click_1);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(19, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 50);
            this.button3.TabIndex = 19;
            this.button3.Text = "Start";
            this.toolTip1.SetToolTip(this.button3, "To Counting Ascending Or Descending");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // label15
            // 
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Orange;
            this.label15.Location = new System.Drawing.Point(142, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 80);
            this.label15.TabIndex = 18;
            this.label15.Text = ":";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Orange;
            this.label14.Location = new System.Drawing.Point(256, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 80);
            this.label14.TabIndex = 17;
            this.label14.Text = ":";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(317, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Exit";
            this.toolTip1.SetToolTip(this.button4, "Exit Application");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Controls.Add(this.PPlus);
            this.ContainerPanel.Controls.Add(this.PAlarm);
            this.ContainerPanel.Controls.Add(this.PHome);
            this.ContainerPanel.Location = new System.Drawing.Point(0, 65);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1302, 332);
            this.ContainerPanel.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Timer.Properties.Resources.Untitled1;
            this.pictureBox1.Location = new System.Drawing.Point(385, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 42);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "To Add A New Alarm");
            this.pictureBox1.Click += new System.EventHandler(this.Label6_Click_1);
            // 
            // button19
            // 
            this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button19.Location = new System.Drawing.Point(287, 10);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(51, 41);
            this.button19.TabIndex = 41;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Button19_Click);
            // 
            // button18
            // 
            this.button18.BackgroundImage = global::Timer.Properties.Resources.jak;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button18.Location = new System.Drawing.Point(287, 108);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(51, 41);
            this.button18.TabIndex = 40;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Button18_Click);
            // 
            // button17
            // 
            this.button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button17.BackgroundImage")));
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button17.Location = new System.Drawing.Point(180, 10);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(51, 41);
            this.button17.TabIndex = 39;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Button17_Click);
            // 
            // button16
            // 
            this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button16.Location = new System.Drawing.Point(67, 9);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(51, 41);
            this.button16.TabIndex = 38;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // button15
            // 
            this.button15.BackgroundImage = global::Timer.Properties.Resources.jak;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button15.Location = new System.Drawing.Point(180, 108);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 41);
            this.button15.TabIndex = 37;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImage = global::Timer.Properties.Resources.jak;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button14.Location = new System.Drawing.Point(67, 108);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(51, 41);
            this.button14.TabIndex = 36;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::Timer.Properties.Resources.Uafdfdased1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(1264, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "   ";
            this.toolTip1.SetToolTip(this.label2, "To Hide The Applicaion And Still Runing");
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1305, 398);
            this.ControlBox = false;
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PHome.ResumeLayout(false);
            this.PHome.PerformLayout();
            this.PAlarm.ResumeLayout(false);
            this.CreateClick.ResumeLayout(false);
            this.CreateA.ResumeLayout(false);
            this.CreateA.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PPlus.ResumeLayout(false);
            this.PPlus.PerformLayout();
            this.ContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LPlus;
        private System.Windows.Forms.Label LAlarm;
        private System.Windows.Forms.Label LHome;
        private System.Windows.Forms.Timer timer3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PAlarm;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox ListAlarms;
        private System.Windows.Forms.Label LALL;
        private System.Windows.Forms.Panel CreateClick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel CreateA;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox PathSound;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox TextTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label AP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox Hour;
        private System.Windows.Forms.MaskedTextBox Min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ShowDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel PPlus;
        private System.Windows.Forms.MaskedTextBox secondry;
        private System.Windows.Forms.MaskedTextBox minuetry;
        private System.Windows.Forms.MaskedTextBox houry;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.ListBox ListPM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}