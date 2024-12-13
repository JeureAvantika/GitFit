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
    public partial class DietChart : Form
    {
        public DietChart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (pictureBox1.Visible || pictureBox2.Visible || pictureBox3.Visible || pictureBox4.Visible || pictureBox5.Visible || pictureBox6.Visible || pictureBox7.Visible)
            //{

                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
        //}

        private void DietChart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

                if (pictureBox1.Visible)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                }
                if (pictureBox1.Visible || pictureBox2.Visible || pictureBox3.Visible || pictureBox4.Visible || pictureBox5.Visible || pictureBox6.Visible || pictureBox7.Visible)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
                if (pictureBox2.Visible)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                }

                if (pictureBox1.Visible || pictureBox2.Visible || pictureBox3.Visible || pictureBox4.Visible || pictureBox5.Visible || pictureBox6.Visible || pictureBox7.Visible)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
                if (pictureBox3.Visible)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                }

                if (pictureBox1.Visible || pictureBox2.Visible || pictureBox3.Visible || pictureBox4.Visible || pictureBox5.Visible || pictureBox6.Visible || pictureBox7.Visible)
                {

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

                if (pictureBox4.Visible)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                }
                if (pictureBox1.Visible || pictureBox2.Visible || pictureBox3.Visible || pictureBox4.Visible || pictureBox5.Visible || pictureBox6.Visible || pictureBox7.Visible)
                {


                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

                if (pictureBox5.Visible)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = false;
                }


                if (pictureBox1.Visible || pictureBox2.Visible || pictureBox3.Visible || pictureBox4.Visible || pictureBox5.Visible || pictureBox6.Visible || pictureBox7.Visible)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        { if (pictureBox6.Visible)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = true;
                }

        if (pictureBox1.Visible || pictureBox2.Visible || pictureBox3.Visible || pictureBox4.Visible || pictureBox5.Visible || pictureBox6.Visible || pictureBox7.Visible)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            }
        
        }
    }
}
