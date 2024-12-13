using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class MaleWorkoutR2 : Form
    {
        public MaleWorkoutR2()
        {
            InitializeComponent();
        }
        int seconds = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = seconds--.ToString();
            if (seconds == 0)
            {
                timer1.Stop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seconds = 10;
            timer1.Start();
        }
    }
}
