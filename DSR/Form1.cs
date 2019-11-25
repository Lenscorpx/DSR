using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DSR
{
    public partial class Form1 : Form
    {
        int count = 0, buffer = 0;
        public Form1()
        {            
            InitializeComponent();
            Opacity = 0;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
            pictureBox3.Hide();
            if (buffer == 30)
            {
                timer3.Start();
                timer2.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Hide();
                var m = new Forms.frm_welcome();
                m.Show();
                timer3.Stop();
                var hack = new Codes.Logs();
                hack.insert_logs(DateTime.Now, Convert.ToString(Environment.MachineName), Convert.ToString(Environment.UserName), Convert.ToString(Environment.OSVersion));
            }
            else
            {
                count--;
                Opacity = count * 0.10;
                pictureBox3.Show();
                pictureBox2.Hide();
                pictureBox1.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                count++;
                Opacity = count * 0.10;
                pictureBox1.Show();
                pictureBox2.Hide();
                pictureBox3.Hide();
            }
        }
    }
}
