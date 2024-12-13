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
    public partial class warmupFemale : Form
    {
        public warmupFemale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Warmup obj = new Warmup();
            obj.ShowDialog();
            obj = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Workout female = new Workout();
            female.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nutition1 nutri = new Nutition1();
            nutri.Show();
        }
    }
}
