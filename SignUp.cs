using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication3
{
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\JEURE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4 != null)//&& textBox3.Text == textBox4.Text)
            {
                string expression = default(string);
                expression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(textBox2.Text, expression) && (textBox3.Text == textBox4.Text))
                {
                    SqlCommand cmd;
                    try
                    {

                        con.Open();

                        string insert = "insert into signupTable  values(@uname,@email,@createpass,@confirmpass)";//,@gender


                        cmd = new SqlCommand(insert, con);
                        cmd.Parameters.AddWithValue("@uname", textBox1.Text); //.ToString());
                        cmd.Parameters.AddWithValue("@email", textBox2.Text);
                        // cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@createpass", textBox3.Text);
                        cmd.Parameters.AddWithValue("@confirmpass", textBox4.Text);
                        cmd.ExecuteNonQuery();
                       // MessageBox.Show("inserted");
                        this.Hide();
                        Registration obj = new Registration();
                        obj.ShowDialog();
                        obj = null;
                        this.Show();

                      //  MessageBox.Show("Info incorrect");




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Invalid data..");
                    }
                    con.Close();
                }


                else
                {
                    //MessageBox.Show("Not a valid Email address ");
                    MessageBox.Show("Information is incorrect ");
                }
            }
            else
            {
                MessageBox.Show("Invalid data");
            }







        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Username";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Email id")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }
     

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter Email id";
                textBox2.ForeColor = Color.Black;
            }
           

        }


        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Create Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }


        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Create Password";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Confirm Password")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Confirm Password";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void textBox5_Enter(object sender, EventArgs e)
        //{

        //    if (textBox5.Text == "Enter your gender")
        //    {
        //        textBox4.Text = "";
        //        textBox4.ForeColor = Color.Black;
        //    }
        //}

        //private void SignUp_Leave(object sender, EventArgs e)
        //{
        //    if (textBox5.Text == "")
        //    {
        //        textBox4.Text = "Enter your gender";
        //        textBox4.ForeColor = Color.Black;
        //    }
        //}

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
            obj = null;
            this.Show();
        }

       


    }
}
    
