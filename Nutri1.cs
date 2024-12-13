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
    public partial class Nutri1 : Form
    {
       // Boolean b = true;
        public Nutri1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        //     if (b == true)
        //     {

                 menuStrip1.Dock = DockStyle.Left;
        //         b = false;
        //         toolStripMenuItem1.Image = Image.FromFile(@"E:\project\right1.png");
        //     }
        //     else
        //     {

                // menuStrip1.Dock = DockStyle.Top;
             //    b = true;
             //    toolStripMenuItem1.Image = Image.FromFile(@"E:\project\bottom1.png");
             //}
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

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            AboutNutri obj = new AboutNutri();
            obj.MdiParent = this;
            obj.Show();
            obj = null;
            this.Show(); 

        //    AboutNutri obj = new AboutNutri();
        //    obj.MdiParent = this;
        //    obj.Show();
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
            DietChart obj = new DietChart();
            obj.MdiParent = this;
            obj.Show();
           // obj.ShowDialog();
            obj = null;
            this.Show(); 
        }

        private void Nutri1_Load(object sender, EventArgs e)
        {

        }
    }
}

        //private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //   
        //}
 //          this.Hide();
 //           Warmup obj = new Warmup();
 //           obj.ShowDialog();
 //           obj = null;
 //           this.Show(); 