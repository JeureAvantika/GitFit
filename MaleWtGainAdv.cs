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
    public partial class MaleWtGainAdv : Form
    {
        public MaleWtGainAdv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaleBegWarmup obj = new MaleBegWarmup();
            obj.ShowDialog();
            obj = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaleBeginner obj = new MaleBeginner();
            obj.ShowDialog();
            obj = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nutri1 obj = new Nutri1();
            obj.ShowDialog();
            obj = null;
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
