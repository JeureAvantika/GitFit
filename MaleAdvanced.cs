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
    public partial class MaleAdvanced : Form
    {
        public MaleAdvanced()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaleBegWarmup male = new MaleBegWarmup();
            male.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaleBeginner male = new MaleBeginner();
            male.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Nutri1 obj = new Nutri1();
            obj.ShowDialog();
            obj = null;
            this.Show();
        }
    }
}
