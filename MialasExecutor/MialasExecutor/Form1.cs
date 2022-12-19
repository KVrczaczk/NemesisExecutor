using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MialasExecutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Clear();
            guna2Panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Value += 3;
            }

            if (guna2ProgressBar1.Value >= 70)
            {
                guna2PictureBox2.Visible = false;
                guna2PictureBox1.Visible = true;
            }

            if (guna2ProgressBar1.Value >= 100)
            {
                UserControl1 uc1 = new UserControl1();
                timer1.Stop();
                guna2Panel1.Visible = true;
                guna2PictureBox1.Visible = false;
                AddUserControl(uc1);
            }
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
