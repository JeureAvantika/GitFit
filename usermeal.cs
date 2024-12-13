using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class usermeal : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\JEURE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public usermeal()
        {
            InitializeComponent();
        }

        private void usermeal_Load(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && textBox5.Text != null)
            //{


            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null && textBox5.Text == null)
            {
                MessageBox.Show("info incorrect!!");
            }
            else
            {

                SqlCommand cmd;
                try
                {
                    con.Open();
                    string insert = "insert into sunday values(@msnack,@breakfast,@lunch,@esnack,@dinner)";
                    cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@msnack", textBox1.Text);
                    cmd.Parameters.AddWithValue("@breakfast", textBox2.Text);
                    cmd.Parameters.AddWithValue("@lunch", textBox3.Text);
                    cmd.Parameters.AddWithValue("@esnack", textBox4.Text);
                    cmd.Parameters.AddWithValue("@dinner", textBox5.Text);


                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Thank you!!");
                    button2.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();


            }
        }

            //   else
            //{
            //    MessageBox.Show("Insert your meal properly");
            //}
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != null && textBox7.Text != null && textBox8.Text != null && textBox9.Text != null && textBox10.Text != null)
            {
                SqlCommand cmd;
                try
                {
                    con.Open();
                    string insert = "insert into monday values(@msnack,@breakfast,@lunch,@esnack,@dinner)";
                    cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@msnack", textBox10.Text);
                    cmd.Parameters.AddWithValue("@breakfast", textBox9.Text);
                    cmd.Parameters.AddWithValue("@lunch", textBox8.Text);
                    cmd.Parameters.AddWithValue("@esnack", textBox7.Text);
                    cmd.Parameters.AddWithValue("@dinner", textBox6.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank you!!");
                    button3.Visible = true;

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Insert your meal properly");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != null && textBox12.Text != null && textBox13.Text != null && textBox14.Text != null && textBox15.Text != null)
            {
                SqlCommand cmd;
                try
                {
                    con.Open();
                    string insert = "insert into tuesday values(@msnack,@breakfast,@lunch,@esnack,@dinner)";
                    cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@msnack", textBox15.Text);
                    cmd.Parameters.AddWithValue("@breakfast", textBox14.Text);
                    cmd.Parameters.AddWithValue("@lunch", textBox13.Text);
                    cmd.Parameters.AddWithValue("@esnack", textBox12.Text);
                    cmd.Parameters.AddWithValue("@dinner", textBox11.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank you!!");
                    button4.Visible = true;

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Insert your meal properly");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox16.Text != null && textBox17.Text != null && textBox18.Text != null && textBox19.Text != null && textBox20.Text != null)
            {
                SqlCommand cmd;
                try
                {
                    con.Open();
                    string insert = "insert into wednesday values(@msnack,@breakfast,@lunch,@esnack,@dinner)";
                    cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@msnack", textBox20.Text);
                    cmd.Parameters.AddWithValue("@breakfast", textBox19.Text);
                    cmd.Parameters.AddWithValue("@lunch", textBox18.Text);
                    cmd.Parameters.AddWithValue("@esnack", textBox17.Text);
                    cmd.Parameters.AddWithValue("@dinner", textBox16.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank you!!");
                    button5.Visible = true;

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Insert your meal properly");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox21.Text != null && textBox22.Text != null && textBox23.Text != null && textBox24.Text != null && textBox25.Text != null)
            {
                SqlCommand cmd;
                try
                {
                    con.Open();
                    string insert = "insert into thursday values(@msnack,@breakfast,@lunch,@esnack,@dinner)";
                    cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@msnack", textBox25.Text);
                    cmd.Parameters.AddWithValue("@breakfast", textBox24.Text);
                    cmd.Parameters.AddWithValue("@lunch", textBox23.Text);
                    cmd.Parameters.AddWithValue("@esnack", textBox22.Text);
                    cmd.Parameters.AddWithValue("@dinner", textBox21.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank you!!");
                    button6.Visible = true;

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Insert your meal properly");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox26.Text != null && textBox27.Text != null && textBox28.Text != null && textBox29.Text != null && textBox30.Text != null)
            {
                SqlCommand cmd;
                try
                {
                    con.Open();
                    string insert = "insert into friday values(@msnack,@breakfast,@lunch,@esnack,@dinner)";
                    cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@msnack", textBox30.Text);
                    cmd.Parameters.AddWithValue("@breakfast", textBox29.Text);
                    cmd.Parameters.AddWithValue("@lunch", textBox28.Text);
                    cmd.Parameters.AddWithValue("@esnack", textBox27.Text);
                    cmd.Parameters.AddWithValue("@dinner", textBox26.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank you!!");
                    button7.Visible = true;

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Insert your meal properly");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox31.Text != null && textBox32.Text != null && textBox33.Text != null && textBox34.Text != null && textBox35.Text != null)
            {
                SqlCommand cmd;
                try
                {
                    con.Open();
                    string insert = "insert into saturday values(@msnack,@breakfast,@lunch,@esnack,@dinner)";
                    cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@msnack", textBox35.Text);
                    cmd.Parameters.AddWithValue("@breakfast", textBox34.Text);
                    cmd.Parameters.AddWithValue("@lunch", textBox33.Text);
                    cmd.Parameters.AddWithValue("@esnack", textBox32.Text);
                    cmd.Parameters.AddWithValue("@dinner", textBox31.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank you!!");
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Insert your meal properly");
            }
        }
    }
}
