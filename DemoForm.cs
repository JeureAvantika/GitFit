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
    public partial class DemoForm : Form
    {


       // string gender;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Documents\JEURE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        public DemoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { }
    }
}
        //{
        //    SqlCommand cmd;

        //    if (radioButton1.Checked)
        //    {
        //        gender = "Male";
        //    }
        //    else if (radioButton2.Checked)
        //    {
        //        gender = "Female";
        //    }
        //    string query = "insert into signup2 values(@gender)";

        //    cmd = new SqlCommand(query, con);
        //    cmd.Parameters.AddWithValue("@gender", gender);
        //    // MessageBox.Show("inserted");
        //    //cmd.ExecuteNonQuery();
        //    string query1 = "insert into signup2 values(@uname,@email,@createpass,@confirmpass) ";
        //    cmd = new SqlCommand(query1, con);
        //    cmd.Parameters.AddWithValue("@uname",textBox1.Text);
        //    cmd.Parameters.AddWithValue("@email", textBox2.Text);
        //    cmd.Parameters.AddWithValue("@createpass", textBox3.Text);
        //    cmd.Parameters.AddWithValue("@confirmpass", textBox4.Text);

        //    MessageBox.Show("inserted");

            //try
            //{

            //    con.Open();
            //  //  SqlCommand cmd1 = con.CreateCommand();
                //cmd1.CommandType = CommandType.Text;
                //cmd1.CommandText = "insert into signup2 Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                ////,'" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + dateTimePicker1.Value.ToString() + "' )";//+ "','" + gender + "')";
                //cmd1.ExecuteNonQuery();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        //}
            //SqlCommand cmd;
            //
    //    }
    //}
    
            
            
            
            
            
            //{
            //      string expression = default(string);
            //        expression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            //        if (Regex.IsMatch(textBox2.Text, expression) && (textBox3.Text == textBox4.Text))
            //        {

            //            SqlCommand cmd;
            //            try
            //            {
    //    }
    //}
//}