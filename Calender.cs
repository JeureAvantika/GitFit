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
    public partial class Calender : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\JEURE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Calender()
        {
            InitializeComponent();
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            //ovalShape2.Visible = true;
        }

        private void Calender_Load(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



                
        }

        private void label1_Click(object sender, EventArgs e)
        {

            string f = textBox1.Text="completed";
            label34.Text = f;
            SqlCommand cmd;
            try
            {
                con.Open();

                string insert = "insert into calender1 values(@dates,@status)";
                cmd = new SqlCommand(insert, con);

                cmd.Parameters.AddWithValue("@dates", label1.Text);
                cmd.Parameters.AddWithValue("@status", textBox1.Text);

                cmd.ExecuteNonQuery();
                First obj = new First();
                obj.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Invalid data..");
            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}