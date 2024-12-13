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
    public partial class MaleWorkoutR3 : Form
    {
        public MaleWorkoutR3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            malebegworkout2 obj = new malebegworkout2();
            obj.ShowDialog();
            obj = null;
            this.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
