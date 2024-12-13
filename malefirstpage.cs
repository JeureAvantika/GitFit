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
    public partial class malefirstpage : Form
    {
        public malefirstpage()
        {
            InitializeComponent();
        }

        private void malefirstpage_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maleworkoutfirst obj = new Maleworkoutfirst();
            obj.ShowDialog();
            obj = null;
            this.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaleBegWarmup obj = new MaleBegWarmup();
            obj.ShowDialog();
            obj = null;
            this.Show(); 


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
