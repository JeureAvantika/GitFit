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
    public partial class MaleBegwtgainWorkout : Form
    {
        public MaleBegwtgainWorkout()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureBox8.Visible = true;
            label1.Visible = true;

            button5.Visible = true;
            label2.Visible = true;


            if (pictureBox8.Visible || pictureBox9.Visible || pictureBox10.Visible || pictureBox11.Visible || pictureBox12.Visible || pictureBox13.Visible)
            {
                pictureBox8.Visible = true;
                label1.Visible = true;

                button5.Visible = true;
                label2.Visible = true;

                label1.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;


                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;

                label3.Visible = false;
                label4.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;






            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Visible)
            {
                pictureBox8.Visible = false;
                label1.Visible = false;
                pictureBox9.Visible = true;
                label3.Visible = true;

                label2.Visible = true;
                button5.Visible = true;
            }

            if (pictureBox8.Visible || pictureBox9.Visible || pictureBox10.Visible || pictureBox11.Visible || pictureBox12.Visible || pictureBox13.Visible)
            {



                button5.Visible = true;
                label2.Visible = true;


                label1.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;

                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;









            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (pictureBox9.Visible)
            {
                pictureBox9.Visible = false;
                label1.Visible = false;
                pictureBox10.Visible = true;
                label4.Visible = true;
                label3.Visible = false;

                label2.Visible = true;
                button5.Visible = true;

            }

            if (pictureBox8.Visible || pictureBox9.Visible || pictureBox10.Visible || pictureBox11.Visible || pictureBox12.Visible || pictureBox13.Visible)
            {



                button5.Visible = true;
                label2.Visible = true;


                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;

                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;



                //button1.Visible = true;
                //label2.Visible = true;





            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Visible)
            {
                pictureBox10.Visible = false;
                label1.Visible = false;
                pictureBox11.Visible = true;
                label4.Visible = false;
                label3.Visible = false;
                label6.Visible = true;

                label2.Visible = true;
                button5.Visible = true;

            }
            if (pictureBox8.Visible || pictureBox9.Visible || pictureBox10.Visible || pictureBox11.Visible || pictureBox12.Visible || pictureBox13.Visible)
            {



                button5.Visible = true;
                label2.Visible = true;


                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = true;
                label7.Visible = false;
                label8.Visible = false;

                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;



                //button1.Visible = true;
                //label2.Visible = true;





            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (pictureBox11.Visible)
            {
                pictureBox11.Visible = false;
                label1.Visible = false;
                pictureBox12.Visible = true;
                label4.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                label7.Visible = true;

                label2.Visible = true;
                button5.Visible = true;

            }
            if (pictureBox8.Visible || pictureBox9.Visible || pictureBox10.Visible || pictureBox11.Visible || pictureBox12.Visible || pictureBox13.Visible)
            {



                button5.Visible = true;
                label2.Visible = true;


                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
                label8.Visible = false;

                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
                pictureBox13.Visible = false;



                //button1.Visible = true;
                //label2.Visible = true;





            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Visible)
            {
                pictureBox12.Visible = false;
                label1.Visible = false;
                pictureBox13.Visible = true;
                label4.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = true;

                label2.Visible = true;
                button5.Visible = true;

            }
            if (pictureBox8.Visible || pictureBox9.Visible || pictureBox10.Visible || pictureBox11.Visible || pictureBox12.Visible || pictureBox13.Visible)
            {



                button5.Visible = true;
                label2.Visible = true;


                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = true;

                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;



                //button1.Visible = true;
                //label2.Visible = true;





            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nutition1 nutri = new Nutition1();
            nutri.ShowDialog();
            nutri = null;
            this.Show(); 
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
