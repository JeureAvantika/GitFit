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
    public partial class Account : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\JEURE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string level, weight,gainloss;
            level = textBox1.Text;
            weight = textBox2.Text;
            gainloss = textBox3.Text;

            try
            {
                string querry = "SELECT * FROM Registration2 WHERE level='" + textBox1.Text + "' AND weight='" + textBox2.Text + "' AND gainloss='"+textBox3+"'";
                SqlDataAdapter obj = new SqlDataAdapter(querry, con);
                DataTable dt = new DataTable();
                obj.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    level = textBox1.Text;
                    weight = textBox2.Text;
                    gainloss = textBox3.Text;
                    AboutNutri acc = new AboutNutri();
                    acc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
