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
    public partial class Letter : Form
    {
        string TextContent;
        public Letter(string content)
        {
            this.TextContent = content;
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Letter_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255,33,33,33);
            label1.Text = TextContent;
        }
    }
}
