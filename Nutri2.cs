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
    public partial class Nutri2 : Form
    {
        public Nutri2()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutNutri obj = new AboutNutri();
            obj.MdiParent = this;
            obj.Show();
            obj = null;
            this.Show(); 
        }

        private void yourMealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usermeal obj = new usermeal();
            obj.MdiParent = this;
            obj.Show();
            obj = null;
            this.Show(); 
        }

        private void dietChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WtGainDietChart obj = new WtGainDietChart();
            obj.MdiParent = this;
            obj.Show();
            // obj.ShowDialog();
            obj = null;
            this.Show(); 
        }

        private void suggestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Suggestion obj = new Suggestion();
            obj.MdiParent = this;
            obj.Show();
            obj = null;
            this.Show(); 
        }
    }
}
