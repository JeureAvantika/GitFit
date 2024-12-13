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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\JEURE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your name";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //if (textBox2.Text == "Enter your password")
            //{
            //    textBox2.Text = "";
            //    textBox2.ForeColor = Color.Black;
            //}
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //    textBox2.Text = "Enter your password";
            //    textBox2.ForeColor = Color.Black;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            
            string uname, confirmpass;//,gainloss,level;
            uname = textBox1.Text;
            confirmpass = textBox2.Text;
            //gainloss = textBox3.Text;
            //level = textBox4.Text;

            try
            {  
                string querry = "SELECT * FROM signupTable  WHERE uname='" + textBox1.Text + "' AND confirmpass='" + textBox2.Text + "'";// AND gainloss='"+textBox3.Text+"' AND level='"+textBox4.Text+"'";
                SqlDataAdapter obj = new SqlDataAdapter(querry, con);
                DataTable dt = new DataTable();
                obj.Fill(dt);
                if (dt.Rows.Count > 0)
                {  
                    uname = textBox1.Text;
                    confirmpass = textBox2.Text;



                   // MessageBox.Show("Valid login");
                    Form2 obj1 = new Form2();
                    obj1.Show();

                  
                }
                else
                {
                    MessageBox.Show("Invalid login");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }


             
    
    

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }

        //private void comboBox1_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBox1_Enter(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedItem== "Your workout level")
        //    {
        //       comboBox1.SelectedItem = "";
        //       comboBox1.ForeColor = Color.Black;
        //    }
        //}

        //private void comboBox1_Leave(object sender, EventArgs e)
        //{
        //    if (comboBox1.SelectedItem== "")
        //    {
        //        comboBox1.SelectedItem = "Your workout level";
        //        comboBox1.ForeColor = Color.Black;
        //    }
        //}
    }
}
