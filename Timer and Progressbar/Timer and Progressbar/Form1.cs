using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_and_Progressbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value -= 10;
            }
            catch (Exception)
            {
                MessageBox.Show("Progess is Minimum");
            }
            label1.Text = progressBar1.Value.ToString() + "%";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value += 10;
            }
            catch (Exception)
            {
                MessageBox.Show("Progess is Maximum");
            }
            label1.Text = progressBar1.Value.ToString() + "%";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
                if (progressBar1.Value == 80)
                {
                    timer1.Stop();
                    timer1.Stop();
                    timer1.Stop();
                    timer1.Stop();
                    timer1.Stop();
                    timer1.Stop();
                    timer2.Start();
                }
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
                timer1.Stop();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();
        }
    }
}
